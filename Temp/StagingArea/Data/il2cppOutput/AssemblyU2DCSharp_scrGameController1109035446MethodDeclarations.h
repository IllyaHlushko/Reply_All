#pragma once

#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <stdint.h>
#include <assert.h>
#include <exception>

// scrGameController
struct scrGameController_t1109035446;
// System.Collections.Generic.List`1<FMail>
struct List_1_t2824200873;
// System.Collections.Generic.List`1<FAd>
struct List_1_t2207118801;
// System.String
struct String_t;
// System.String[]
struct StringU5BU5D_t1642385972;

#include "codegen/il2cpp-codegen.h"
#include "UnityEngine_UnityEngine_SceneManagement_Scene1684909666.h"
#include "UnityEngine_UnityEngine_SceneManagement_LoadSceneM2981886439.h"
#include "mscorlib_System_String2029220233.h"

// System.Void scrGameController::.ctor()
extern "C"  void scrGameController__ctor_m3302001971 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::Awake()
extern "C"  void scrGameController_Awake_m852981714 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::OnEnable()
extern "C"  void scrGameController_OnEnable_m2672812871 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::OnSceneLoaded(UnityEngine.SceneManagement.Scene,UnityEngine.SceneManagement.LoadSceneMode)
extern "C"  void scrGameController_OnSceneLoaded_m4223162250 (scrGameController_t1109035446 * __this, Scene_t1684909666  ___scene0, int32_t ___mode1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::Start()
extern "C"  void scrGameController_Start_m1414282407 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::Update()
extern "C"  void scrGameController_Update_m4195526592 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.List`1<FMail> scrGameController::LoadDayMails()
extern "C"  List_1_t2824200873 * scrGameController_LoadDayMails_m225232617 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Collections.Generic.List`1<FAd> scrGameController::LoadDayAds()
extern "C"  List_1_t2207118801 * scrGameController_LoadDayAds_m2706026633 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::Penalty(System.String,System.Single)
extern "C"  void scrGameController_Penalty_m2284127587 (scrGameController_t1109035446 * __this, String_t* ___reason0, float ___amount1, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::StartDay()
extern "C"  void scrGameController_StartDay_m679423603 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::GameOver(System.String)
extern "C"  void scrGameController_GameOver_m2420795725 (scrGameController_t1109035446 * __this, String_t* ___reasonL0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::LevelComplete()
extern "C"  void scrGameController_LevelComplete_m1120732520 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::ShowStats()
extern "C"  void scrGameController_ShowStats_m2508682141 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::OpenTextFile(System.String[])
extern "C"  void scrGameController_OpenTextFile_m4021760822 (scrGameController_t1109035446 * __this, StringU5BU5D_t1642385972* ___file0, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::TurnOff()
extern "C"  void scrGameController_TurnOff_m4058398721 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::SaveDaysWeb()
extern "C"  void scrGameController_SaveDaysWeb_m457078745 (scrGameController_t1109035446 * __this, const MethodInfo* method) IL2CPP_METHOD_ATTR;
// System.Void scrGameController::.cctor()
extern "C"  void scrGameController__cctor_m625475316 (Il2CppObject * __this /* static, unused */, const MethodInfo* method) IL2CPP_METHOD_ATTR;
