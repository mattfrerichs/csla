﻿#if NETFX_CORE && !NETCORE
using System.Runtime.CompilerServices;


namespace Csla.Properties
{
  using System;
  using Csla.Reflection;


  /// <summary>
  ///   A strongly-typed resource class, for looking up localized strings, etc.
  /// </summary>
  // This class was auto-generated by the StronglyTypedResourceBuilder
  // class via a tool like ResGen or Visual Studio.
  // To add or remove a member, edit your .ResX file then rerun ResGen
  // with the /str option, or rebuild your VS project.
  [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public class Resources
  {

    //private static global::Windows.ApplicationModel.Resources.Core.ResourceManager resourceMan;

    [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
    internal Resources() { }

    private static string GetResourceString([CallerMemberName] string resourceName = null)
    {
#if PCL46 // rely on NuGet bait-and-switch for actual implementation
      return null;
#else
#pragma warning disable
      var loader = new Windows.ApplicationModel.Resources.ResourceLoader("Csla/Resources");
#pragma warning enable
      return loader.GetString(resourceName);
#endif
    }

    /// <summary>
    ///   Looks up a localized string similar to Are you sure you want to close?.
    /// </summary>
    public static string ActionExtenderCloseConfirmation
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Object is currently in a dirty changed..
    /// </summary>
    public static string ActionExtenderDirtyWarningMessagePropertyDefault
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to DataSource does not cast to a BindingSource.
    /// </summary>
    public static string ActionExtenderInvalidBindingSourceCast
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to The underlying data source does not cast to a CSLA BusinessBase object.
    /// </summary>
    public static string ActionExtenderInvalidBusinessObjectBaseCast
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to DataSource must be a BindingSource control instance.
    /// </summary>
    public static string ActionExtenderSourceMustBeBindingSource
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Are you sure you want to revert to the previous values?.
    /// </summary>
    public static string ActionExtenderWarnOnCancelMessagePropertyDefault
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to AddNewCore must be overridden.
    /// </summary>
    public static string AddNewCoreMustBeOverriden
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Csla Authentication Provider specified does not implement IAuthorizeDataPortal.
    /// </summary>
    public static string AuthenticationProviderDoesNotImplementIAuthorizeDataPortal
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Csla Authorization Provider App Setting name not specified.
    /// </summary>
    public static string AuthorizationProviderNameNotSpecified
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to A root binding source has not been provided..
    /// </summary>
    public static string BindingSourceNotProvided
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Principal must be of type BusinessPrincipal, not.
    /// </summary>
    public static string BusinessPrincipalException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Objects that are marked busy may not be marked busy again.
    /// </summary>
    public static string BusyObjectsMayNotBeMarkedBusy
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Objects that are marked busy may not be saved.
    /// </summary>
    public static string BusyObjectsMayNotBeSaved
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Cannot serialize collections not of type IMobileObject.
    /// </summary>
    public static string CannotSerializeCollectionsNotOfIMobileObject
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Changing an element is an invalid operation.
    /// </summary>
    public static string ChangeInvalidException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Can not change a read-only list or collection.
    /// </summary>
    public static string ChangeReadOnlyListInvalid
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Can not directly mark a child object for deletion - use its parent collection.
    /// </summary>
    public static string ChildDeleteException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Clear is an invalid operation.
    /// </summary>
    public static string ClearInvalidException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to The client query is invalid:.
    /// </summary>
    public static string ClientQueryIsInvalid
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Constructor with parameters are not supported.
    /// </summary>
    public static string ConstructorsWithParametersNotSupported
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Create method name not specified in MobileFactory attribute.
    /// </summary>
    public static string CreateMethodNameNotSpecified
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Invalid operation - create not allowed.
    /// </summary>
    public static string CreateNotSupportedException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Csla Authentication Provider not set!.
    /// </summary>
    public static string CslaAuthenticationProviderNotSet
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Database name not found in config file ({0}).
    /// </summary>
    public static string DatabaseNameNotFound
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Default Constructor.
    /// </summary>
    public static string DefaultConstructor
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Delete method name not specified in MobileFactory attribute.
    /// </summary>
    public static string DeleteMethodNameNotSpecified
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Invalid operation - delete not allowed.
    /// </summary>
    public static string DeleteNotSupportedException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Edit level mismatch in {0}.
    /// </summary>
    public static string EditLevelMismatchException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Error reading value:.
    /// </summary>
    public static string ErrorReadingValueException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to An exception ocurred during the save operation.
    /// </summary>
    public static string ExceptionOccurredDuringSaveOperation
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Method to be executed must have 0 or 2 parameters.
    /// </summary>
    public static string ExecuteBadParams
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Trigger event has an unsupported signature.
    /// </summary>
    public static string ExecuteBadTriggerEvent
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Invalid operation - execute not allowed.
    /// </summary>
    public static string ExecuteNotSupportedException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Factory type or assembly could not be loaded ({0}).
    /// </summary>
    public static string FactoryTypeNotFoundException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to failed.
    /// </summary>
    public static string Failed
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to failed on the server.
    /// </summary>
    public static string FailedOnServer
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Fetch method name not specified in MobileFactory attribute.
    /// </summary>
    public static string FetchMethodNameNotSpecified
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Invalid operation - fetch not allowed.
    /// </summary>
    public static string FetchNotSupportedException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Filter parameter and filter provider are required.
    /// </summary>
    public static string FilterRequiredException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Target object must implement IEditableCollection.
    /// </summary>
    public static string IEditableCollectionRequiredException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Target object must implement IManageProperties.
    /// </summary>
    public static string IManagePropertiesRequiredException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Indexed expressions must be closed.
    /// </summary>
    public static string IndexedExpressionsMustBeClosed
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Insert is an invalid operation.
    /// </summary>
    public static string InsertInvalidException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Invalid operation - insert not allowed.
    /// </summary>
    public static string InsertNotSupportedException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    /// Looks up a serialized string similar to Rule message is required
    /// </summary>
    public static string RuleMessageRequired
    {
      get
      {
        return GetResourceString();
      }
    }


    /// <summary>
    ///   Looks up a localized string similar to List item must be marked as a child object.
    /// </summary>
    public static string ListItemNotAChildException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to {0} can not exceed {1}.
    /// </summary>
    public static string MaxValueRule
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Member not found on object ({0}).
    /// </summary>
    public static string MemberNotFoundException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to method call failed.
    /// </summary>
    public static string MethodCallFailed
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Method execution not allowed.
    /// </summary>
    public static string MethodExecuteNotAllowed
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to not implemented.
    /// </summary>
    public static string MethodNotImplemented
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to {0} can not be less than {1}.
    /// </summary>
    public static string MinValueRule
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to The Type &apos;{0}&apos; was unable to be deserialized, double check that the assembly containing this class has the same name on the Client and Server and that it is referenced by your server application.
    /// </summary>
    public static string MobileFormatterUnableToDeserialize
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Type {0} must implement IMobileObject.
    /// </summary>
    public static string MustImplementIMobileObject
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Please set NavigatorProvider prior to TriggerEvent property..
    /// </summary>
    public static string NavigatorProviderSetPriorToTriggerEvent
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to ApplyEdit is not valid on a child object.
    /// </summary>
    public static string NoApplyEditChildException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to BeginEdit is not valid on a child object.
    /// </summary>
    public static string NoBeginEditChildException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to CancelEdit is not valid on a child object.
    /// </summary>
    public static string NoCancelEditChildException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Invalid for root objects - use Delete instead.
    /// </summary>
    public static string NoDeleteRootException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to No principal object should be passed to DataPortal when using Windows integrated security.
    /// </summary>
    public static string NoPrincipalAllowedException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Can not directly save a child object.
    /// </summary>
    public static string NoSaveChildException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Object is still being edited and can not be saved.
    /// </summary>
    public static string NoSaveEditingException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Object is not valid and can not be saved.
    /// </summary>
    public static string NoSaveInvalidException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to No such factory method:{0}.
    /// </summary>
    public static string NoSuchFactoryMethod
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to No such method {0}.
    /// </summary>
    public static string NoSuchMethod
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to No such value exists:.
    /// </summary>
    public static string NoSuchValueExistsException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Argument must not be Nothing.
    /// </summary>
    public static string NothingNotValid
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Can not set property if data object is not null.
    /// </summary>
    public static string ObjectNotNull
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Object not serializable ({0}).
    /// </summary>
    public static string ObjectNotSerializableFormatted
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Object rule can not have PrimaryPropery..
    /// </summary>
    public static string ObjectRulesCannotSetPrimaryProperty
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Object type or assembly could not be loaded ({0}).
    /// </summary>
    public static string ObjectTypeCouldNotBeLoaded
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Properties with private backing fields must be marked as RelationshipTypes.PrivateField.
    /// </summary>
    public static string PrivateFieldException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Property copy failed.
    /// </summary>
    public static string PropertyCopyFailed
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Property get not allowed.
    /// </summary>
    public static string PropertyGetNotAllowed
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Attempt to read/load private field property in managed properties..
    /// </summary>
    public static string PropertyIsPrivateField
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Property load or set failed for property {0} ({1}).
    /// </summary>
    public static string PropertyLoadException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to The specified property name &apos;{0}&apos; does not exist.
    /// </summary>
    public static string PropertyNameDoesNotExist
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to One or more properties are not registered for this type.
    /// </summary>
    public static string PropertyNotRegistered
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Property &apos;{0}&apos; not registered.
    /// </summary>
    public static string PropertyNameNotRegisteredException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Cannot register property {0}, a PropertyInfo with the same name already exists..
    /// </summary>
    public static string PropertyRegisterDuplicateNotAllowed
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Cannot register property {0} after containing type ({1}) has been instantiated.
    /// </summary>
    public static string PropertyRegisterNotAllowed
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to This property requires {0} index arguments, {1} were provided.
    /// </summary>
    public static string PropertyRequiresIndexArguments
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Property set not allowed.
    /// </summary>
    public static string PropertySetNotAllowed
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to {0} does not match regular expression.
    /// </summary>
    public static string RegExMatchRule
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Remove is an invalid operation.
    /// </summary>
    public static string RemoveInvalidException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to t.
    /// </summary>
    public static string SmartDateT
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to today.
    /// </summary>
    public static string SmartDateToday
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to tom.
    /// </summary>
    public static string SmartDateTom
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to tomorrow.
    /// </summary>
    public static string SmartDateTomorrow
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to y.
    /// </summary>
    public static string SmartDateY
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to yesterday.
    /// </summary>
    public static string SmartDateYesterday
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to PropertyName &apos;{0}&apos; not found in list.
    /// </summary>
    public static string SortedBindingListPropertyNameNotFound
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Sorting not supported.
    /// </summary>
    public static string SortingNotSupported
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to {0} can not exceed {1} characters.
    /// </summary>
    public static string StringMaxLengthRule
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to {0} must be at least {1} characters.
    /// </summary>
    public static string StringMinLengthRule
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to {0} required.
    /// </summary>
    public static string StringRequiredRule
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to String value can not be converted to a date.
    /// </summary>
    public static string StringToDateException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Failed to load type &apos;{0}&apos;.
    /// </summary>
    public static string TypeLoadException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Update method name not specified in MobileFactory attribute.
    /// </summary>
    public static string UpdateMethodNameNotSpecified
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Invalid operation - update not allowed.
    /// </summary>
    public static string UpdateNotSupportedException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to User not authorized to {0} object type {1}.
    /// </summary>
    public static string UserNotAuthorizedException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Value is not a SmartDate.
    /// </summary>
    public static string ValueNotSmartDateException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    ///   Looks up a localized string similar to Warning.
    /// </summary>
    public static string Warning
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    /// Looks up a localized string.
    /// </summary>
    public static string PropertyNotInAffectedPropertiesException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    /// Looks up a localized string.
    /// </summary>
    public static string UnandledKNownTypeException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    /// Looks up a localized string.
    /// </summary>
    public static string BinaryWriterObjectSerializationException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    /// Looks up a localized string.
    /// </summary>
    public static string TaskOfObjectException
    {
      get
      {
        return GetResourceString();
      }
    }

    /// <summary>
    /// Looks up a localized string.
    /// </summary>
    public static string AsyncLoadException
    {
      get
      {
        return GetResourceString();
      }
    }
  }
}
#endif