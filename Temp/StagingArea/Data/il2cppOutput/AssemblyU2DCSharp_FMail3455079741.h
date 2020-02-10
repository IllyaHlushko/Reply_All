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
// System.String[]
struct StringU5BU5D_t1642385972;

#include "mscorlib_System_Object2689449295.h"

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// FMail
struct  FMail_t3455079741  : public Il2CppObject
{
public:
	// System.Single FMail::spawnDelay
	float ___spawnDelay_0;
	// System.String FMail::from
	String_t* ___from_1;
	// System.String FMail::subject
	String_t* ___subject_2;
	// System.String[] FMail::content
	StringU5BU5D_t1642385972* ___content_3;
	// System.Boolean FMail::needsFile
	bool ___needsFile_4;
	// System.Boolean FMail::hasFile
	bool ___hasFile_5;
	// System.Boolean FMail::virus
	bool ___virus_6;
	// System.String[] FMail::myFile
	StringU5BU5D_t1642385972* ___myFile_7;

public:
	inline static int32_t get_offset_of_spawnDelay_0() { return static_cast<int32_t>(offsetof(FMail_t3455079741, ___spawnDelay_0)); }
	inline float get_spawnDelay_0() const { return ___spawnDelay_0; }
	inline float* get_address_of_spawnDelay_0() { return &___spawnDelay_0; }
	inline void set_spawnDelay_0(float value)
	{
		___spawnDelay_0 = value;
	}

	inline static int32_t get_offset_of_from_1() { return static_cast<int32_t>(offsetof(FMail_t3455079741, ___from_1)); }
	inline String_t* get_from_1() const { return ___from_1; }
	inline String_t** get_address_of_from_1() { return &___from_1; }
	inline void set_from_1(String_t* value)
	{
		___from_1 = value;
		Il2CppCodeGenWriteBarrier(&___from_1, value);
	}

	inline static int32_t get_offset_of_subject_2() { return static_cast<int32_t>(offsetof(FMail_t3455079741, ___subject_2)); }
	inline String_t* get_subject_2() const { return ___subject_2; }
	inline String_t** get_address_of_subject_2() { return &___subject_2; }
	inline void set_subject_2(String_t* value)
	{
		___subject_2 = value;
		Il2CppCodeGenWriteBarrier(&___subject_2, value);
	}

	inline static int32_t get_offset_of_content_3() { return static_cast<int32_t>(offsetof(FMail_t3455079741, ___content_3)); }
	inline StringU5BU5D_t1642385972* get_content_3() const { return ___content_3; }
	inline StringU5BU5D_t1642385972** get_address_of_content_3() { return &___content_3; }
	inline void set_content_3(StringU5BU5D_t1642385972* value)
	{
		___content_3 = value;
		Il2CppCodeGenWriteBarrier(&___content_3, value);
	}

	inline static int32_t get_offset_of_needsFile_4() { return static_cast<int32_t>(offsetof(FMail_t3455079741, ___needsFile_4)); }
	inline bool get_needsFile_4() const { return ___needsFile_4; }
	inline bool* get_address_of_needsFile_4() { return &___needsFile_4; }
	inline void set_needsFile_4(bool value)
	{
		___needsFile_4 = value;
	}

	inline static int32_t get_offset_of_hasFile_5() { return static_cast<int32_t>(offsetof(FMail_t3455079741, ___hasFile_5)); }
	inline bool get_hasFile_5() const { return ___hasFile_5; }
	inline bool* get_address_of_hasFile_5() { return &___hasFile_5; }
	inline void set_hasFile_5(bool value)
	{
		___hasFile_5 = value;
	}

	inline static int32_t get_offset_of_virus_6() { return static_cast<int32_t>(offsetof(FMail_t3455079741, ___virus_6)); }
	inline bool get_virus_6() const { return ___virus_6; }
	inline bool* get_address_of_virus_6() { return &___virus_6; }
	inline void set_virus_6(bool value)
	{
		___virus_6 = value;
	}

	inline static int32_t get_offset_of_myFile_7() { return static_cast<int32_t>(offsetof(FMail_t3455079741, ___myFile_7)); }
	inline StringU5BU5D_t1642385972* get_myFile_7() const { return ___myFile_7; }
	inline StringU5BU5D_t1642385972** get_address_of_myFile_7() { return &___myFile_7; }
	inline void set_myFile_7(StringU5BU5D_t1642385972* value)
	{
		___myFile_7 = value;
		Il2CppCodeGenWriteBarrier(&___myFile_7, value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
