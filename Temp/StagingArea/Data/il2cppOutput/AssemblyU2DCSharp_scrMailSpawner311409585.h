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

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrMailSpawner
struct  scrMailSpawner_t311409585  : public MonoBehaviour_t1158329972
{
public:
	// UnityEngine.GameObject scrMailSpawner::smallMail
	GameObject_t1756533147 * ___smallMail_2;
	// System.Single scrMailSpawner::spawnDelay
	float ___spawnDelay_3;

public:
	inline static int32_t get_offset_of_smallMail_2() { return static_cast<int32_t>(offsetof(scrMailSpawner_t311409585, ___smallMail_2)); }
	inline GameObject_t1756533147 * get_smallMail_2() const { return ___smallMail_2; }
	inline GameObject_t1756533147 ** get_address_of_smallMail_2() { return &___smallMail_2; }
	inline void set_smallMail_2(GameObject_t1756533147 * value)
	{
		___smallMail_2 = value;
		Il2CppCodeGenWriteBarrier(&___smallMail_2, value);
	}

	inline static int32_t get_offset_of_spawnDelay_3() { return static_cast<int32_t>(offsetof(scrMailSpawner_t311409585, ___spawnDelay_3)); }
	inline float get_spawnDelay_3() const { return ___spawnDelay_3; }
	inline float* get_address_of_spawnDelay_3() { return &___spawnDelay_3; }
	inline void set_spawnDelay_3(float value)
	{
		___spawnDelay_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
