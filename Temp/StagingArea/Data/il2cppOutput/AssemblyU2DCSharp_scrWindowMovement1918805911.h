#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>


#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"
#include "UnityEngine_UnityEngine_Vector22243707579.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrWindowMovement
struct  scrWindowMovement_t1918805911  : public MonoBehaviour_t1158329972
{
public:
	// System.Boolean scrWindowMovement::followMouse
	bool ___followMouse_2;
	// UnityEngine.Vector2 scrWindowMovement::offSet
	Vector2_t2243707579  ___offSet_3;

public:
	inline static int32_t get_offset_of_followMouse_2() { return static_cast<int32_t>(offsetof(scrWindowMovement_t1918805911, ___followMouse_2)); }
	inline bool get_followMouse_2() const { return ___followMouse_2; }
	inline bool* get_address_of_followMouse_2() { return &___followMouse_2; }
	inline void set_followMouse_2(bool value)
	{
		___followMouse_2 = value;
	}

	inline static int32_t get_offset_of_offSet_3() { return static_cast<int32_t>(offsetof(scrWindowMovement_t1918805911, ___offSet_3)); }
	inline Vector2_t2243707579  get_offSet_3() const { return ___offSet_3; }
	inline Vector2_t2243707579 * get_address_of_offSet_3() { return &___offSet_3; }
	inline void set_offSet_3(Vector2_t2243707579  value)
	{
		___offSet_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
