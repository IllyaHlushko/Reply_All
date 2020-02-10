#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// FMail
struct FMail_t3455079741;
// UnityEngine.GameObject
struct GameObject_t1756533147;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrSmallMail
struct  scrSmallMail_t3124903700  : public MonoBehaviour_t1158329972
{
public:
	// FMail scrSmallMail::myData
	FMail_t3455079741 * ___myData_2;
	// UnityEngine.GameObject scrSmallMail::textDispaly
	GameObject_t1756533147 * ___textDispaly_3;

public:
	inline static int32_t get_offset_of_myData_2() { return static_cast<int32_t>(offsetof(scrSmallMail_t3124903700, ___myData_2)); }
	inline FMail_t3455079741 * get_myData_2() const { return ___myData_2; }
	inline FMail_t3455079741 ** get_address_of_myData_2() { return &___myData_2; }
	inline void set_myData_2(FMail_t3455079741 * value)
	{
		___myData_2 = value;
		Il2CppCodeGenWriteBarrier(&___myData_2, value);
	}

	inline static int32_t get_offset_of_textDispaly_3() { return static_cast<int32_t>(offsetof(scrSmallMail_t3124903700, ___textDispaly_3)); }
	inline GameObject_t1756533147 * get_textDispaly_3() const { return ___textDispaly_3; }
	inline GameObject_t1756533147 ** get_address_of_textDispaly_3() { return &___textDispaly_3; }
	inline void set_textDispaly_3(GameObject_t1756533147 * value)
	{
		___textDispaly_3 = value;
		Il2CppCodeGenWriteBarrier(&___textDispaly_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
