#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.GameObject
struct GameObject_t1756533147;
// UnityEngine.Transform
struct Transform_t3275118058;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrRAMWindow
struct  scrRAMWindow_t2728565900  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject scrRAMWindow::textDispaly
	GameObject_t1756533147 * ___textDispaly_2;
	// UnityEngine.Transform scrRAMWindow::myRAM
	Transform_t3275118058 * ___myRAM_3;

public:
	inline static int32_t get_offset_of_textDispaly_2() { return static_cast<int32_t>(offsetof(scrRAMWindow_t2728565900, ___textDispaly_2)); }
	inline GameObject_t1756533147 * get_textDispaly_2() const { return ___textDispaly_2; }
	inline GameObject_t1756533147 ** get_address_of_textDispaly_2() { return &___textDispaly_2; }
	inline void set_textDispaly_2(GameObject_t1756533147 * value)
	{
		___textDispaly_2 = value;
		Il2CppCodeGenWriteBarrier(&___textDispaly_2, value);
	}

	inline static int32_t get_offset_of_myRAM_3() { return static_cast<int32_t>(offsetof(scrRAMWindow_t2728565900, ___myRAM_3)); }
	inline Transform_t3275118058 * get_myRAM_3() const { return ___myRAM_3; }
	inline Transform_t3275118058 ** get_address_of_myRAM_3() { return &___myRAM_3; }
	inline void set_myRAM_3(Transform_t3275118058 * value)
	{
		___myRAM_3 = value;
		Il2CppCodeGenWriteBarrier(&___myRAM_3, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
