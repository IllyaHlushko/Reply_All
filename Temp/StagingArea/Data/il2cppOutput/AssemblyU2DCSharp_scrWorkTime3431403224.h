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

// scrWorkTime
struct  scrWorkTime_t3431403224  : public MonoBehaviour_t1158329972
{
public:
	// System.Single scrWorkTime::endTime
	float ___endTime_2;
	// System.Single scrWorkTime::currentTime
	float ___currentTime_3;
	// System.Int32 scrWorkTime::secondsPerHour
	int32_t ___secondsPerHour_4;
	// System.Int32 scrWorkTime::hours
	int32_t ___hours_5;
	// System.Int32 scrWorkTime::minutes
	int32_t ___minutes_6;
	// UnityEngine.Transform scrWorkTime::clock
	Transform_t3275118058 * ___clock_7;

public:
	inline static int32_t get_offset_of_endTime_2() { return static_cast<int32_t>(offsetof(scrWorkTime_t3431403224, ___endTime_2)); }
	inline float get_endTime_2() const { return ___endTime_2; }
	inline float* get_address_of_endTime_2() { return &___endTime_2; }
	inline void set_endTime_2(float value)
	{
		___endTime_2 = value;
	}

	inline static int32_t get_offset_of_currentTime_3() { return static_cast<int32_t>(offsetof(scrWorkTime_t3431403224, ___currentTime_3)); }
	inline float get_currentTime_3() const { return ___currentTime_3; }
	inline float* get_address_of_currentTime_3() { return &___currentTime_3; }
	inline void set_currentTime_3(float value)
	{
		___currentTime_3 = value;
	}

	inline static int32_t get_offset_of_secondsPerHour_4() { return static_cast<int32_t>(offsetof(scrWorkTime_t3431403224, ___secondsPerHour_4)); }
	inline int32_t get_secondsPerHour_4() const { return ___secondsPerHour_4; }
	inline int32_t* get_address_of_secondsPerHour_4() { return &___secondsPerHour_4; }
	inline void set_secondsPerHour_4(int32_t value)
	{
		___secondsPerHour_4 = value;
	}

	inline static int32_t get_offset_of_hours_5() { return static_cast<int32_t>(offsetof(scrWorkTime_t3431403224, ___hours_5)); }
	inline int32_t get_hours_5() const { return ___hours_5; }
	inline int32_t* get_address_of_hours_5() { return &___hours_5; }
	inline void set_hours_5(int32_t value)
	{
		___hours_5 = value;
	}

	inline static int32_t get_offset_of_minutes_6() { return static_cast<int32_t>(offsetof(scrWorkTime_t3431403224, ___minutes_6)); }
	inline int32_t get_minutes_6() const { return ___minutes_6; }
	inline int32_t* get_address_of_minutes_6() { return &___minutes_6; }
	inline void set_minutes_6(int32_t value)
	{
		___minutes_6 = value;
	}

	inline static int32_t get_offset_of_clock_7() { return static_cast<int32_t>(offsetof(scrWorkTime_t3431403224, ___clock_7)); }
	inline Transform_t3275118058 * get_clock_7() const { return ___clock_7; }
	inline Transform_t3275118058 ** get_address_of_clock_7() { return &___clock_7; }
	inline void set_clock_7(Transform_t3275118058 * value)
	{
		___clock_7 = value;
		Il2CppCodeGenWriteBarrier(&___clock_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
