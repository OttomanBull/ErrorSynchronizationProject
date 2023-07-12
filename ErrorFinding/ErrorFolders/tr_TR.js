module.exports = {
  Unauthorized_User_Access:
    "Girilen kullanıcının bu uygulamaya erişim izni yoktur!",
  Api_UnhandledException:
    "Beklenmeyen bir hata oluştu. Hata detayları için dahili hatalara bakabilirsiniz!",
  Api_InputModelValidation:
    "Girilen veri modeli hatalı. Hatanın detayları için dahili hatalara bakabilirsiniz!",
  Api_CommonApi_Upload_EmptyStream: "Yüklemeye çalıştığınız veri akışı boş!",
  Api_CommonApi_Upload_EmptyFile: "Yüklemeye çalıştığınız dosya boş!",
  Api_RestCallsPrevented: "Tüm uç nokta çağrıları engellendi",
  Api_SwaggerAccessForbidden: "Swagger erişimi engellendi!",
  Api_HangfireAccessForbidden: "Hangfire erişimi engellendi!",
  Api_UnsupportedApiVersion: "API versiyonu desteklenmiyor!",
  Core_Authentication_TokenExpired:
    "Kimlik Doğrulama anahtarının süresi doldu!",
  Core_Authentication_CorruptedSignKey:
    "Şifreleme anahtarı, sunucu şifreleme anahtarı ile uyumsuz!",
  Core_Authentication_RefreshNotAllowed: "Refresh token yenilenemedi!",
  Core_CoreExtensions_Aws_GeneralAwsError:
    "AWS bağlantı hatası. Hatanın detayları için dahili hatalara bakabilirsiniz!",
  Core_Cancellation_OperationCancelled:
    "Operasyon isteği yapan tarafından iptal edildi!",
  Core_Cancellation_OperationTimeOut: "Operasyon zaman aşımına uğradı!",
  Core_Cron_InvalidValue: "Hatalı Zaman Değeri!",
  Core_CoreExtensions_Storage_FtpStorage_UploadFail:
    "Dosya yükleme işlemi başarısız!",
  Core_CoreExtensions_Storage_FtpStorage_DownloadFail:
    "Dosya indirme işlemi başarısız!",
  Core_CoreExtensions_Storage_FtpStorage_MoveFail:
    "Dosya taşıma işlemi başarısız!",
  Core_CoreExtensions_Storage_FtpStorage_FileNotExists: "Dosya bulunamadı!",
  Core_EMail_CouldNotSend: "E-posta gönderilemedi!",
  Core_Enumeration_NotSupported: "Sıra elemanı desteklenmiyor!",
  Core_Operation_ReflectingOperationDidNotReflect:
    "Dönüşüm yapması gereken işlem dönüştürme gerçekleştirmedi!",
  Core_Operation_ResultReturningOperationDidNotReturnResult:
    "Bu işlem bir veri döndürmek zorunda!",
  Core_Operation_OperationOutputTypeDidNotSet: "İşlem dönüş tipi belirlenmedi!",
  Core_Operation_NotFound: "Bulunamadı!",
  Core_Result_CombinedError:
    "Birden fazla hata oluştu. Hatanın detayları için dahili hatalara bakabilirsiniz!",
  Domain_Validation:
    "Doğrulama Hatası! Hatanın detayları için dahili hatalara bakabilirsiniz! ",
  Domain_Purge:
    "Silme hatası! Hatanın detayları için dahili hatalara bakabilirsiniz!",
  Domain_Authentication:
    "Kimlik doğrulama hatası! Hatanın detayları için dahili hatalara bakabilirsiniz!",
  Domain_CrowdFunding_Account_InsufficientLimit: "Hesap limiti yetersiz!",
  Domain_CrowdFunding_Account_ExceedsMaximumIncomeStatement:
    "Yapmak istediğiniz gelir beyan miktarı, toplam yatırım limitinizi aşıyor!",
  Domain_CrowdFunding_Account_NotOwnedInvestment:
    "Sahibi olunmayan yatırım üzerinde işlem yapılamaz!",
  Domain_CrowdFunding_Account_NotCorporateIdentity:
    "Bu işlemi yapabilmek için 'Kurumsal Kimlik' sahibi olmalısınız!",
  Domain_CrowdFunding_Account_CantStateSameQualification:
    "Aynı niteliklilik durumu için talepte bulunulamaz!",
  Domain_CrowdFunding_Asset_RequiredQualifiedInvestorInvestmentNotMet:
    "Yeterli nitelikli yatırımcı oranı sağlanamadı!",
  Domain_CrowdFunding_Asset_InvalidCommittedInvestmentData:
    "Onaylanmış Yatırımda veri bozulması mevcut!",
  Domain_CrowdFunding_Asset_NotFound: "Yatırım Bulunamadı!",
  Domain_CrowdFunding_Bulletin_AlreadyRegistered:
    "E-posta adresi, daha önceden bültene kayıtlı!",
  Domain_CrowdFunding_Asset_EquityRegistration_RegistrationNotCompleted:
    "Pay Kaydileştirme henüz tamamlanmadı!",
  Domain_CrowdFunding_Bulletin_NotFound:
    "E-posta adresi, bültene kayıtlı değil!",
  Domain_CrowdFunding_Common_InvalidAnnouncementUrl:
    "Announcement Url is invalid! Please contact customer support.",
  Domain_CrowdFunding_Investment_StatusViolation: "Yatırım Durumu uygun değil!",
  Domain_CrowdFunding_Investment_RefundValidUntilDateIsInPast:
    "Yatırımın iade talep etme süresi aşıldı. 2 gün içinde iade talebine bulunabilirsiniz!",
  Domain_CrowdFunding_Investment_RefundValidUntilDateIsNotSet:
    "Yatırımın iade talep etme süresi belirlenmedi!",
  Domain_CrowdFunding_Investment_NotFound: "Yatırım bulunamadı!",
  Domain_CrowdFunding_Investment_PaymentMethodViolation: "Ödeme metodu hatalı!",
  Domain_CrowdFunding_Investment_CanNotRefundFinishedProject:
    "Sonlanmış bir projeden, yatırım iade talebinde bulunamazsınız!",
  Domain_CrowdFunding_Investment_RefundWindowClosed:
    "Yatırım iade talebi yapabilmeniz için belirlenen süre (2 gün) doldu!",
  Domain_CrowdFunding_Investment_RefundAlreadyRequested:
    "Bu yatırımın iade talebi daha önceden yapıldı!",
  Domain_CrowdFunding_Investment_CanNotApproveCancelOrRefundRequested:
    "Bu yatırım için, İptal yada iade talebi daha önceden yapıldı!",
  Domain_CrowdFunding_Investment_CanNotModifyTransferDate:
    "Yatırımın transfer zamanı değiştirilemez!",
  Domain_CrowdFunding_Investment_InvalidTransferDate:
    "Yatırımın transfer tarihi geçersiz!",
  Domain_CrowdFunding_Investment_AlreadyHasCardPaymentErrorJobInfo:
    "Zamanlanmış kartlı işlem hatası kontrolü işi zaten mevcut!",
  Domain_CrowdFunding_Project_EarlyStopFundingDateIsEmpty:
    "Fonlama erken durdurma tarihi seçilmedi!",
  Domain_CrowdFunding_Project_EarlyStopFundingDateIsGreaterThanFinishDate:
    "Fonlama erken durdurma tarihi, proje bitiş tarihinden sonra olamaz!",
  Domain_CrowdFunding_Project_FinishDateIsEmpty:
    "Fonlama Bitiş Tarihi boş olamaz!",
  Domain_CrowdFunding_Project_InsufficientLimit:
    "Yapmak istediğiniz yatırım proje limitini aşıyor!",
  Domain_CrowdFunding_Project_NotOpened: "Proje fonlama aşamasında değil!",
  Domain_CrowdFunding_Project_AlreadySuccess:
    "Proje fon toplaması başarıyla sonuçlandı!!",
  Domain_CrowdFunding_Project_AlreadyUnderExamination:
    "Proje değerlendirme aşamasında!",
  Domain_CrowdFunding_Project_AlreadyFinished: "Proje sonlandı!",
  Domain_CrowdFunding_Project_OwnerExistingFunding:
    "Proje sahibinin aktif olan başka bir projesi mevcut!",
  Domain_CrowdFunding_Project_OwnerExistingEvaluation:
    "Proje sahibinin değerlendirmede olan başka bir projesi mevcut!",
  Domain_CrowdFunding_Project_NotOngoing: "Proje fonlama aşamasında değil!",
  Domain_CrowdFunding_Project_FundingNotStarted:
    "Proje fon toplamaya başlamadı!",
  Domain_CrowdFunding_Project_FundingWindowExceeds:
    "Proje fonlama süresi legal sınırları aşıyor!",
  Domain_CrowdFunding_Project_FundingExceedsEntrepreneurLimit:
    "Lider girişimci limiti yetersiz!",
  Domain_CrowdFunding_Project_NotFullyRefundedYet:
    "İşlem yapabilmek için, projeye ait tüm iadeleri tamamlanması gerekir!",
  Domain_CrowdFunding_Project_FaqNotFoundToDelete:
    "Silinmek istenen proje SSS dokümanı bulunamadı!",
  Domain_CrowdFunding_Project_FaqNotFoundToUpdate:
    "Düzenlenmek istenen proje SSS dokümanı bulunamadı!",
  Domain_CrowdFunding_Project_DocumentNotFoundToDelete:
    "Silinmek istenen proje dokümanı bulunamadı!",
  Domain_CrowdFunding_Project_DocumentNotFoundToUpdate:
    "Düzenlenmek istenen proje dokümanı bulunamadı!",
  Domain_CrowdFunding_Project_CannotModifyTaC:
    "Düzenlenebilir şekilde reddedilmiş yada taslak aşamasında olmayan projelerin 'şartlar ve koşulları' düzenlenemez!",
  Domain_CrowdFunding_Project_CannotModifyStaticDocuments:
    "Düzenlenebilir şekilde reddedilmiş yada taslak aşamasında olmayan projelerin, dokümanları düzenlenemez!",
  Domain_CrowdFunding_Project_CannotCompleteNonDraft:
    "Düzenlenebilir şekilde reddedilmiş yada taslak olmayan projeler oluşturulamaz!",
  Domain_CrowdFunding_Project_TaCAcceptedVersionIsNotValid:
    "Proje 'şartlar ve koşulları' güncel değil!",
  Domain_CrowdFunding_Project_WizardNotComplete:
    "Proje oluşturma aşamaları tamamlanmadı!",
  Domain_CrowdFunding_Project_NotEditableAfterRejectionForDraftChange:
    "Projenin taslak durumunda olması için, düzenlenebilir şekilde reddedilmesi gerekir!",
  Domain_CrowdFunding_Project_StatusNotDraft: "Proje taslak durumunda değil!",
  Domain_CrowdFunding_Project_NotRejectedForDraftChange:
    "Taslak durumunda olmayan projeler düzenlenemez!",
  Domain_CrowdFunding_Project_SignedAgreementMissingOnApproval:
    "Projenin onaylanmış yayın sözleşmesi eksik!",
  Domain_CrowdFunding_Project_InfoDocumentMissingOnApproval:
    "Projenin onaylanmış bilgi dökümanı eksik!",
  Domain_CrowdFunding_Project_CannotOperateNoRelatedAsset:
    "Projeye tanımlı varlık kaydı olmadan işlem yapılamaz!",
  Domain_CrowdFunding_Project_FileAlreadyAttached:
    "Proje dosyaları daha önceden eklenmiş!",
  Domain_CrowdFunding_Project_UnprocessedInvestmentExistsOnProjectCompletion:
    "Projenin sonuçlandırılabilmesi için, proje üzerindeki tüm yatırımların işlenmesi gerekir!",
  Domain_CrowdFunding_Project_NotFound: "Proje bulunamadı!",
  Domain_CrowdFunding_Project_StatusNotCreated:
    "Projenin değerlendirilebilmesi için, proje oluşturulmuş olmalı!",
  Domain_CrowdFunding_Project_AlreadyEvaluated:
    "Proje zaten değerlendirmeye alındı ve aktif durumda!",
  Domain_CrowdFunding_Project_AlreadyApplied:
    "Proje değerlendirilme başvurusu daha önceden yapıldı!",
  Domain_CrowdFunding_Project_AlreadyApproved:
    "Proje yayına çıkmak üzere onaylandı!",
  Domain_CrowdFunding_Project_AlreadyFailed: "Proje başarısız sonuçlandı!",
  Domain_CrowdFunding_Project_AlreadyFunding:
    "Proje fonlamaya açık durumdadır!",
  Domain_CrowdFunding_Project_Comment_ParentNotFound:
    "Yanıtlamak istediğiniz yorum bulunamadı!",
  Domain_CrowdFunding_Project_Comment_CannotCommentNonRoot:
    "Kök seviye olmayan yoruma alt yorum eklenemez!",
  Domain_CrowdFunding_Request_DifferentClaimer:
    "Talep başka bir yönetici tarafından üstlenildi!",
  Domain_CrowdFunding_Project_Category_NotFound: "Proje kategorisi bulunamadı!",
  Domain_CrowdFunding_Project_Category_AlreadyExists:
    "Proje kategorisi daha önceden eklenmiş!",
  Domain_CrowdFunding_Project_Category_CannotModifyPredefined:
    "Önceden tanımlanmış proje kategorisi düzenlenemez!",
  Domain_CrowdFunding_Project_Category_CannotModifyAlreadyAttached:
    "Kullanımda olan bir proje kateorisi düzenlenemez!",
  Domain_CrowdFunding_Project_StatusViolation:
    "Proje statüsünden dolayı operasyon yapılamaz!",
  Domain_CrowdFunding_Project_CorporateInfoNotFound:
    "Kurumsal Kimlik bulunamadı!",
  Domain_CrowdFunding_Project_NotFinished: "Proje henüz bitmedi!",
  Domain_CrowdFunding_Project_InvalidDefaultInvestmentCoefficientValues:
    "Varsayılan proje katsayılar hatalı!",
  Domain_CrowdFunding_Project_EquityDistribution_InconsistentDistribution:
    "Manuel dağıtım dosyasında tutarsızlıklar mevcut!",
  Domain_CrowdFunding_Project_EquityDistribution_InvalidEquityDistributionType:
    "Hatalı hisse dağıtım yöntemi!",
  Domain_Crowdfunding_Project_InvestmentCommitteeReportDocumentMissingOnApproval:
    "Yatırım komitesi raporu bulunmadı!",
  Domain_CrowdFunding_Request_ProjectCompletion_MissingDistributionDocument:
    "Manuel dağıtım dosyası bulunamadı!",
  Domain_CrowdFunding_Request_UnresolvedSameTypeExists:
    "Aynı türde çözülmemiş başka talep mevcut!",
  Domain_CrowdFunding_Request_UnclaimedCanNotBeResolved:
    "Üstlenilmemiş talep çözümlenemez!",
  Domain_CrowdFunding_Request_NotPendingCanNotBeClaimed:
    "Bekleme durumunda olmayan talep üstlenilemez!",
  Domain_CrowdFunding_Request_NotProcessingCanNotBeReleased:
    "İşleme durumunda olmayan talep, serbest bırakılamaz",
  Domain_CrowdFunding_Request_CanNotApprove: "Talep kabul edilemez!",
  Domain_CrowdFunding_Request_CanNotReject: "Talep reddedilemez!",
  Domain_CrowdFunding_Request_NotFound: "Talep bulunamadı!",
  Domain_CrowdFunding_Request_EmptyManagerMessage:
    "Mesaj alanı boş bırakılamaz!",
  Domain_CrowdFunding_PurchaseEvaluation_CommitJobRanFlagAlreadySet:
    "Yatırım zaten onaylanmış!",
  Domain_CrowdFunding_Request_NotAutoProcessable:
    "Talep Otomatik işlenebilir bir talep değil!",
  Domain_CrowdFunding_Request_CanNotFindEligibleOperation:
    "Talep işlenemiyor. Talebe uygun operasyon bulunamadı!",
  Domain_CrowdFunding_StaticDocument_SubSystemNotActive:
    "Statik doküman sistemi aktif değil!",
  Domain_CrowdFunding_StaticDocument_TypeNotExists:
    "Bu statik doküman tipi mevcut değil!",
  Domain_CrowdFunding_StaticDocument_CannotModifyActive:
    "Aktif bir statik doküman üzerinde düzenleme yapılamaz!",
  Domain_CrowdFunding_StaticDocument_CannotModifyPublished:
    "Yayında olan bir statik doküman üzerinde düzenleme yapılamaz!",
  Domain_CrowdFunding_StaticDocument_CannotModifyAlreadyAttached:
    "Daha önceden eklenmiş statik doküman üzerinde düzenleme yapılamaz!",
  Domain_CrowdFunding_StaticDocument_CannotPublishAlreadyPublished:
    "Yayında olan bir statik doküman, tekrar yayınlanamaz!",
  Domain_CrowdFunding_StaticDocument_NotFound: "Statik doküman bulunamadı!",
  Domain_CrowdFunding_Term_AcceptedVersionIsNotValid:
    "Kabul edilmiş şartlar ve koşullar güncel değil!",
  Domain_CrowdFunding_Term_NotFound: "Şartlar ve koşullar güncel değil!",
  Domain_CrowdFunding_Term_NotAccepted: "Şartlar ve koşullar kabul edilmedi!",
  Domain_CrowdFunding_Term_CannotModifyActive:
    "Aktif şartlar ve koşullar üzerinde düzenleme yapılamaz!",
  Domain_CrowdFunding_Term_CannotModifyPublished:
    "Yayında olan şartlar ve koşullar üzerinde düzenleme yapılamaz!",
  Domain_CrowdFunding_Term_CannotModifyAcceptedProjectTerm:
    "Kabul edilmiş proje şartları ve koşulları üzerinde düzenleme yapılamaz!",
  Domain_CrowdFunding_Term_CannotModifyAcceptedUserTerm:
    "Kabul edilmiş kullanıcı şartları ve koşulları üzerinde düzenleme yapılamaz!",
  Domain_CrowdFunding_Term_CannotModifyAcceptedInvestmentTerm:
    "Kabul edilmiş yatırım şartları ve koşulları üzerinde düzenleme yapılamaz!",
  Domain_CrowdFunding_Term_CannotPublishAlreadyPublished:
    "Yayınlanmış şartlar ve koşullar tekrar yayınlanamaz",
  Domain_CrowdFunding_Term_CannotRePublishPreviouslyPublished:
    "Yayınlanmış şartlar ve koşullar tekrar yayınlanamaz",
  Domain_CrowdFunding_Term_UnknownType: "Şart/koşul tipi bilinmiyor!",
  Domain_CrowdFunding_User_RegistrationNotVerified:
    "Lütfen ilk önce e-posta adresinize gönderilen aktivasyon linkine tıklayarak hesabınızı aktive ediniz!",
  Domain_CrowdFunding_User_ManagerNotFound: "Yönetici bulunamadı!",
  Domain_CrowdFunding_User_CanNotFavorOwn:
    "Kendi projenizi favorilerinize ekleyemezsiniz!",
  Domain_CrowdFunding_User_NoAccountFound: "Kullanıcı bulunmadı!",
  Domain_CrowdFunding_User_EMailNotVerified: "E-Posta adresi doğrulanmadı.",
  Domain_CrowdFunding_User_InvestmentOwnershipMismatch:
    "Kullanıcı yatırımı bulunamadı!",
  Domain_CrowdFunding_User_TaCAlreadyAccepted:
    "Şartlar ve koşullar daha önceden kabul edildi!",
  Domain_CrowdFunding_User_RequiresAdministratorPrivileges:
    "Bu işlem için, yönetici yetkisi gerekmektedir!",
  Domain_CrowdFunding_User_AlreadyExists:
    "Girilen isim yada mail adresi daha önceden sistemde kayıtlı!",
  Domain_CrowdFunding_User_CanNotMakeInvestmentToOwn:
    "Proje sahibi olarak kendi projenize yatırım yapamazsınız!",
  Domain_CrowdFunding_User_Identity_NotVerified:
    "Kimlik bilgileriniz henüz doğrulanmadı!",
  Domain_CrowdFunding_User_Identity_PendingIdentityMismatch:
    "Kimlik tipi eşleşmedi!",
  Domain_CrowdFunding_User_Identity_CanNotSetEmpty:
    "Kimlik tipi boş olarak gönderilemez!!",
  Domain_CrowdFunding_User_Identity_AlreadyAssigned:
    "Kimlik tipi ataması daha önceden yapıldı!",
  Domain_CrowdFunding_User_Identity_UnknownIdentity:
    "Bilinmeyen kimlik bilgisi!",
  Domain_CrowdFunding_User_Identity_CannotRemoveActive:
    "Aktif kimlik bilgisi silinemez!",
  Domain_CrowdFunding_User_Identity_AlreadyVerified:
    "Kimlik bilgisi daha önceden onaylandı!",
  Domain_CrowdFunding_User_Identity_AlreadyInUse:
    "Kimlik daha önceden kayıt edilmiş!",
  Domain_CrowdFunding_User_Identity_VerificationPending:
    "Kimlik doğrulama süreci işleniyor!",
  Domain_CrowdFunding_User_Identity_ForeignerIdentityAdditionalInfoIsMandatory:
    'Yabancı kimlik tipi için, "Anne Tam Adı" ve "Baba Tam Adı" girilmesi zorunludur!',
  Domain_CrowdFunding_ValueObjectErrors_InvalidPrimaryWorkName:
    "Çalışma adı geçersiz!",
  Domain_CrowdFunding_ValueObjectErrors_InvalidCoefficientValue:
    "Katsayı değeri geçersiz!",
  Domain_RegistrationAuthorityDomain_DetailsAlreadyAttached:
    "Kullanıcı detayları daha önceden eklendi!",
  Domain_RegistrationAuthorityDomain_CanNotDestroyDetails:
    "Kullanıcı detayları silinemez!",
  Domain_RegistrationAuthorityDomain_CanNotUpdateDetails:
    "Kayıtlı kullanıcısının detayları güncellenemez!",
  Domain_RegistrationAuthorityDomain_NotFound:
    "Kullanıcı detayları bulunamadı!",
  Domain_RegistrationAuthorityDomain_MkkDomain_EDevletTryCountExceeded:
    "E-Devlet azami deneme sınırını aştınız!",
  Domain_RegistrationAuthorityDomain_MkkDomain_MemberAlreadySaved:
    "Kullanıcı daha önceden kayıt edilmiş!",
  Domain_RegistrationAuthorityDomain_MkkDomain_ProjectAlreadySaved:
    "Proje daha önceden kayıt edilmiş!",
  Domain_RegistrationAuthorityDomain_MkkDomain_LimitAlreadyDecreased:
    "Kullanıcı Limiti daha önceden düşürüldü!",
  Domain_RegistrationAuthorityDomain_MkkDomain_LimitAlreadyIncreased:
    "Kullanıcı Limiti daha önceden yükseltildi!",
  Domain_SharedKernel_Address_InvalidAddressType: "Hatalı adres tipi!",
  Domain_SharedKernel_Address_InvalidCountryValue: "Hatalı ülke kodu!",
  Domain_SharedKernel_Address_InvalidStateOrProvinceValue:
    "Hatalı eyalet/şehir kodu!",
  Domain_SharedKernel_Address_InvalidCityValue: "Hatalı şehir kodu!",
  Domain_SharedKernel_Address_InvalidAddressLineValue: "Hatalı adres satırı!",
  Domain_SharedKernel_Address_GeoAddressNotFound: "Coğrafi adres bulunamadı!",
  Domain_SharedKernel_Demographics_NonEmptyAddressCannotBeSetUnlessOverriden:
    "Adres bilgileri girilmiş ve değiştirilemez!",
  Domain_SharedKernel_EMailDefinition_NotFound: "E-posta tanımı bulunamadı!",
  Domain_SharedKernel_EMailDefinition_GeneratingEventCanNotSendToTarget:
    "E-posta belirtilen hedef grubuna gönderilemedi!",
  Domain_SharedKernel_EMailTemplate_UnknownTemplateType:
    "Bilinmeyen e-posta şablon türü!",
  Domain_SharedKernel_GeoAddress: "Coğrafi adres bulunamadı!",
  Domain_SharedKernel_CanNotRemoveMappedPropertyTemplate:
    "Eşlenmiş özellik tanımlaması kaldırılamaz!",
  Domain_SharedKernel_CanNotModifyMappedPropertyTemplate:
    "Eşlenmiş özellik tanımlaması değiştirilemez!",
  Domain_SharedKernel_PropertyTemplateAlreadyExists:
    "Özellik tanımlaması önceden tanımlanmış!",
  Domain_SharedKernel_Authenticate_WrongCredentials:
    "Yanlış kullanıcı adı ve/veya şifre girdiniz!",
  Domain_SharedKernel_Authenticate_AuthInfoNotFound:
    "Kullanıcı bilgileri bulunamadı!",
  Domain_SharedKernel_Authenticate_NotAuthenticated:
    "Kullanıcı kimliği doğrulanmadı!",
  Domain_SharedKernel_Authenticate_ClaimNotFound: "Değer bulunamadı",
  Domain_SharedKernel_Authenticate_InconsistentAuthInfo:
    "Giriş bilgileri hatalı!",
  Domain_SharedKernel_DirectMessage_ThreadNotFound: "Mesaj akışı bulunamadı!",
  Domain_SharedKernel_DirectMessage_ThreadOrUserRequired:
    "Mesajlaşma için, mesaj akışı yada kullanıcı gereklidir!",
  Domain_SharedKernel_DirectMessage_OnlyThreadOrUserAllowed:
    "Mesajlaşma için, sadece mesaj akışı yada kullanıcıya izin verilir!",
  Domain_SharedKernel_DirectMessage_CannotSendSelf:
    "Kendinize mesaj gönderemezsiniz!",
  Domain_SharedKernel_DirectMessage_CouldNotCreateThread:
    "Mesaj akışı oluşturulamadı!",
  Domain_SharedKernel_DirectMessage_CouldNotReceiveThread:
    "Mesaj akışı bulunamadı!",
  Domain_SharedKernel_MailSender_TemplateNotFound:
    "E-Posta şablonu bulunamadı!",
  Domain_SharedKernel_Password_EmptyPassword: "Şifre alanı boş olamaz!",
  Domain_SharedKernel_Password_PolicyNotMet:
    "Şifreniz kural setine uygun olmak zorunda!",
  Domain_SharedKernel_Password_MustReset: "Lütfen şifrenizi yenileyin!",
  Domain_SharedKernel_Password_Expired:
    "Şifrenin geçerlilik süresi dolmuştur. Lüften şifrenizi yenileyin!",
  Domain_SharedKernel_Password_OldPassword:
    "Yeni şifre, eski şifreyle aynı olamaz!",
  Domain_SharedKernel_Password_InCorrectPassword:
    "Eski şifrenizi hatalı girdiniz!",
  Domain_SharedKernel_Staging_ValueNotExists: "Değer bulunamadı!",
  Domain_SharedKernel_Ticket_NotFound: "Ticket bulunamadı!",
  Domain_SharedKernel_Ticket_Invalid: "Ticket Hatalı!",
  Domain_SharedKernel_User_NotFound: "Kullanıcı hesabı bulunamadı!",
  Domain_SharedKernel_User_AlreadyExists:
    "Bu kullanıcı adı yada e-postaya saihp bir kullanıcı daha önceden kayıt edildi!",
  Domain_SharedKernel_User_AlreadyLoggedOut:
    "Kullanıcı daha öncede çıkış yaptı!",
  Domain_SharedKernel_User_UserQueryFailed: "Kullanıcı sorgusu başarısız!",
  Domain_SharedKernel_User_UserHardDeletionForbidden:
    "Kalıcı kullanıcı silme işlemi yasaklandı!",
  Domain_SharedKernel_User_NotActive: "Kullanıcı aktif değil!",
  Domain_SharedKernel_ValueObject_ValueCannotBeNull:
    "Zorunlu alan(lar) boş olamaz!",
  Domain_SharedKernel_ValueObject_CanNotSetEmptyValue:
    "Boş değer gönderemezsiniz!",
  Domain_SharedKernel_ValueObject_InvalidEMailFormat:
    "Lütfen geçerli bir e-posta adresi giriniz!",
  Domain_SharedKernel_ValueObject_InvalidUserNameFormat:
    "Lütfen geçerli bir kullanıcı adı giriniz!",
  Domain_SharedKernel_ValueObject_InvalidNameValues:
    "Lütfen geçerli bir isim giriniz!",
  Domain_SharedKernel_ValueObject_InvalidPercentValues: "Hatalı yüzde değeri!",
  Domain_SharedKernel_VersionImplementor_CannotModifyActive:
    "Aktif olan e-posta tanımı değiştirilemez!",
  Domain_SharedKernel_VersionImplementor_CannotModifyPublished:
    "Yayında olan e-posta tanımı değiştirilemez!",
  Domain_SharedKernel_VersionImplementor_CannotPublishAlreadyPublished:
    "Yayında olan E-posta tanımını tekrar yayınlanamaz!",
  Domain_SharedKernel_VersionImplementor_CannotRePublishPreviouslyPublished:
    "Yayında olan E-posta tanımını tekrar yayınlanamaz!",
  Domain_SharedKernel_VersionImplementor_NotFound: "E-posta tanımı bulunamadı!",
  Domain_TrustAuthorityDomain_DetailsAlreadyAttached:
    "Ödeme detayları zaten eklenmiş!",
  Domain_TrustAuthorityDomain_CanNotDestroyDetails:
    "Ödeme detayları silinemez!",
  Domain_TrustAuthorityDomain_CanNotUpdateDetails:
    "Ödeme detayları güncellenemez!",
  Domain_TrustAuthorityDomain_PaymentAlreadyOrdered:
    "Ödeme talimatı daha önceden işleme alınmış!",
  Domain_TrustAuthorityDomain_CancelAlreadyOrdered:
    "Ödeme iptal talebi daha önceden işleme alınmış!",
  Domain_TrustAuthorityDomain_PaymentNotSatisfied: "Ödeme işlemi tamamlanamad!",
  Domain_TrustAuthorityDomain_InvalidPaymentStatus:
    "Ödeme işlemi başarıyla tamamlanamadı!",
  Domain_TrustAuthorityDomain_UnsupportedPaymentType:
    "Desteklenemeyen ödeme tipi!",
  Domain_TrustAuthorityDomain_Inactive:
    "Ödeme sağlayıcısı entegrasyonu aktif değil!",
  InvestmentsNotProcessedYet:
    "Tüm yatırımlar, Takasbank tarafında işlenmelidir!",
  Integration_Error:
    "Entegrasyon hatası! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Integration_EmptyResponsePayload:
    "Entegrasyon servislerinden gelen veri içeriği boş! Hata detayları için dahili hatalara bakabilirsiniz.",
  Integration_Integrator_Exception:
    "Entegrasyon servisi hatası! Hata detayları için dahili hatalara bakabilirsiniz.",
  Integration_RegistrationAuthorityIntegration_MkkIntegration_Error:
    "Kayıt kuruluşu entegrasyonu hatası Hata detayları için dahili hatalara bakabilirsiniz.",
  Integration_TrustAuthorityIntegration_Takasbank_Error:
    "Ödeme sağlayıcı entegrasyonu hatası! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmExtensions_Spf_ExecutionError:
    '"sıralama/sayfalama/filtreleme" hatası! Hatanın detayları için dahili hatalara bakabilirsiniz.',
  Orm_OrmImplementor_CommitFailed:
    "Commit işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_LoadFailed:
    "Yükleme işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_GetByFailed:
    'Çoklu "sıralama/sayfalama/filtreleme" işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.',
  Orm_OrmImplementor_IdTypeConversionFailed:
    "Id tipi dönüşüm işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_UniqueCodeTypeConversionFailed:
    "Unique kod tip dönüşüm işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_TransactionNotAlive:
    "Başarısız işlem. İşlem aktif değil! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_RollbackFailed:
    "Geri alma işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_InsertFailed:
    "Ekleme işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_UpdateFailed:
    "Güncelleme işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_DeleteFailed:
    "Silme işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_GetFailed:
    "Oturum işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_SaveFailed:
    "Kaydetme işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_EvictFailed:
    "Önbellek serbest bırakma işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
  Orm_OrmImplementor_MergeFailed:
    "Birleştirme işlemi başarısız! Hatanın detayları için dahili hatalara bakabilirsiniz.",
};
