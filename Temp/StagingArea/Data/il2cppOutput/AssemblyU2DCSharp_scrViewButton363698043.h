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

// scrViewButton
struct  scrViewButton_t363698043  : public MonoBehaviour_t1158329972
{
public:
	// System.String[] scrViewButton::file
	StringU5BU5D_t1642385972* ___file_2;
	// System.Boolean scrViewButton::virus
	bool ___virus_3;

public:
	inline static int32_t get_offset_of_file_2() { return static_cast<int32_t>(offsetof(scrViewButton_t363698043, ___file_2)); }
	inline StringU5BU5D_t1642385972* get_file_2() const { return ___file_2; }
	inline StringU5BU5D_t1642385972** get_address_of_file_2() { return &___file_2; }
	inline void set_file_2(StringU5BU5D_t1642385972* value)
	{
		___file_2 = value;
		Il2CppCodeGenWriteBarrier(&___file_2, value);
	}

	inline static int32_t get_offset_of_virus_3() { return static_cast<int32_t>(offsetof(scrViewButton_t363698043, ___virus_3)); }
	inline bool get_virus_3() const { return ___virus_3; }
	inline bool* get_address_of_virus_3() { return &___virus_3; }
	inline void set_virus_3(bool value)
	{
		___virus_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
