#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>

// System.String
struct String_t;
// UnityEngine.GameObject
struct GameObject_t1756533147;
// System.Collections.Generic.List`1<FMail>
struct List_1_t2824200873;
// System.Collections.Generic.List`1<FAd>
struct List_1_t2207118801;

#include "UnityEngine_UnityEngine_MonoBehaviour1158329972.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// scrGameController
struct  scrGameController_t1109035446  : public MonoBehaviour_t1158329972
{
public:
	// System.Single scrGameController::curentTime
	float ___curentTime_2;
	// System.Single scrGameController::currentMoney
	float ___currentMoney_3;
	// System.String scrGameController::reason
	String_t* ___reason_4;
	// System.Int32 scrGameController::day
	int32_t ___day_5;
	// UnityEngine.GameObject scrGameController::penaltyBarPF
	GameObject_t1756533147 * ___penaltyBarPF_6;
	// UnityEngine.GameObject scrGameController::textFilePF
	GameObject_t1756533147 * ___textFilePF_7;
	// System.Collections.Generic.List`1<FMail> scrGameController::myMails1
	List_1_t2824200873 * ___myMails1_8;
	// System.Collections.Generic.List`1<FMail> scrGameController::myMails2
	List_1_t2824200873 * ___myMails2_9;
	// System.Collections.Generic.List`1<FAd> scrGameController::myAds1
	List_1_t2207118801 * ___myAds1_10;
	// System.Collections.Generic.List`1<FAd> scrGameController::myAds2
	List_1_t2207118801 * ___myAds2_11;

public:
	inline static int32_t get_offset_of_curentTime_2() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___curentTime_2)); }
	inline float get_curentTime_2() const { return ___curentTime_2; }
	inline float* get_address_of_curentTime_2() { return &___curentTime_2; }
	inline void set_curentTime_2(float value)
	{
		___curentTime_2 = value;
	}

	inline static int32_t get_offset_of_currentMoney_3() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___currentMoney_3)); }
	inline float get_currentMoney_3() const { return ___currentMoney_3; }
	inline float* get_address_of_currentMoney_3() { return &___currentMoney_3; }
	inline void set_currentMoney_3(float value)
	{
		___currentMoney_3 = value;
	}

	inline static int32_t get_offset_of_reason_4() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___reason_4)); }
	inline String_t* get_reason_4() const { return ___reason_4; }
	inline String_t** get_address_of_reason_4() { return &___reason_4; }
	inline void set_reason_4(String_t* value)
	{
		___reason_4 = value;
		Il2CppCodeGenWriteBarrier(&___reason_4, value);
	}

	inline static int32_t get_offset_of_day_5() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___day_5)); }
	inline int32_t get_day_5() const { return ___day_5; }
	inline int32_t* get_address_of_day_5() { return &___day_5; }
	inline void set_day_5(int32_t value)
	{
		___day_5 = value;
	}

	inline static int32_t get_offset_of_penaltyBarPF_6() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___penaltyBarPF_6)); }
	inline GameObject_t1756533147 * get_penaltyBarPF_6() const { return ___penaltyBarPF_6; }
	inline GameObject_t1756533147 ** get_address_of_penaltyBarPF_6() { return &___penaltyBarPF_6; }
	inline void set_penaltyBarPF_6(GameObject_t1756533147 * value)
	{
		___penaltyBarPF_6 = value;
		Il2CppCodeGenWriteBarrier(&___penaltyBarPF_6, value);
	}

	inline static int32_t get_offset_of_textFilePF_7() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___textFilePF_7)); }
	inline GameObject_t1756533147 * get_textFilePF_7() const { return ___textFilePF_7; }
	inline GameObject_t1756533147 ** get_address_of_textFilePF_7() { return &___textFilePF_7; }
	inline void set_textFilePF_7(GameObject_t1756533147 * value)
	{
		___textFilePF_7 = value;
		Il2CppCodeGenWriteBarrier(&___textFilePF_7, value);
	}

	inline static int32_t get_offset_of_myMails1_8() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___myMails1_8)); }
	inline List_1_t2824200873 * get_myMails1_8() const { return ___myMails1_8; }
	inline List_1_t2824200873 ** get_address_of_myMails1_8() { return &___myMails1_8; }
	inline void set_myMails1_8(List_1_t2824200873 * value)
	{
		___myMails1_8 = value;
		Il2CppCodeGenWriteBarrier(&___myMails1_8, value);
	}

	inline static int32_t get_offset_of_myMails2_9() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___myMails2_9)); }
	inline List_1_t2824200873 * get_myMails2_9() const { return ___myMails2_9; }
	inline List_1_t2824200873 ** get_address_of_myMails2_9() { return &___myMails2_9; }
	inline void set_myMails2_9(List_1_t2824200873 * value)
	{
		___myMails2_9 = value;
		Il2CppCodeGenWriteBarrier(&___myMails2_9, value);
	}

	inline static int32_t get_offset_of_myAds1_10() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___myAds1_10)); }
	inline List_1_t2207118801 * get_myAds1_10() const { return ___myAds1_10; }
	inline List_1_t2207118801 ** get_address_of_myAds1_10() { return &___myAds1_10; }
	inline void set_myAds1_10(List_1_t2207118801 * value)
	{
		___myAds1_10 = value;
		Il2CppCodeGenWriteBarrier(&___myAds1_10, value);
	}

	inline static int32_t get_offset_of_myAds2_11() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446, ___myAds2_11)); }
	inline List_1_t2207118801 * get_myAds2_11() const { return ___myAds2_11; }
	inline List_1_t2207118801 ** get_address_of_myAds2_11() { return &___myAds2_11; }
	inline void set_myAds2_11(List_1_t2207118801 * value)
	{
		___myAds2_11 = value;
		Il2CppCodeGenWriteBarrier(&___myAds2_11, value);
	}
};

struct scrGameController_t1109035446_StaticFields
{
public:
	// System.Boolean scrGameController::created
	bool ___created_12;

public:
	inline static int32_t get_offset_of_created_12() { return static_cast<int32_t>(offsetof(scrGameController_t1109035446_StaticFields, ___created_12)); }
	inline bool get_created_12() const { return ___created_12; }
	inline bool* get_address_of_created_12() { return &___created_12; }
	inline void set_created_12(bool value)
	{
		___created_12 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
