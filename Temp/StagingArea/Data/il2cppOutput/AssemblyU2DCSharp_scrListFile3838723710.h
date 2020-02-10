#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.String[]
struct StringU5BU5D_t1642385972;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrListFile
struct  scrListFile_t3838723710  : public MonoBehaviour_t1158329972
{
public:
	// System.String[] scrListFile::list
	StringU5BU5D_t1642385972* ___list_2;

public:
	inline static int32_t get_offset_of_list_2() { return static_cast<int32_t>(offsetof(scrListFile_t3838723710, ___list_2)); }
	inline StringU5BU5D_t1642385972* get_list_2() const { return ___list_2; }
	inline StringU5BU5D_t1642385972** get_address_of_list_2() { return &___list_2; }
	inline void set_list_2(StringU5BU5D_t1642385972* value)
	{
		___list_2 = value;
		Il2CppCodeGenWriteBarrier(&___list_2, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
