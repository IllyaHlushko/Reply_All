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

// scrButtonSpawn
struct  scrButtonSpawn_t2652649029  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject scrButtonSpawn::button
	GameObject_t1756533147 * ___button_2;
	// System.Boolean scrButtonSpawn::dontClose
	bool ___dontClose_3;
	// UnityEngine.Vector2 scrButtonSpawn::offset
	Vector2_t2243707579  ___offset_4;

public:
	inline static int32_t get_offset_of_button_2() { return static_cast<int32_t>(offsetof(scrButtonSpawn_t2652649029, ___button_2)); }
	inline GameObject_t1756533147 * get_button_2() const { return ___button_2; }
	inline GameObject_t1756533147 ** get_address_of_button_2() { return &___button_2; }
	inline void set_button_2(GameObject_t1756533147 * value)
	{
		___button_2 = value;
		Il2CppCodeGenWriteBarrier(&___button_2, value);
	}

	inline static int32_t get_offset_of_dontClose_3() { return static_cast<int32_t>(offsetof(scrButtonSpawn_t2652649029, ___dontClose_3)); }
	inline bool get_dontClose_3() const { return ___dontClose_3; }
	inline bool* get_address_of_dontClose_3() { return &___dontClose_3; }
	inline void set_dontClose_3(bool value)
	{
		___dontClose_3 = value;
	}

	inline static int32_t get_offset_of_offset_4() { return static_cast<int32_t>(offsetof(scrButtonSpawn_t2652649029, ___offset_4)); }
	inline Vector2_t2243707579  get_offset_4() const { return ___offset_4; }
	inline Vector2_t2243707579 * get_address_of_offset_4() { return &___offset_4; }
	inline void set_offset_4(Vector2_t2243707579  value)
	{
		___offset_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
