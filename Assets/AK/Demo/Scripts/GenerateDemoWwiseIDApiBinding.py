#//////////////////////////////////////////////////////////////////////
#//
#// Copyright (c) 2012 Audiokinetic Inc. / All Rights Reserved
#//
# //////////////////////////////////////////////////////////////////////

import sys, os, os.path
g_ThisScriptDir = os.path.abspath(os.path.dirname(__file__))

GenDir = os.path.join(g_ThisScriptDir, os.pardir, os.pardir, os.pardir, 'StreamingAssets', 'Audio', 'GeneratedSoundBanks')
WwiseIDHeader = os.path.join(GenDir, 'Wwise_IDs.h')
DemoHeader = os.path.join(GenDir, 'Wwise_IDs.cs')

g_PosixLinebreak = '\n'
def ImportFile(inputFile):
	rawLines = []
	with open(inputFile) as f:
		rawLines = f.readlines()
		f.close()
	
	return rawLines

def ExportFile(outputFile, outputLines):
	# append line separators if none
	for ll in range(len(outputLines)):
		hasNoLinebreak = outputLines[ll].find(os.linesep) == -1 and outputLines[ll].find(g_PosixLinebreak) == -1
		if hasNoLinebreak:
			outputLines[ll] += g_PosixLinebreak
		
	with open(outputFile, 'w') as f:
		f.writelines(outputLines)
		f.close()


def FindKeyLine(lines, key):
	keyLineNumber = 0
	for ll in range(len(lines)):
		foundKey = lines[ll].find(key) != -1
		if foundKey:
			keyLineNumber = ll
			break
	return keyLineNumber

def ReplaceLineByLine(lines, inPattern, outPattern):
	for ll in range(len(lines)):
		namespaceStartCol = lines[ll].find(inPattern)
		foundNamespace = namespaceStartCol != -1
		if foundNamespace:
			lines[ll] = lines[ll].replace(inPattern, outPattern)

if __name__=='__main__':
	lines = ImportFile(WwiseIDHeader)

	# Extract ID part
	IDStartKey = 'namespace'
	startLine = FindKeyLine(lines, IDStartKey)
	IDEndKey = '#endif'
	endLine = FindKeyLine(lines, IDEndKey)
	lines = lines[startLine : endLine]

	# Use C# class for namespace
	CType = 'namespace'
	CSType = 'public class'
	ReplaceLineByLine(lines, CType, CSType)


	# Replace AK type with C# types
	CType = 'static const AkUniqueID'
	CSType = 'public static uint'
	ReplaceLineByLine(lines, CType, CSType)

	if not os.path.exists(GenDir):
		os.makedirs(GenDir)
	ExportFile(DemoHeader, lines)
