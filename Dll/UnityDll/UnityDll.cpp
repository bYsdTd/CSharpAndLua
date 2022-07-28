#define LUA_LIB
#include "lua-5.3.5/src/luaconf.h"
#include <stdio.h>

extern "C" {
	LUA_API void hello();
}

LUA_API void hello()
{
	printf("hello world");
}