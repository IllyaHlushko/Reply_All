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
#include "UnityEngine_UnityEngine_Vector22243707579.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrScreenTest
struct  scrScreenTest_t4114089216  : public MonoBehaviour_t1158329972
{
public:
	// System.Single scrScreenTest::screenWidth
	float ___screenWidth_2;
	// System.Single scrScreenTest::screenHeight
	float ___screenHeight_3;
	// UnityEngine.Vector2 scrScreenTest::mousePosition
	Vector2_t2243707579  ___mousePosition_4;
	// UnityEngine.GameObject scrScreenTest::Icon
	GameObject_t1756533147 * ___Icon_5;
	// UnityEngine.Vector2 scrScreenTest::tmpDimension
	Vector2_t2243707579  ___tmpDimension_6;

public:
	inline static int32_t get_offset_of_screenWidth_2() { return static_cast<int32_t>(offsetof(scrScreenTest_t4114089216, ___screenWidth_2)); }
	inline float get_screenWidth_2() const { return ___screenWidth_2; }
	inline float* get_address_of_screenWidth_2() { return &___screenWidth_2; }
	inline void set_screenWidth_2(float value)
	{
		___screenWidth_2 = value;
	}

	inline static int32_t get_offset_of_screenHeight_3() { return static_cast<int32_t>(offsetof(scrScreenTest_t4114089216, ___screenHeight_3)); }
	inline float get_screenHeight_3() const { return ___screenHeight_3; }
	inline float* get_address_of_screenHeight_3() { return &___screenHeight_3; }
	inline void set_screenHeight_3(float value)
	{
		___screenHeight_3 = value;
	}

	inline static int32_t get_offset_of_mousePosition_4() { return static_cast<int32_t>(offsetof(scrScreenTest_t4114089216, ___mousePosition_4)); }
	inline Vector2_t2243707579  get_mousePosition_4() const { return ___mousePosition_4; }
	inline Vector2_t2243707579 * get_address_of_mousePosition_4() { return &___mousePosition_4; }
	inline void set_mousePosition_4(Vector2_t2243707579  value)
	{
		___mousePosition_4 = value;
	}

	inline static int32_t get_offset_of_Icon_5() { return static_cast<int32_t>(offsetof(scrScreenTest_t4114089216, ___Icon_5)); }
	inline GameObject_t1756533147 * get_Icon_5() const { return ___Icon_5; }
	inline GameObject_t1756533147 ** get_address_of_Icon_5() { return &___Icon_5; }
	inline void set_Icon_5(GameObject_t1756533147 * value)
	{
		___Icon_5 = value;
		Il2CppCodeGenWriteBarrier(&___Icon_5, value);
	}

	inline static int32_t get_offset_of_tmpDimension_6() { return static_cast<int32_t>(offsetof(scrScreenTest_t4114089216, ___tmpDimension_6)); }
	inline Vector2_t2243707579  get_tmpDimension_6() const { return ___tmpDimension_6; }
	inline Vector2_t2243707579 * get_address_of_tmpDimension_6() { return &___tmpDimension_6; }
	inline void set_tmpDimension_6(Vector2_t2243707579  value)
	{
		___tmpDimension_6 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
