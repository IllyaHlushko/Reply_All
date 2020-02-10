#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "mscorlib_System_Object2689449295.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// FAd
struct  FAd_t2837997669  : public Il2CppObject
{
public:
	// System.Single FAd::delayTime
	float ___delayTime_0;
	// System.Int32 FAd::repeat
	int32_t ___repeat_1;
	// System.Single FAd::repeatDelayTime
	float ___repeatDelayTime_2;

public:
	inline static int32_t get_offset_of_delayTime_0() { return static_cast<int32_t>(offsetof(FAd_t2837997669, ___delayTime_0)); }
	inline float get_delayTime_0() const { return ___delayTime_0; }
	inline float* get_address_of_delayTime_0() { return &___delayTime_0; }
	inline void set_delayTime_0(float value)
	{
		___delayTime_0 = value;
	}

	inline static int32_t get_offset_of_repeat_1() { return static_cast<int32_t>(offsetof(FAd_t2837997669, ___repeat_1)); }
	inline int32_t get_repeat_1() const { return ___repeat_1; }
	inline int32_t* get_address_of_repeat_1() { return &___repeat_1; }
	inline void set_repeat_1(int32_t value)
	{
		___repeat_1 = value;
	}

	inline static int32_t get_offset_of_repeatDelayTime_2() { return static_cast<int32_t>(offsetof(FAd_t2837997669, ___repeatDelayTime_2)); }
	inline float get_repeatDelayTime_2() const { return ___repeatDelayTime_2; }
	inline float* get_address_of_repeatDelayTime_2() { return &___repeatDelayTime_2; }
	inline void set_repeatDelayTime_2(float value)
	{
		___repeatDelayTime_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
