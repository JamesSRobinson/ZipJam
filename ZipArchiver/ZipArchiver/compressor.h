#include "stdafx.h"
#include "zlib.h"
#include "zconf.h"
#include <string>
#include <iostream>

using namespace std;

int zipcompress(FILE *source, FILE *dest, int level);
