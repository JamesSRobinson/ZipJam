// ZipArchiver.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "zlib.h"
#include "zconf.h"
#include <string>
#include <iostream>
#include "compressor.h"

using namespace std;

int main(int argc, char *argv[])
{
	// check correct input, one path string.
	if (argc > 1) {
		printf("Too many input variables");
	}	

	string filePathName = argv[1];

	zipcompress(filePathName);

    return 0;
}


