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

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Color2020392075.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrAdWindow
struct  scrAdWindow_t2599717785  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject scrAdWindow::closeButton
	GameObject_t1756533147 * ___closeButton_2;
	// UnityEngine.Color scrAdWindow::myC
	Color_t2020392075  ___myC_3;

public:
	inline static int32_t get_offset_of_closeButton_2() { return static_cast<int32_t>(offsetof(scrAdWindow_t2599717785, ___closeButton_2)); }
	inline GameObject_t1756533147 * get_closeButton_2() const { return ___closeButton_2; }
	inline GameObject_t1756533147 ** get_address_of_closeButton_2() { return &___closeButton_2; }
	inline void set_closeButton_2(GameObject_t1756533147 * value)
	{
		___closeButton_2 = value;
		Il2CppCodeGenWriteBarrier(&___closeButton_2, value);
	}

	inline static int32_t get_offset_of_myC_3() { return static_cast<int32_t>(offsetof(scrAdWindow_t2599717785, ___myC_3)); }
	inline Color_t2020392075  get_myC_3() const { return ___myC_3; }
	inline Color_t2020392075 * get_address_of_myC_3() { return &___myC_3; }
	inline void set_myC_3(Color_t2020392075  value)
	{
		___myC_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
