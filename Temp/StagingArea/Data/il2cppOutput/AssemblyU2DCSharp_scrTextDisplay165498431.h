#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// UnityEngine.Sprite[]
struct SpriteU5BU5D_t3359083662;
// System.String
struct String_t;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector22243707579.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrTextDisplay
struct  scrTextDisplay_t165498431  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.Sprite[] scrTextDisplay::numbers
	SpriteU5BU5D_t3359083662* ___numbers_2;
	// UnityEngine.Vector2 scrTextDisplay::nextPosition
	Vector2_t2243707579  ___nextPosition_3;
	// System.String scrTextDisplay::sortingLayer
	String_t* ___sortingLayer_4;

public:
	inline static int32_t get_offset_of_numbers_2() { return static_cast<int32_t>(offsetof(scrTextDisplay_t165498431, ___numbers_2)); }
	inline SpriteU5BU5D_t3359083662* get_numbers_2() const { return ___numbers_2; }
	inline SpriteU5BU5D_t3359083662** get_address_of_numbers_2() { return &___numbers_2; }
	inline void set_numbers_2(SpriteU5BU5D_t3359083662* value)
	{
		___numbers_2 = value;
		Il2CppCodeGenWriteBarrier(&___numbers_2, value);
	}

	inline static int32_t get_offset_of_nextPosition_3() { return static_cast<int32_t>(offsetof(scrTextDisplay_t165498431, ___nextPosition_3)); }
	inline Vector2_t2243707579  get_nextPosition_3() const { return ___nextPosition_3; }
	inline Vector2_t2243707579 * get_address_of_nextPosition_3() { return &___nextPosition_3; }
	inline void set_nextPosition_3(Vector2_t2243707579  value)
	{
		___nextPosition_3 = value;
	}

	inline static int32_t get_offset_of_sortingLayer_4() { return static_cast<int32_t>(offsetof(scrTextDisplay_t165498431, ___sortingLayer_4)); }
	inline String_t* get_sortingLayer_4() const { return ___sortingLayer_4; }
	inline String_t** get_address_of_sortingLayer_4() { return &___sortingLayer_4; }
	inline void set_sortingLayer_4(String_t* value)
	{
		___sortingLayer_4 = value;
		Il2CppCodeGenWriteBarrier(&___sortingLayer_4, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
