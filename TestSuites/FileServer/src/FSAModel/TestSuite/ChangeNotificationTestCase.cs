// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18449
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Protocols.TestSuites.FileSharing.FSA.TestSuite {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Reflection;
    using Microsoft.Protocols.TestTools;
    
    
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class ChangeNotificationTestCase : PtfTestClassBase {
        
        public ChangeNotificationTestCase() {
            this.SetSwitch("ProceedControlTimeout", "100");
            this.SetSwitch("QuiescenceTimeout", "30000");
        }
        
        #region Adapter Instances
        private Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.IFSAAdapter IFSAAdapterInstance;
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
            this.IFSAAdapterInstance = ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.IFSAAdapter)(this.GetAdapter(typeof(Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.IFSAAdapter))));
        }
        
        protected override void TestCleanup() {
            base.TestCleanup();
            this.CleanupTestManager();
        }
        #endregion
        
        #region Test Starting in S0
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Model)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Fsa)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.ChangeNotification)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.NonSmb)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Positive)]
        public void ChangeNotificationTestCaseS0() {
            this.Manager.BeginTest("ChangeNotificationTestCaseS0");
            this.Manager.Comment("reaching state \'S0\'");
            this.Manager.Comment("executing step \'call FsaInitial()\'");
            this.IFSAAdapterInstance.FsaInitial();
            this.Manager.Comment("reaching state \'S1\'");
            this.Manager.Comment("checking step \'return FsaInitial\'");
            this.Manager.Comment("reaching state \'S4\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp0;
            this.Manager.Comment("executing step \'call CreateFile(NORMAL,DIRECTORY_FILE,INDEX_ALLOCATION,GENERIC_AL" +
                    "L,FILE_SHARE_WRITE,OPEN_IF,StreamIsFound,IsNotSymbolicLink,DirectoryFile,PathNam" +
                    "eValid)\'");
            temp0 = this.IFSAAdapterInstance.CreateFile(Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAttribute.NORMAL, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateOptions)(1)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamTypeNameToOpen)(0)), Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAccess.GENERIC_ALL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.ShareAccess.FILE_SHARE_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateDisposition.OPEN_IF, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamFoundType)(0)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.SymbolicLinkType)(1)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileType)(1)), Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileNameStatus.PathNameValid);
            this.Manager.Checkpoint("MS-FSA_R405");
            this.Manager.Checkpoint(@"[In Application Requests an Open of a File , Pseudocode for the operation is as follows:
                        Phase 6 -- Location of file:] Pseudocode for this search:For i = 1 to n-1:
                        If Open.GrantedAccess.FILE_TRAVERSE is not set and AccessCheck( SecurityContext, Link.File.SecurityDescriptor, FILE_TRAVERSE ) 
                        returns FALSE, the operation is not  failed with STATUS_ACCESS_DENIED in Windows.");
            this.Manager.Checkpoint("MS-FSA_R475");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return:CreateAction set to FILE_CREATED.");
            this.Manager.Checkpoint("MS-FSA_R474");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return :Status set to STATUS_SUCCESS.");
            this.Manager.Comment("reaching state \'S6\'");
            this.Manager.Comment("checking step \'return CreateFile/SUCCESS\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus)(0)), temp0, "return of CreateFile, state S6");
            this.Manager.Comment("reaching state \'S8\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp1;
            this.Manager.Comment("executing step \'call ChangeNotificationForDir(NotAllEntriesFitInOutputBufferSize)" +
                    "\'");
            temp1 = this.IFSAAdapterInstance.ChangeNotificationForDir(((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.ChangeNotifyEntryType)(1)));
            this.Manager.Checkpoint("MS-FSA_R1399");
            this.Manager.Checkpoint("[In Server Requests Change Notifications for a Directory]On completion, \r\n       " +
                    "             the object store MUST return:[Status,OutputBuffer,ByteCount].");
            this.Manager.Comment("reaching state \'S10\'");
            this.Manager.Comment("checking step \'return ChangeNotificationForDir/NOTIFY_ENUM_DIR\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus.NOTIFY_ENUM_DIR, temp1, "return of ChangeNotificationForDir, state S10");
            ChangeNotificationTestCaseS12();
            this.Manager.EndTest();
        }
        
        private void ChangeNotificationTestCaseS12() {
            this.Manager.Comment("reaching state \'S12\'");
        }
        #endregion
        
        #region Test Starting in S2
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Model)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Fsa)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.ChangeNotification)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.NonSmb)]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategory(Microsoft.Protocols.TestSuites.FileSharing.Common.Adapter.TestCategories.Positive)]
        public void ChangeNotificationTestCaseS2() {
            this.Manager.BeginTest("ChangeNotificationTestCaseS2");
            this.Manager.Comment("reaching state \'S2\'");
            this.Manager.Comment("executing step \'call FsaInitial()\'");
            this.IFSAAdapterInstance.FsaInitial();
            this.Manager.Comment("reaching state \'S3\'");
            this.Manager.Comment("checking step \'return FsaInitial\'");
            this.Manager.Comment("reaching state \'S5\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp2;
            this.Manager.Comment("executing step \'call CreateFile(NORMAL,DIRECTORY_FILE,INDEX_ALLOCATION,GENERIC_AL" +
                    "L,FILE_SHARE_WRITE,OPEN_IF,StreamIsFound,IsNotSymbolicLink,DirectoryFile,PathNam" +
                    "eValid)\'");
            temp2 = this.IFSAAdapterInstance.CreateFile(Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAttribute.NORMAL, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateOptions)(1)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamTypeNameToOpen)(0)), Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileAccess.GENERIC_ALL, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.ShareAccess.FILE_SHARE_WRITE, Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.CreateDisposition.OPEN_IF, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.StreamFoundType)(0)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.SymbolicLinkType)(1)), ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileType)(1)), Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.FileNameStatus.PathNameValid);
            this.Manager.Checkpoint("MS-FSA_R405");
            this.Manager.Checkpoint(@"[In Application Requests an Open of a File , Pseudocode for the operation is as follows:
                        Phase 6 -- Location of file:] Pseudocode for this search:For i = 1 to n-1:
                        If Open.GrantedAccess.FILE_TRAVERSE is not set and AccessCheck( SecurityContext, Link.File.SecurityDescriptor, FILE_TRAVERSE ) 
                        returns FALSE, the operation is not  failed with STATUS_ACCESS_DENIED in Windows.");
            this.Manager.Checkpoint("MS-FSA_R475");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return:CreateAction set to FILE_CREATED.");
            this.Manager.Checkpoint("MS-FSA_R474");
            this.Manager.Checkpoint("[In Creation of a New File,Pseudocode for the operation is as follows:]\r\n        " +
                    "        The object store MUST return :Status set to STATUS_SUCCESS.");
            this.Manager.Comment("reaching state \'S7\'");
            this.Manager.Comment("checking step \'return CreateFile/SUCCESS\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus)(0)), temp2, "return of CreateFile, state S7");
            this.Manager.Comment("reaching state \'S9\'");
            Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus temp3;
            this.Manager.Comment("executing step \'call ChangeNotificationForDir(AllEntriesFitInOutputBufferSize)\'");
            temp3 = this.IFSAAdapterInstance.ChangeNotificationForDir(((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.ChangeNotifyEntryType)(0)));
            this.Manager.Checkpoint("MS-FSA_R1399");
            this.Manager.Checkpoint("[In Server Requests Change Notifications for a Directory]On completion, \r\n       " +
                    "             the object store MUST return:[Status,OutputBuffer,ByteCount].");
            this.Manager.Comment("reaching state \'S11\'");
            this.Manager.Comment("checking step \'return ChangeNotificationForDir/SUCCESS\'");
            TestManagerHelpers.AssertAreEqual<Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus>(this.Manager, ((Microsoft.Protocols.TestSuites.FileSharing.FSA.Adapter.MessageStatus)(0)), temp3, "return of ChangeNotificationForDir, state S11");
            ChangeNotificationTestCaseS12();
            this.Manager.EndTest();
        }
        #endregion
    }
}
