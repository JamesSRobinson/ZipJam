// ZipArchiver.cpp : Defines the entry point for the console application.
//



#include "stdafx.h"
#include "zlib.h"
#include "zconf.h"
#include <string>s
#include <iostream>
#include "compressor.h"

using namespace std;

int main(int argc, char *argv[])
{
	// check correct input, one path string.
	if (argc > 1) {
		printf("Too many input variables");
	}	

	string inputFilePathName = argv[1];

	string outputFilePathName = inputFilePathName + ".zip";

	FILE *inputFile;
	inputFile = fopen(inputFilePathName.c_str(), "r");

	FILE *outputFile;
	outputFile = fopen(outputFilePathName.c_str(), "w");

	zipcompress(inputFile, outputFile,1);

    return 0;
}


