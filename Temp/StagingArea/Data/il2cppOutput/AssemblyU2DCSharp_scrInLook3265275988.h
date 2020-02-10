#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.Collections.Generic.List`1<FMail>
struct List_1_t2824200873;
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

// scrInLook
struct  scrInLook_t3265275988  : public MonoBehaviour_t1158329972
{
public:
	// System.Collections.Generic.List`1<FMail> scrInLook::myMails
	List_1_t2824200873 * ___myMails_2;
	// UnityEngine.GameObject scrInLook::bigMailPF
	GameObject_t1756533147 * ___bigMailPF_3;
	// UnityEngine.GameObject scrInLook::myBigMail
	GameObject_t1756533147 * ___myBigMail_4;
	// UnityEngine.GameObject scrInLook::textDisplayPF
	GameObject_t1756533147 * ___textDisplayPF_5;
	// UnityEngine.Transform scrInLook::myMailCount
	Transform_t3275118058 * ___myMailCount_6;

public:
	inline static int32_t get_offset_of_myMails_2() { return static_cast<int32_t>(offsetof(scrInLook_t3265275988, ___myMails_2)); }
	inline List_1_t2824200873 * get_myMails_2() const { return ___myMails_2; }
	inline List_1_t2824200873 ** get_address_of_myMails_2() { return &___myMails_2; }
	inline void set_myMails_2(List_1_t2824200873 * value)
	{
		___myMails_2 = value;
		Il2CppCodeGenWriteBarrier(&___myMails_2, value);
	}

	inline static int32_t get_offset_of_bigMailPF_3() { return static_cast<int32_t>(offsetof(scrInLook_t3265275988, ___bigMailPF_3)); }
	inline GameObject_t1756533147 * get_bigMailPF_3() const { return ___bigMailPF_3; }
	inline GameObject_t1756533147 ** get_address_of_bigMailPF_3() { return &___bigMailPF_3; }
	inline void set_bigMailPF_3(GameObject_t1756533147 * value)
	{
		___bigMailPF_3 = value;
		Il2CppCodeGenWriteBarrier(&___bigMailPF_3, value);
	}

	inline static int32_t get_offset_of_myBigMail_4() { return static_cast<int32_t>(offsetof(scrInLook_t3265275988, ___myBigMail_4)); }
	inline GameObject_t1756533147 * get_myBigMail_4() const { return ___myBigMail_4; }
	inline GameObject_t1756533147 ** get_address_of_myBigMail_4() { return &___myBigMail_4; }
	inline void set_myBigMail_4(GameObject_t1756533147 * value)
	{
		___myBigMail_4 = value;
		Il2CppCodeGenWriteBarrier(&___myBigMail_4, value);
	}

	inline static int32_t get_offset_of_textDisplayPF_5() { return static_cast<int32_t>(offsetof(scrInLook_t3265275988, ___textDisplayPF_5)); }
	inline GameObject_t1756533147 * get_textDisplayPF_5() const { return ___textDisplayPF_5; }
	inline GameObject_t1756533147 ** get_address_of_textDisplayPF_5() { return &___textDisplayPF_5; }
	inline void set_textDisplayPF_5(GameObject_t1756533147 * value)
	{
		___textDisplayPF_5 = value;
		Il2CppCodeGenWriteBarrier(&___textDisplayPF_5, value);
	}

	inline static int32_t get_offset_of_myMailCount_6() { return static_cast<int32_t>(offsetof(scrInLook_t3265275988, ___myMailCount_6)); }
	inline Transform_t3275118058 * get_myMailCount_6() const { return ___myMailCount_6; }
	inline Transform_t3275118058 ** get_address_of_myMailCount_6() { return &___myMailCount_6; }
	inline void set_myMailCount_6(Transform_t3275118058 * value)
	{
		___myMailCount_6 = value;
		Il2CppCodeGenWriteBarrier(&___myMailCount_6, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
