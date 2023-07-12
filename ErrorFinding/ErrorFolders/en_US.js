module.exports = {
  Unauthorized_User_Access:
    "User does not have permission to access this application!",
  Api_UnhandledException:
    "Uncaught exception! See inner errors for details, if any.",
  Api_InputModelValidation:
    "Error validating input model! See inner errors for details, if any.",
  Api_CommonApi_Upload_EmptyStream: "Upload stream is empty!",
  Api_CommonApi_Upload_EmptyFile: "Upload file is empty!",
  Api_RestCallsPrevented: "Calls to end-points are prevented!",
  Api_SwaggerAccessForbidden: "Swagger access is forbidden!",
  Api_HangfireAccessForbidden: "Hangfire access is forbidden!",
  Api_UnsupportedApiVersion: "Requested API version is not supported",
  Core_Authentication_TokenExpired: "Provided authentication token is expired!",
  Core_Authentication_CorruptedSignKey:
    "Provided token encryption key differs from server encryption key!",
  Core_Authentication_RefreshNotAllowed:
    "Authentication token refresh is not allowed!",
  Core_CoreExtensions_Aws_GeneralAwsError:
    "An AWS error occurred! See inner errors for details, if any.",
  Core_Cancellation_OperationCancelled: "Operation is cancelled by caller!",
  Core_Cancellation_OperationTimeOut: "Operation is timed-out!",
  Core_Cron_InvalidValue: "Invalid Time Value!",
  Core_CoreExtensions_Storage_FtpStorage_UploadFail:
    "Upload operation is failed!",
  Core_CoreExtensions_Storage_FtpStorage_DownloadFail:
    "Download operation is failed!",
  Core_CoreExtensions_Storage_FtpStorage_MoveFail: "Move operation is failed!",
  Core_CoreExtensions_Storage_FtpStorage_FileNotExists: "File does not exist!",
  Core_EMail_CouldNotSend: "E-Mail could not be sent!",
  Core_Enumeration_NotSupported: "Enumeration value is not supported.",
  Core_Operation_ReflectingOperationDidNotReflect:
    "Reflecting operation must reflect a TReflecting to a TReflected!",
  Core_Operation_ResultReturningOperationDidNotReturnResult:
    "Result returning operation must return a TValue result!",
  Core_Operation_OperationOutputTypeDidNotSet:
    "An OperationOutputType must be set to the operation to determine IOperationOutput!",
  Core_Operation_NotFound: "Value not found.",
  Core_Result_CombinedError:
    "Multiple errors are occurred. See inner errors for details, if any.",
  Domain_Validation:
    "Error validating value! See inner errors for details, if any.",
  Domain_Purge: "Error purging entity! See inner errors for details, if any",
  Domain_Authentication:
    "Generic authentication error! See inner errors for details, if any.",
  Domain_CrowdFunding_Account_InsufficientLimit: "Insufficient account limit!",
  Domain_CrowdFunding_Account_ExceedsMaximumIncomeStatement:
    "Maximum income statement exceeding!",
  Domain_CrowdFunding_Account_NotOwnedInvestment:
    "Account does not hold ownership of the investment!",
  Domain_CrowdFunding_Account_NotCorporateIdentity:
    "You need to hold a 'Corporate Identity' to complete this action!",
  Domain_CrowdFunding_Account_CantStateSameQualification:
    "You can not state same qualification state!",
  Domain_CrowdFunding_Asset_RequiredQualifiedInvestorInvestmentNotMet:
    "Minimum required qualified investor investment amount is not ensured!",
  Domain_CrowdFunding_Asset_InvalidCommittedInvestmentData:
    "Data corruption on Committed investments!",
  Domain_CrowdFunding_Asset_NotFound: "Asset Not Found!",
  Domain_CrowdFunding_Asset_EquityRegistration_RegistrationNotCompleted:
    "Equity Registration not completed!",
  Domain_CrowdFunding_Bulletin_AlreadyRegistered:
    "E-Mail address is already in bullet-in lists!",
  Domain_CrowdFunding_Bulletin_NotFound:
    "E-Mail address is not found in bullet-in lists!",
  Domain_CrowdFunding_Common_InvalidAnnouncementUrl:
    "Paya Dayalı Kitle Fonlaması Tebliği linki bulunamadı. Lütfen sistem yöneticinize başvurunuz.",
  Domain_CrowdFunding_Investment_StatusViolation:
    "Investment is in a different state!",
  Domain_CrowdFunding_Investment_RefundValidUntilDateIsInPast:
    "Refund valid date is in past!",
  Domain_CrowdFunding_Investment_RefundValidUntilDateIsNotSet:
    "Refund valid date is not set!",
  Domain_CrowdFunding_Investment_NotFound: "Investment not found!",
  Domain_CrowdFunding_Investment_PaymentMethodViolation:
    "Payment method is incorrect!",
  Domain_CrowdFunding_Investment_CanNotRefundFinishedProject:
    "Related project is finished!",
  Domain_CrowdFunding_Investment_RefundWindowClosed:
    "Refund windows is closed!",
  Domain_CrowdFunding_Investment_RefundAlreadyRequested:
    "Refund is already requested!",
  Domain_CrowdFunding_Investment_CanNotApproveCancelOrRefundRequested:
    "Operation not permitted. A cancellation or a refund is already requested!",
  Domain_CrowdFunding_Investment_CanNotModifyTransferDate:
    "Transfer date can not be modified!",
  Domain_CrowdFunding_Investment_InvalidTransferDate:
    "Transfer date is not valid!",
  Domain_CrowdFunding_Investment_AlreadyHasCardPaymentErrorJobInfo:
    "Already has credit card payment error check scheduled job info record!",
  Domain_CrowdFunding_Project_EarlyStopFundingDateIsEmpty:
    "Early Stop Funding Datetime is empty!",
  Domain_CrowdFunding_Project_EarlyStopFundingDateIsGreaterThanFinishDate:
    "Early Stop Funding Datetime can not be greater than Project Finish Datetime!",
  Domain_CrowdFunding_Project_FinishDateIsEmpty:
    "Funding Finish Datetime can not be empty!",
  Domain_CrowdFunding_Project_InsufficientLimit: "Insufficient project limit!",
  Domain_CrowdFunding_Project_NotOpened: "Project is not opened yet!",
  Domain_CrowdFunding_Project_AlreadySuccess:
    "Project has already successfully collected target funding!",
  Domain_CrowdFunding_Project_AlreadyUnderExamination:
    "Project is already under examination!",
  Domain_CrowdFunding_Project_AlreadyFinished:
    "Project is already under examination!",
  Domain_CrowdFunding_Project_OwnerExistingFunding:
    "Project owner already has another fund collecting active project!",
  Domain_CrowdFunding_Project_OwnerExistingEvaluation:
    "Project owner already has another under examination project!",
  Domain_CrowdFunding_Project_NotOngoing: "Project is not ongoing!",
  Domain_CrowdFunding_Project_FundingNotStarted:
    "Project is not started to collect funds!",
  Domain_CrowdFunding_Project_FundingWindowExceeds:
    "Project funding window exceeds legal limits!",
  Domain_CrowdFunding_Project_FundingExceedsEntrepreneurLimit:
    "Project funding exceeds leader entrepreneur's legal limits!",
  Domain_CrowdFunding_Project_NotFullyRefundedYet:
    "Project not fully refunded yet!",
  Domain_CrowdFunding_Project_FaqNotFoundToDelete:
    "Project FAQ record not found to be deleted!",
  Domain_CrowdFunding_Project_FaqNotFoundToUpdate:
    "Project FAQ record not found to be updated!",
  Domain_CrowdFunding_Project_DocumentNotFoundToDelete:
    "The project document you wish to delete was not found.",
  Domain_CrowdFunding_Project_DocumentNotFoundToUpdate:
    "The project document you wish to edit was not found.",
  Domain_CrowdFunding_Project_CannotModifyTaC:
    "Can not modify 'Terms and Conditions' of a non-draft or not 'Editable rejected' project!",
  Domain_CrowdFunding_Project_CannotModifyStaticDocuments:
    "Can not modify 'Static documents' of a non-draft or not 'Editable rejected' project!",
  Domain_CrowdFunding_Project_CannotCompleteNonDraft:
    "Can not complete the creation of a non-draft or not 'Editable rejected' project!",
  Domain_CrowdFunding_Project_TaCAcceptedVersionIsNotValid:
    "Project's accepted terms and conditions are not up to date anymore!",
  Domain_CrowdFunding_Project_WizardNotComplete:
    "Project creation wizard is not completed!",
  Domain_CrowdFunding_Project_NotEditableAfterRejectionForDraftChange:
    "Project is not rejected with editable flag!",
  Domain_CrowdFunding_Project_StatusNotDraft: "Project status is not 'Draft'!",
  Domain_CrowdFunding_Project_NotRejectedForDraftChange:
    "Non-draft projects are not available for modification.!",
  Domain_CrowdFunding_Project_SignedAgreementMissingOnApproval:
    "Project signed publishing agreement is missing!",
  Domain_CrowdFunding_Project_InfoDocumentMissingOnApproval:
    "Project signed info document is missing!",
  Domain_CrowdFunding_Project_CannotOperateNoRelatedAsset:
    "Project related asset is not attached!",
  Domain_CrowdFunding_Project_FileAlreadyAttached:
    "Project file is already attached!",
  Domain_CrowdFunding_Project_UnprocessedInvestmentExistsOnProjectCompletion:
    "Can not complete project. Has unprocessed investments!",
  Domain_CrowdFunding_Project_NotFound: "Project not found!",
  Domain_CrowdFunding_Project_StatusNotCreated:
    "Project status is not 'Created' yet!",
  Domain_CrowdFunding_Project_AlreadyEvaluated:
    "Project is already evaluated and active state!",
  Domain_CrowdFunding_Project_AlreadyApplied:
    "Project is already applied to be evaluated!",
  Domain_CrowdFunding_Project_AlreadyApproved:
    "Project is already approved to be published!",
  Domain_CrowdFunding_Project_AlreadyFailed: "Project is already failed!",
  Domain_CrowdFunding_Project_AlreadyFunding:
    "Project is already collecting funding!",
  Domain_CrowdFunding_Project_Comment_ParentNotFound:
    "Parent comment not found!",
  Domain_CrowdFunding_Project_Comment_CannotCommentNonRoot:
    "Can not comment a non root comment!",
  Domain_CrowdFunding_Request_DifferentClaimer:
    "Request is claimed by another manager privileged user!",
  Domain_CrowdFunding_Project_Category_NotFound:
    "Project category is not found!",
  Domain_CrowdFunding_Project_Category_AlreadyExists:
    "Project category is already exists!",
  Domain_CrowdFunding_Project_Category_CannotModifyPredefined:
    "Can not modify predefined project category record!",
  Domain_CrowdFunding_Project_Category_CannotModifyAlreadyAttached:
    "Can not modify an in-use project category record!",
  Domain_CrowdFunding_Project_StatusViolation:
    "Operation not allowed due to status!",
  Domain_CrowdFunding_Project_CorporateInfoNotFound:
    "Corporate info not found!",
  Domain_CrowdFunding_Project_NotFinished: "Project is not finished!",
  Domain_CrowdFunding_Project_InvalidDefaultInvestmentCoefficientValues:
    "Default investment coefficient values are invalid!",
  Domain_CrowdFunding_Project_EquityDistribution_InconsistentDistribution:
    "There are some inconsistencies in distribution!",
  Domain_CrowdFunding_Project_EquityDistribution_InvalidEquityDistributionType:
    "Current distribution type is invalid for requested operation!",
  Domain_Crowdfunding_Project_InvestmentCommitteeReportDocumentMissingOnApproval:
    "Project signed Investment Committee Report document is missing!",
  Domain_CrowdFunding_Request_ProjectCompletion_MissingDistributionDocument:
    "Distribution document is missing!",
  Domain_CrowdFunding_Request_UnresolvedSameTypeExists:
    "Same request type is already exists with an Unresolved state!",
  Domain_CrowdFunding_Request_UnclaimedCanNotBeResolved:
    "Can not resolve when request is not in claimed state!",
  Domain_CrowdFunding_Request_NotPendingCanNotBeClaimed:
    "Can not claim when request is not in pending state!",
  Domain_CrowdFunding_Request_NotProcessingCanNotBeReleased:
    "Can not release when request is not in processing state!",
  Domain_CrowdFunding_Request_CanNotApprove: "Request can not be approved!",
  Domain_CrowdFunding_Request_CanNotReject: "Request can not be rejected!",
  Domain_CrowdFunding_Request_NotFound: "Request not found!",
  Domain_CrowdFunding_Request_EmptyManagerMessage:
    "Manager message is mandatory!",
  Domain_CrowdFunding_PurchaseEvaluation_CommitJobRanFlagAlreadySet:
    "Commit Job Ran Flag is already set!",
  Domain_CrowdFunding_Request_NotAutoProcessable:
    "Request is not AutoProcessable",
  Domain_CrowdFunding_Request_CanNotFindEligibleOperation:
    "Request can not be processed. Can not find eligible operation!",
  Domain_CrowdFunding_StaticDocument_SubSystemNotActive:
    "Static document sub-system is not active",
  Domain_CrowdFunding_StaticDocument_TypeNotExists:
    "Static document type does not exist",
  Domain_CrowdFunding_StaticDocument_CannotModifyActive:
    "Can not modify an active static document!",
  Domain_CrowdFunding_StaticDocument_CannotModifyPublished:
    "Can not modify a published static document!",
  Domain_CrowdFunding_StaticDocument_CannotModifyAlreadyAttached:
    "Can not modify an already attached static document!",
  Domain_CrowdFunding_StaticDocument_CannotPublishAlreadyPublished:
    "Can not publish an already published static document!",
  Domain_CrowdFunding_StaticDocument_NotFound: "Static document not found!",
  Domain_CrowdFunding_Term_AcceptedVersionIsNotValid:
    "Accepted terms and conditions are not up to date anymore!",
  Domain_CrowdFunding_Term_NotFound: "Term/condition not found!",
  Domain_CrowdFunding_Term_NotAccepted:
    "Terms and conditions are not accepted!",
  Domain_CrowdFunding_Term_CannotModifyActive:
    "Can not modify an active term/condition!",
  Domain_CrowdFunding_Term_CannotModifyPublished:
    "Can not modify a published term/condition!",
  Domain_CrowdFunding_Term_CannotModifyAcceptedProjectTerm:
    "Can not modify an accepted project term/condition!",
  Domain_CrowdFunding_Term_CannotModifyAcceptedUserTerm:
    "Can not modify an accepted user term/condition!",
  Domain_CrowdFunding_Term_CannotModifyAcceptedInvestmentTerm:
    "Can not modify an accepted investment term/condition!",
  Domain_CrowdFunding_Term_CannotPublishAlreadyPublished:
    "Can not publish an already published term/condition!",
  Domain_CrowdFunding_Term_CannotRePublishPreviouslyPublished:
    "Can not republish an already published term/condition!",
  Domain_CrowdFunding_Term_UnknownType: "Unknown term type!",
  Domain_CrowdFunding_User_RegistrationNotVerified:
    "Please complete the activation process of your account by clicking the activation link sent to your e-mail!",
  Domain_CrowdFunding_User_ManagerNotFound: "Manager user not found!",
  Domain_CrowdFunding_User_CanNotFavorOwn:
    "Users cannot add their own projects to favorites!",
  Domain_CrowdFunding_User_NoAccountFound:
    "User does not have any investment account!",
  Domain_CrowdFunding_User_EMailNotVerified:
    "User e-mail address is not verified!",
  Domain_CrowdFunding_User_InvestmentOwnershipMismatch:
    "User does not hold the ownership of the investment!",
  Domain_CrowdFunding_User_TaCAlreadyAccepted:
    "Terms and conditions are already accepted!",
  Domain_CrowdFunding_User_RequiresAdministratorPrivileges:
    "Operation requires administrator privileges!",
  Domain_CrowdFunding_User_AlreadyExists:
    "A user with the same e-mail address or the username you have provided already exists!",
  Domain_CrowdFunding_User_CanNotMakeInvestmentToOwn:
    "/Project owners cannot invest on their own projects!",
  Domain_CrowdFunding_User_Identity_NotVerified: "Identity is not verified!",
  Domain_CrowdFunding_User_Identity_PendingIdentityMismatch:
    "Given identity mismatches pending identity!",
  Domain_CrowdFunding_User_Identity_CanNotSetEmpty:
    "Can not set empty identity!",
  Domain_CrowdFunding_User_Identity_AlreadyAssigned:
    "Identity is already assigned!",
  Domain_CrowdFunding_User_Identity_UnknownIdentity: "Unknown identity!",
  Domain_CrowdFunding_User_Identity_CannotRemoveActive:
    "Can not remove active identity!",
  Domain_CrowdFunding_User_Identity_AlreadyVerified:
    "Identity already verified!",
  Domain_CrowdFunding_User_Identity_AlreadyInUse: "Identity already in use!",
  Domain_CrowdFunding_User_Identity_VerificationPending:
    "Identity verification is in progress!",
  Domain_CrowdFunding_User_Identity_ForeignerIdentityAdditionalInfoIsMandatory:
    "Foreigner identity additional information, such as mother full name or father full name, is mandatory!",
  Domain_CrowdFunding_ValueObjectErrors_InvalidPrimaryWorkName:
    "Primary work name is invalid!",
  Domain_CrowdFunding_ValueObjectErrors_InvalidCoefficientValue:
    "Coefficient value is invalid!",
  Domain_RegistrationAuthorityDomain_DetailsAlreadyAttached:
    "Can not attach details. Already attached!",
  Domain_RegistrationAuthorityDomain_CanNotDestroyDetails:
    "Can not destroy details!",
  Domain_RegistrationAuthorityDomain_CanNotUpdateDetails:
    "Can not update details reference!",
  Domain_RegistrationAuthorityDomain_NotFound: "Details not found!",
  Domain_RegistrationAuthorityDomain_MkkDomain_EDevletTryCountExceeded:
    "E-Devlet try count exceeded.",
  Domain_RegistrationAuthorityDomain_MkkDomain_MemberAlreadySaved:
    "Member already saved.",
  Domain_RegistrationAuthorityDomain_MkkDomain_ProjectAlreadySaved:
    "Project already saved.",
  Domain_RegistrationAuthorityDomain_MkkDomain_LimitAlreadyDecreased:
    "Limit already decreased.",
  Domain_RegistrationAuthorityDomain_MkkDomain_LimitAlreadyIncreased:
    "Limit already increased.",
  Domain_SharedKernel_Address_InvalidAddressType: "Invalid address type value!",
  Domain_SharedKernel_Address_InvalidCountryValue: "Invalid country value!",
  Domain_SharedKernel_Address_InvalidStateOrProvinceValue:
    "Invalid state/province value!",
  Domain_SharedKernel_Address_InvalidCityValue: "Invalid city value!",
  Domain_SharedKernel_Address_InvalidAddressLineValue:
    "Invalid address line value!",
  Domain_SharedKernel_Address_GeoAddressNotFound: "Geo-address not found!",
  Domain_SharedKernel_Demographics_NonEmptyAddressCannotBeSetUnlessOverriden:
    "Non-empty address value with type can not be set unless it's overriden!",
  Domain_SharedKernel_EMailDefinition_NotFound: "E-Mail definition not found!",
  Domain_SharedKernel_EMailDefinition_GeneratingEventCanNotSendToTarget:
    "E-Mail generating event can not send to specified target group",
  Domain_SharedKernel_EMailTemplate_UnknownTemplateType:
    "Unknown eMail template type!",
  Domain_SharedKernel_GeoAddress: "Geo-address not found!",
  Domain_SharedKernel_CanNotRemoveMappedPropertyTemplate:
    "Can not remove mapped property template!",
  Domain_SharedKernel_CanNotModifyMappedPropertyTemplate:
    "Can not modify mapped property template!",
  Domain_SharedKernel_PropertyTemplateAlreadyExists:
    "Another property template with the name is already exists!",
  Domain_SharedKernel_Authenticate_WrongCredentials:
    "Please check the information you have provided!",
  Domain_SharedKernel_Authenticate_AuthInfoNotFound:
    "Authentication info not found!",
  Domain_SharedKernel_Authenticate_NotAuthenticated: "Not authenticated!",
  Domain_SharedKernel_Authenticate_ClaimNotFound: "Claim Not Found!",
  Domain_SharedKernel_Authenticate_InconsistentAuthInfo:
    "Inconsistent authentication info!",
  Domain_SharedKernel_DirectMessage_ThreadNotFound:
    "Direct message thread not found!",
  Domain_SharedKernel_DirectMessage_ThreadOrUserRequired:
    "Direct message thread or user required!",
  Domain_SharedKernel_DirectMessage_OnlyThreadOrUserAllowed:
    "Only thread or user allowed!",
  Domain_SharedKernel_DirectMessage_CannotSendSelf: "Cannot send itself!",
  Domain_SharedKernel_DirectMessage_CouldNotCreateThread:
    "Could not create thread!",
  Domain_SharedKernel_DirectMessage_CouldNotReceiveThread:
    "Could not receive thread!",
  Domain_SharedKernel_MailSender_TemplateNotFound: "E-Mail template not exist!",
  Domain_SharedKernel_Password_EmptyPassword: "Password is empty!",
  Domain_SharedKernel_Password_PolicyNotMet: "Password policy not met!",
  Domain_SharedKernel_Password_MustReset: "Must reset password!",
  Domain_SharedKernel_Password_Expired: "Password is expired!",
  Domain_SharedKernel_Password_OldPassword: "Cannot use old password!",
  Domain_SharedKernel_Password_InCorrectPassword: "Incorrect password!",
  Domain_SharedKernel_Staging_ValueNotExists: "Staging value does not exits!",
  Domain_SharedKernel_Ticket_NotFound: "Ticket not found!",
  Domain_SharedKernel_Ticket_Invalid: "The validity of the link has expired!",
  Domain_SharedKernel_User_NotFound: "User acoount was not found!",
  Domain_SharedKernel_User_AlreadyExists:
    "A user with the same e-mail address or the username you have provided already exists.",
  Domain_SharedKernel_User_AlreadyLoggedOut: "User already logged out!",
  Domain_SharedKernel_User_UserQueryFailed: "User query failed!",
  Domain_SharedKernel_User_UserHardDeletionForbidden:
    "User hard deletion is forbidden!",
  Domain_SharedKernel_User_NotActive: "User not active!",
  Domain_SharedKernel_ValueObject_ValueCannotBeNull:
    "Mandatory value(s) can not be null!",
  Domain_SharedKernel_ValueObject_CanNotSetEmptyValue:
    "Can not set empty value!",
  Domain_SharedKernel_ValueObject_InvalidEMailFormat:
    "Please enter a valid e-mail address!",
  Domain_SharedKernel_ValueObject_InvalidUserNameFormat:
    "Invalid Username format!",
  Domain_SharedKernel_ValueObject_InvalidNameValues: "Invalid name values!",
  Domain_SharedKernel_ValueObject_InvalidPercentValues:
    "Invalid percent values!",
  Domain_SharedKernel_VersionImplementor_CannotModifyActive:
    "Can not modify an active e-mail template version!",
  Domain_SharedKernel_VersionImplementor_CannotModifyPublished:
    "Can not modify a published e-mail template version!",
  Domain_SharedKernel_VersionImplementor_CannotPublishAlreadyPublished:
    "Can not publish an already published e-mail template version!",
  Domain_SharedKernel_VersionImplementor_CannotRePublishPreviouslyPublished:
    "Can not republish an already published e-mail template version!",
  Domain_SharedKernel_VersionImplementor_NotFound:
    "E--mail template Version not found!",
  Domain_TrustAuthorityDomain_DetailsAlreadyAttached:
    "Can not attach details. Already attached!",
  Domain_TrustAuthorityDomain_CanNotDestroyDetails: "Can not destroy details!",
  Domain_TrustAuthorityDomain_CanNotUpdateDetails:
    "Can not update details reference!",
  Domain_TrustAuthorityDomain_PaymentAlreadyOrdered: "Payment already ordered!",
  Domain_TrustAuthorityDomain_CancelAlreadyOrdered: "Cancel already ordered!",
  Domain_TrustAuthorityDomain_PaymentNotSatisfied: "Payment not satisfied!",
  Domain_TrustAuthorityDomain_InvalidPaymentStatus: "Invalid payment status!",
  Domain_TrustAuthorityDomain_UnsupportedPaymentType:
    "Unsupported payment type!",
  Domain_TrustAuthorityDomain_Inactive:
    "Trust authority integration is inactive!",
  InvestmentsNotProcessedYet: "All investments must be processed in Takasbank!",
  Integration_Error:
    "A general integration error occurred. See inner errors for details, if any.",
  Integration_EmptyResponsePayload:
    "Integration target returned an empty payload when expecting non-empty. See inner errors for details, if any.",
  Integration_Integrator_Exception:
    "An integration exception occurred! See inner errors for details, if any.",
  Integration_RegistrationAuthorityIntegration_MkkIntegration_Error:
    "A general MKK error occurred. See inner errors for details, if any.",
  Integration_TrustAuthorityIntegration_Takasbank_Error:
    "A general Takasbank error occurred. See inner errors for details, if any.",
  Orm_OrmExtensions_Spf_ExecutionError:
    'Error in "Sorting/Paging/Filtering" engine execution. See inner errors for details, if any.',
  Orm_OrmImplementor_CommitFailed:
    "Commit operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_LoadFailed:
    "Load operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_GetByFailed:
    "GetBy operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_IdTypeConversionFailed:
    "Entity Id type conversion failed. See inner errors for details, if any!",
  Orm_OrmImplementor_UniqueCodeTypeConversionFailed:
    "Unique code type conversion failed. See inner errors for details, if any!",
  Orm_OrmImplementor_TransactionNotAlive:
    "Operation failed. Transaction is not alive!",
  Orm_OrmImplementor_RollbackFailed:
    "Rollback operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_InsertFailed:
    "Insert operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_UpdateFailed:
    "Update operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_DeleteFailed:
    "Delete operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_GetFailed:
    "Get operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_SaveFailed:
    "Save operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_EvictFailed:
    "Evict operation failed. See inner errors for details, if any!",
  Orm_OrmImplementor_MergeFailed:
    "Merge operation failed. See inner errors for details, if any!",
};
