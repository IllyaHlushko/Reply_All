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

// scrBigMail
struct  scrBigMail_t332870297  : public MonoBehaviour_t1158329972
{
public:
	// FMail scrBigMail::myData
	FMail_t3455079741 * ___myData_2;
	// UnityEngine.GameObject scrBigMail::textDispaly
	GameObject_t1756533147 * ___textDispaly_3;
	// UnityEngine.GameObject scrBigMail::sendButtonPF
	GameObject_t1756533147 * ___sendButtonPF_4;
	// UnityEngine.GameObject scrBigMail::viewButtonPF
	GameObject_t1756533147 * ___viewButtonPF_5;

public:
	inline static int32_t get_offset_of_myData_2() { return static_cast<int32_t>(offsetof(scrBigMail_t332870297, ___myData_2)); }
	inline FMail_t3455079741 * get_myData_2() const { return ___myData_2; }
	inline FMail_t3455079741 ** get_address_of_myData_2() { return &___myData_2; }
	inline void set_myData_2(FMail_t3455079741 * value)
	{
		___myData_2 = value;
		Il2CppCodeGenWriteBarrier(&___myData_2, value);
	}

	inline static int32_t get_offset_of_textDispaly_3() { return static_cast<int32_t>(offsetof(scrBigMail_t332870297, ___textDispaly_3)); }
	inline GameObject_t1756533147 * get_textDispaly_3() const { return ___textDispaly_3; }
	inline GameObject_t1756533147 ** get_address_of_textDispaly_3() { return &___textDispaly_3; }
	inline void set_textDispaly_3(GameObject_t1756533147 * value)
	{
		___textDispaly_3 = value;
		Il2CppCodeGenWriteBarrier(&___textDispaly_3, value);
	}

	inline static int32_t get_offset_of_sendButtonPF_4() { return static_cast<int32_t>(offsetof(scrBigMail_t332870297, ___sendButtonPF_4)); }
	inline GameObject_t1756533147 * get_sendButtonPF_4() const { return ___sendButtonPF_4; }
	inline GameObject_t1756533147 ** get_address_of_sendButtonPF_4() { return &___sendButtonPF_4; }
	inline void set_sendButtonPF_4(GameObject_t1756533147 * value)
	{
		___sendButtonPF_4 = value;
		Il2CppCodeGenWriteBarrier(&___sendButtonPF_4, value);
	}

	inline static int32_t get_offset_of_viewButtonPF_5() { return static_cast<int32_t>(offsetof(scrBigMail_t332870297, ___viewButtonPF_5)); }
	inline GameObject_t1756533147 * get_viewButtonPF_5() const { return ___viewButtonPF_5; }
	inline GameObject_t1756533147 ** get_address_of_viewButtonPF_5() { return &___viewButtonPF_5; }
	inline void set_viewButtonPF_5(GameObject_t1756533147 * value)
	{
		___viewButtonPF_5 = value;
		Il2CppCodeGenWriteBarrier(&___viewButtonPF_5, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
