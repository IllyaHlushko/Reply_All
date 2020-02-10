#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Transform
struct Transform_t3275118058;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrSpaceValues
struct  scrSpaceValues_t1714150848  : public MonoBehaviour_t1158329972
{
public:
	// System.Int32 scrSpaceValues::currentRAM
	int32_t ___currentRAM_2;
	// System.Int32 scrSpaceValues::maxRAM
	int32_t ___maxRAM_3;
	// UnityEngine.Transform scrSpaceValues::RAM
	Transform_t3275118058 * ___RAM_4;

public:
	inline static int32_t get_offset_of_currentRAM_2() { return static_cast<int32_t>(offsetof(scrSpaceValues_t1714150848, ___currentRAM_2)); }
	inline int32_t get_currentRAM_2() const { return ___currentRAM_2; }
	inline int32_t* get_address_of_currentRAM_2() { return &___currentRAM_2; }
	inline void set_currentRAM_2(int32_t value)
	{
		___currentRAM_2 = value;
	}

	inline static int32_t get_offset_of_maxRAM_3() { return static_cast<int32_t>(offsetof(scrSpaceValues_t1714150848, ___maxRAM_3)); }
	inline int32_t get_maxRAM_3() const { return ___maxRAM_3; }
	inline int32_t* get_address_of_maxRAM_3() { return &___maxRAM_3; }
	inline void set_maxRAM_3(int32_t value)
	{
		___maxRAM_3 = value;
	}

	inline static int32_t get_offset_of_RAM_4() { return static_cast<int32_t>(offsetof(scrSpaceValues_t1714150848, ___RAM_4)); }
	inline Transform_t3275118058 * get_RAM_4() const { return ___RAM_4; }
	inline Transform_t3275118058 ** get_address_of_RAM_4() { return &___RAM_4; }
	inline void set_RAM_4(Transform_t3275118058 * value)
	{
		___RAM_4 = value;
		Il2CppCodeGenWriteBarrier(&___RAM_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
