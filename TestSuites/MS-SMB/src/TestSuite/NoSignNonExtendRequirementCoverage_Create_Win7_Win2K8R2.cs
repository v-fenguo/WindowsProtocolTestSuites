// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeneratedTests {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.SpecExplorer.Runtime.Testing;
    using Microsoft.Protocols.TestTools;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Spec Explorer", "3.2.2498.0")]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2 : PtfTestClassBase {
        
        public NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "10000000");
        }
        
        #region Expect Delegates
        public delegate void NonExtendedNegotiateResponseDelegate1(int messageId, bool isSignatureRequired, bool isSignatureEnabled, int dialectIndex, List<Microsoft.Protocol.TestSuites.Smb.Capabilities> serverCapabilities, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus);
        
        public delegate void NonExtendedSessionSetupResponseDelegate1(int messageId, int sessionId, int securitySignatureValue, bool isSigned, bool isGuestAccount, bool isRS2322Implemented, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus);
        
        public delegate void TreeConnectResponseDelegate1(int messageId, int sessionId, int treeId, bool isSecuritySignatureZero, Microsoft.Protocol.TestSuites.Smb.ShareType shareType, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus, bool isSigned, bool isInDfs, bool isSupportExtSignature);
        
        public delegate void ErrorResponseDelegate1(int messageId, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus);
        
        public delegate void NtTransactCreateResponseDelegate1(int messageId, int sessionId, int treeId, bool isSigned, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus);
        
        public delegate void SmbConnectionResponseDelegate1(Microsoft.Protocol.TestSuites.Smb.Platform clientPlatform, Microsoft.Protocol.TestSuites.Smb.Platform sutPlatform);
        
        public delegate void ServerSetupResponseDelegate1(int totalBytesWritten, bool isSupportInfoLevelPassthru, bool isSupportNtSmb, bool isRapServerActive, bool isSupportResumeKey, bool isSupportCopyChunk);
        #endregion
        
        #region Event Metadata
        static System.Reflection.EventInfo SmbConnectionResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "SmbConnectionResponse");
        
        static System.Reflection.EventInfo ServerSetupResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.IServerSetupAdapter), "ServerSetupResponse");
        
        static System.Reflection.EventInfo NonExtendedNegotiateResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "NonExtendedNegotiateResponse");
        
        static System.Reflection.EventInfo NonExtendedSessionSetupResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "NonExtendedSessionSetupResponse");
        
        static System.Reflection.EventInfo TreeConnectResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "TreeConnectResponse");
        
        static System.Reflection.EventInfo ErrorResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "ErrorResponse");
        
        static System.Reflection.EventInfo NtTransactCreateResponseInfo = TestManagerHelpers.GetEventInfo(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter), "NtTransactCreateResponse");
        #endregion
        
        #region Adapter Instances
        private Microsoft.Protocol.TestSuites.Smb.ISmbAdapter ISmbAdapterInstance;
        
        private Microsoft.Protocol.TestSuites.Smb.IServerSetupAdapter IServerSetupAdapterInstance;
        #endregion
        
        #region Class Initialization and Cleanup
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void ClassInitialize(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext context) {
            PtfTestClassBase.Initialize(context);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void ClassCleanup() {
            PtfTestClassBase.Cleanup();
        }
        #endregion
        
        #region Test Initialization and Cleanup
        protected override void TestInitialize() {
            this.InitializeTestManager();
            this.ISmbAdapterInstance = ((Microsoft.Protocol.TestSuites.Smb.ISmbAdapter)(this.Manager.GetAdapter(typeof(Microsoft.Protocol.TestSuites.Smb.ISmbAdapter))));
            this.IServerSetupAdapterInstance = ((Microsoft.Protocol.TestSuites.Smb.IServerSetupAdapter)(this.Manager.GetAdapter(typeof(Microsoft.Protocol.TestSuites.Smb.IServerSetupAdapter))));
            this.Manager.Subscribe(ServerSetupResponseInfo, this.IServerSetupAdapterInstance);
            this.Manager.Subscribe(ErrorResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(NonExtendedNegotiateResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(NonExtendedSessionSetupResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(NtTransactCreateResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(SmbConnectionResponseInfo, this.ISmbAdapterInstance);
            this.Manager.Subscribe(TreeConnectResponseInfo, this.ISmbAdapterInstance);
        }
        
        protected override void TestCleanup() {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute(), Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory("Win7_Win2K8R2")]
        public virtual void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0() {
            this.Manager.BeginTest("NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call SmbConnectionRequest()\'");
            this.ISmbAdapterInstance.SmbConnectionRequest();
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return SmbConnectionRequest\'");
            this.Manager.Comment("reaching state \'S2\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.SmbConnectionResponseInfo, null, new SmbConnectionResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0SmbConnectionResponseChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S3\'");
                this.Manager.Comment("executing step \'call ServerSetup(Ntfs,Disabled,True,True,False)\'");
                this.IServerSetupAdapterInstance.ServerSetup(((Microsoft.Protocol.TestSuites.Smb.FileSystemType)(0)), ((Microsoft.Protocol.TestSuites.Smb.SignState)(0)), true, true, false);
                this.Manager.Comment("reaching state \'S4\'");
                this.Manager.Comment("checking step \'return ServerSetup\'");
                this.Manager.Comment("reaching state \'S5\'");
                if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.ServerSetupResponseInfo, null, new ServerSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0ServerSetupResponseChecker))) != -1)) {
                    this.Manager.Comment("reaching state \'S6\'");
                    bool temp0;
                    this.Manager.Comment("executing step \'call CreatePipeAndMailslot({\"Pipe1\"},{\"Mailslot1\"},out _)\'");
                    this.IServerSetupAdapterInstance.CreatePipeAndMailslot(new List<string> { "Pipe1" }, new List<string> { "Mailslot1" }, out temp0);
                    this.Manager.Comment("reaching state \'S7\'");
                    this.Manager.Comment("checking step \'return CreatePipeAndMailslot/[out True]\'");
                    TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, temp0, "createPipeStatus of CreatePipeAndMailslot, state S7");
                    this.Manager.Comment("reaching state \'S8\'");
                    this.Manager.Comment("executing step \'call NegotiateRequest(1,False,Disabled,[PcNet1,LanMan10,Wfw10,Lan" +
                            "Man12,LanMan21,NtLanMan])\'");
                    this.ISmbAdapterInstance.NegotiateRequest(1, false, ((Microsoft.Protocol.TestSuites.Smb.SignState)(0)), new List<Microsoft.Protocol.TestSuites.Smb.Dialect> { Microsoft.Protocol.TestSuites.Smb.Dialect.PcNet1, Microsoft.Protocol.TestSuites.Smb.Dialect.LanMan10, Microsoft.Protocol.TestSuites.Smb.Dialect.Wfw10, Microsoft.Protocol.TestSuites.Smb.Dialect.LanMan12, Microsoft.Protocol.TestSuites.Smb.Dialect.LanMan21, Microsoft.Protocol.TestSuites.Smb.Dialect.NtLanMan });
                    this.Manager.Comment("reaching state \'S9\'");
                    this.Manager.Comment("checking step \'return NegotiateRequest\'");
                    this.Manager.Comment("reaching state \'S10\'");
                    if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedNegotiateResponseInfo, null, new NonExtendedNegotiateResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedNegotiateResponseChecker))) != -1)) {
                        this.Manager.Comment("reaching state \'S11\'");
                        this.Manager.Comment("executing step \'call NonExtendedSessionSetupRequest(Admin,2,0,0,False,{CapNtSmbs}" +
                                ",False,False,True)\'");
                        this.ISmbAdapterInstance.NonExtendedSessionSetupRequest(((Microsoft.Protocol.TestSuites.Smb.AccountType)(0)), 2, 0, 0, false, new List<Microsoft.Protocol.TestSuites.Smb.Capabilities> { Microsoft.Protocol.TestSuites.Smb.Capabilities.CapNtSmbs }, false, false, true);
                        this.Manager.Checkpoint("MS-SMB_R8385");
                        this.Manager.Comment("reaching state \'S12\'");
                        this.Manager.Comment("checking step \'return NonExtendedSessionSetupRequest\'");
                        this.Manager.Comment("reaching state \'S13\'");
                        int temp2 = this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedSessionSetupResponseInfo, null, new NonExtendedSessionSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker)), new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedSessionSetupResponseInfo, null, new NonExtendedSessionSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker1)), new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedSessionSetupResponseInfo, null, new NonExtendedSessionSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker2)), new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedSessionSetupResponseInfo, null, new NonExtendedSessionSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker3)));
                        if ((temp2 == 0)) {
                            NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S14();
                            goto label1;
                        }
                        if ((temp2 == 1)) {
                            NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S14();
                            goto label1;
                        }
                        if ((temp2 == 2)) {
                            NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S14();
                            goto label1;
                        }
                        if ((temp2 == 3)) {
                            NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S14();
                            goto label1;
                        }
                        this.Manager.CheckObservationTimeout(false, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedSessionSetupResponseInfo, null, new NonExtendedSessionSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker)), new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedSessionSetupResponseInfo, null, new NonExtendedSessionSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker1)), new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedSessionSetupResponseInfo, null, new NonExtendedSessionSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker2)), new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedSessionSetupResponseInfo, null, new NonExtendedSessionSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker3)));
                    label1:
;
                    }
                    else {
                        this.Manager.CheckObservationTimeout(false, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NonExtendedNegotiateResponseInfo, null, new NonExtendedNegotiateResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedNegotiateResponseChecker)));
                    }
                }
                else {
                    this.Manager.CheckObservationTimeout(false, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.ServerSetupResponseInfo, null, new ServerSetupResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0ServerSetupResponseChecker)));
                }
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.SmbConnectionResponseInfo, null, new SmbConnectionResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0SmbConnectionResponseChecker)));
            }
            this.Manager.EndTest();
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0SmbConnectionResponseChecker(Microsoft.Protocol.TestSuites.Smb.Platform clientPlatform, Microsoft.Protocol.TestSuites.Smb.Platform sutPlatform) {
            this.Manager.Comment("checking step \'event SmbConnectionResponse(Win7,Win2K8R2)\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.Platform>(this.Manager, Microsoft.Protocol.TestSuites.Smb.Platform.Win7, clientPlatform, "clientPlatform of SmbConnectionResponse, state S2");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.Platform>(this.Manager, Microsoft.Protocol.TestSuites.Smb.Platform.Win2K8R2, sutPlatform, "sutPlatform of SmbConnectionResponse, state S2");
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0ServerSetupResponseChecker(int totalBytesWritten, bool isSupportInfoLevelPassthru, bool isSupportNtSmb, bool isRapServerActive, bool isSupportResumeKey, bool isSupportCopyChunk) {
            this.Manager.Comment("checking step \'event ServerSetupResponse(1,True,True,True,True,True)\'");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, totalBytesWritten, "totalBytesWritten of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportInfoLevelPassthru, "isSupportInfoLevelPassthru of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportNtSmb, "isSupportNtSmb of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isRapServerActive, "isRapServerActive of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportResumeKey, "isSupportResumeKey of ServerSetupResponse, state S5");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportCopyChunk, "isSupportCopyChunk of ServerSetupResponse, state S5");
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedNegotiateResponseChecker(int messageId, bool isSignatureRequired, bool isSignatureEnabled, int dialectIndex, List<Microsoft.Protocol.TestSuites.Smb.Capabilities> serverCapabilities, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event NonExtendedNegotiateResponse(1,False,False,5,{CapNtSmbs,CapD" +
                    "fs,CapInfoLevelPassThru},Success)\'");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, messageId, "messageId of NonExtendedNegotiateResponse, state S10");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSignatureRequired, "isSignatureRequired of NonExtendedNegotiateResponse, state S10");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSignatureEnabled, "isSignatureEnabled of NonExtendedNegotiateResponse, state S10");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 5, dialectIndex, "dialectIndex of NonExtendedNegotiateResponse, state S10");
            TestManagerHelpers.AssertNotNull(this.Manager, serverCapabilities, "serverCapabilities of NonExtendedNegotiateResponse, state S10");
            CollectionAssert.AreEquivalent( new List<Microsoft.Protocol.TestSuites.Smb.Capabilities> { Microsoft.Protocol.TestSuites.Smb.Capabilities.CapNtSmbs, Microsoft.Protocol.TestSuites.Smb.Capabilities.CapDfs, Microsoft.Protocol.TestSuites.Smb.Capabilities.CapInfoLevelPassThru }, serverCapabilities,  "serverCapabilities of NonExtendedNegotiateResponse, state S10, field selection Re" +
                    "p");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of NonExtendedNegotiateResponse, state S10");
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker(int messageId, int sessionId, int securitySignatureValue, bool isSigned, bool isGuestAccount, bool isRS2322Implemented, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event NonExtendedSessionSetupResponse(2,1,0,False,True,True,Succes" +
                    "s)\'");
            try {
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 2, messageId, "messageId of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, sessionId, "sessionId of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 0, securitySignatureValue, "securitySignatureValue of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSigned, "isSigned of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isGuestAccount, "isGuestAccount of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isRS2322Implemented, "isRS2322Implemented of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of NonExtendedSessionSetupResponse, state S13");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-SMB_R2322, MS-SMB_R8380");
                throw;
            }
            this.Manager.Checkpoint("MS-SMB_R2322");
            this.Manager.Checkpoint("MS-SMB_R8380");
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S14() {
            this.Manager.Comment("reaching state \'S14\'");
            this.Manager.Comment("executing step \'call TreeConnectRequest(3,1,False,True,True,\"Share1\",Disk,False)\'" +
                    "");
            this.ISmbAdapterInstance.TreeConnectRequest(3, 1, false, true, true, "Share1", ((Microsoft.Protocol.TestSuites.Smb.ShareType)(0)), false);
            this.Manager.Comment("reaching state \'S15\'");
            this.Manager.Comment("checking step \'return TreeConnectRequest\'");
            this.Manager.Comment("reaching state \'S16\'");
            if ((this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.TreeConnectResponseInfo, null, new TreeConnectResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0TreeConnectResponseChecker))) != -1)) {
                this.Manager.Comment("reaching state \'S17\'");
                this.Manager.Comment("executing step \'call NtTransactCreateRequest(4,1,1,3,\"Dir2\",Disk,False)\'");
                this.ISmbAdapterInstance.NtTransactCreateRequest(4, 1, 1, 3, "Dir2", ((Microsoft.Protocol.TestSuites.Smb.ShareType)(0)), false);
                this.Manager.Comment("reaching state \'S18\'");
                this.Manager.Comment("checking step \'return NtTransactCreateRequest\'");
                this.Manager.Comment("reaching state \'S19\'");
                int temp1 = this.Manager.ExpectEvent(this.QuiescenceTimeout, true, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.ErrorResponseInfo, null, new ErrorResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0ErrorResponseChecker)), new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NtTransactCreateResponseInfo, null, new NtTransactCreateResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NtTransactCreateResponseChecker)));
                if ((temp1 == 0)) {
                    this.Manager.Comment("reaching state \'S21\'");
                    goto label0;
                }
                if ((temp1 == 1)) {
                    this.Manager.Comment("reaching state \'S20\'");
                    goto label0;
                }
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.ErrorResponseInfo, null, new ErrorResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0ErrorResponseChecker)), new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.NtTransactCreateResponseInfo, null, new NtTransactCreateResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NtTransactCreateResponseChecker)));
            label0:
;
            }
            else {
                this.Manager.CheckObservationTimeout(false, new ExpectedEvent(NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2.TreeConnectResponseInfo, null, new TreeConnectResponseDelegate1(this.NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0TreeConnectResponseChecker)));
            }
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0TreeConnectResponseChecker(int messageId, int sessionId, int treeId, bool isSecuritySignatureZero, Microsoft.Protocol.TestSuites.Smb.ShareType shareType, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus, bool isSigned, bool isInDfs, bool isSupportExtSignature) {
            this.Manager.Comment("checking step \'event TreeConnectResponse(3,1,1,True,Disk,Success,False,False,True" +
                    ")\'");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 3, messageId, "messageId of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, sessionId, "sessionId of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, treeId, "treeId of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSecuritySignatureZero, "isSecuritySignatureZero of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.ShareType>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.ShareType)(0)), shareType, "shareType of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSigned, "isSigned of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isInDfs, "isInDfs of TreeConnectResponse, state S16");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isSupportExtSignature, "isSupportExtSignature of TreeConnectResponse, state S16");
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0ErrorResponseChecker(int messageId, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event ErrorResponse(4,NetworkSessionExpired)\'");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 4, messageId, "messageId of ErrorResponse, state S19");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, Microsoft.Protocol.TestSuites.Smb.MessageStatus.NetworkSessionExpired, messageStatus, "messageStatus of ErrorResponse, state S19");
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NtTransactCreateResponseChecker(int messageId, int sessionId, int treeId, bool isSigned, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event NtTransactCreateResponse(4,1,1,False,Success)\'");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 4, messageId, "messageId of NtTransactCreateResponse, state S19");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, sessionId, "sessionId of NtTransactCreateResponse, state S19");
            TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, treeId, "treeId of NtTransactCreateResponse, state S19");
            TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSigned, "isSigned of NtTransactCreateResponse, state S19");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of NtTransactCreateResponse, state S19");
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker1(int messageId, int sessionId, int securitySignatureValue, bool isSigned, bool isGuestAccount, bool isRS2322Implemented, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event NonExtendedSessionSetupResponse(2,1,0,False,False,True,Succe" +
                    "ss)\'");
            try {
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 2, messageId, "messageId of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, sessionId, "sessionId of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 0, securitySignatureValue, "securitySignatureValue of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSigned, "isSigned of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isGuestAccount, "isGuestAccount of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isRS2322Implemented, "isRS2322Implemented of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of NonExtendedSessionSetupResponse, state S13");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-SMB_R2322, MS-SMB_R8380");
                throw;
            }
            this.Manager.Checkpoint("MS-SMB_R2322");
            this.Manager.Checkpoint("MS-SMB_R8380");
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker2(int messageId, int sessionId, int securitySignatureValue, bool isSigned, bool isGuestAccount, bool isRS2322Implemented, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event NonExtendedSessionSetupResponse(2,1,0,False,True,False,Succe" +
                    "ss)\'");
            try {
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 2, messageId, "messageId of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, sessionId, "sessionId of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 0, securitySignatureValue, "securitySignatureValue of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSigned, "isSigned of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, true, isGuestAccount, "isGuestAccount of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isRS2322Implemented, "isRS2322Implemented of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of NonExtendedSessionSetupResponse, state S13");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-SMB_R2322, MS-SMB_R8380");
                throw;
            }
            this.Manager.Checkpoint("MS-SMB_R2322");
            this.Manager.Checkpoint("MS-SMB_R8380");
        }
        
        private void NoSignNonExtendRequirementCoverage_Create_Win7_Win2K8R2S0NonExtendedSessionSetupResponseChecker3(int messageId, int sessionId, int securitySignatureValue, bool isSigned, bool isGuestAccount, bool isRS2322Implemented, Microsoft.Protocol.TestSuites.Smb.MessageStatus messageStatus) {
            this.Manager.Comment("checking step \'event NonExtendedSessionSetupResponse(2,1,0,False,False,False,Succ" +
                    "ess)\'");
            try {
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 2, messageId, "messageId of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 1, sessionId, "sessionId of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<int>(this.Manager, 0, securitySignatureValue, "securitySignatureValue of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isSigned, "isSigned of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isGuestAccount, "isGuestAccount of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<bool>(this.Manager, false, isRS2322Implemented, "isRS2322Implemented of NonExtendedSessionSetupResponse, state S13");
                TestManagerHelpers.AssertAreEqual<Microsoft.Protocol.TestSuites.Smb.MessageStatus>(this.Manager, ((Microsoft.Protocol.TestSuites.Smb.MessageStatus)(0)), messageStatus, "messageStatus of NonExtendedSessionSetupResponse, state S13");
            }
            catch (TransactionFailedException ) {
                this.Manager.Comment("This step would have covered MS-SMB_R2322, MS-SMB_R8380");
                throw;
            }
            this.Manager.Checkpoint("MS-SMB_R2322");
            this.Manager.Checkpoint("MS-SMB_R8380");
        }
        #endregion
    }
}
