using System;

using Mindscape.LightSpeed;
using Mindscape.LightSpeed.Validation;
using Mindscape.LightSpeed.Linq;

namespace AUTH_RCTPL
{
  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  [Table("M_PAIP", IdColumnName="PAIP_ID")]
  public partial class MPaip : Entity<long>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 15)]
    private string _papin;
    [Column("FIRST_NAME")]
    [ValidateLength(0, 50)]
    private string _firstName;
    [Column("MIDDLE_NAME")]
    [ValidateLength(0, 50)]
    private string _middleName;
    [ValidateLength(0, 50)]
    private string _palname;
    [Column("COMPANY_NAME")]
    [ValidateLength(0, 150)]
    private string _companyName;
    [Column("BY_COMPNAME")]
    [ValidateLength(0, 1)]
    private string _byCompname;
    [ValidatePresence]
    [ValidateLength(0, 150)]
    private string _paaddress;
    [Column("MV_TYPE")]
    [ValidateLength(0, 20)]
    private string _mvType;
    [Column("VEHICLE_CLASS")]
    [ValidatePresence]
    [ValidateLength(0, 20)]
    private string _vehicleClass;
    [Column("PLATE_NO")]
    [ValidatePresence]
    [ValidateLength(0, 10)]
    private string _plateNo;
    [Column("SERIAL_NO")]
    [ValidatePresence]
    [ValidateLength(0, 40)]
    private string _serialNo;
    [Column("MOTOR_NO")]
    [ValidatePresence]
    [ValidateLength(0, 40)]
    private string _motorNo;
    [Column("SEATING_CAPACITY")]
    [ValidatePresence]
    [ValidateLength(0, 20)]
    private string _seatingCapacity;
    [Column("MODEL_YR")]
    [ValidatePresence]
    [ValidateLength(0, 20)]
    private string _modelYr;
    [Column("COVERAGE_YR")]
    [ValidatePresence]
    [ValidateLength(0, 5)]
    private string _coverageYr;
    [ValidatePresence]
    [ValidateLength(0, 25)]
    private string _make;
    [ValidatePresence]
    [ValidateLength(0, 20)]
    private string _series;
    [Column("SERVICE_TYPE")]
    [ValidateLength(0, 20)]
    private string _serviceType;
    [ValidatePresence]
    [ValidateLength(0, 20)]
    private string _color;
    [Column("UN_WEIGHT")]
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _unWeight;
    [Column("ASSURED_TIN")]
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _assuredTin;
    [Column("INSURED_FROM")]
    private System.DateTime _insuredFrom;
    [Column("INSURED_TO")]
    private System.DateTime _insuredTo;
    [ValidateLength(0, 50)]
    private string _remarks;
    [Column("TAX_TYPE")]
    [ValidateLength(0, 50)]
    private string _taxType;
    [Column("PLACE_ISSUED")]
    [ValidateLength(0, 20)]
    private string _placeIssued;
    [Column("MV_FILENO")]
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _mvFileno;
    private System.Nullable<System.DateTime> _paregister;
    [Column("COMP_ID")]
    [ValidateLength(0, 12)]
    private string _compId;
    [Column("BLT_FILENO")]
    [ValidateLength(0, 20)]
    private string _bltFileno;
    [Column("BUS_PROF")]
    [ValidateLength(0, 20)]
    private string _busProf;
    [Column("NO_DAYS")]
    private System.Nullable<decimal> _noDays;
    [Column("PRO_RATA")]
    [ValidateLength(0, 1)]
    private string _proRata;
    private System.Nullable<decimal> _fleet;
    [ValidatePresence]
    [ValidateLength(0, 30)]
    private string _fuel;
    [ValidateLength(0, 10)]
    private string _branch;
    [Column("NON_LTO")]
    [ValidateLength(0, 1)]
    private string _nonLto;
    [Column("VEHICLE_TYPE")]
    [ValidateLength(0, 20)]
    private string _vehicleType;
    [Column("TYPE_BODY")]
    [ValidatePresence]
    [ValidateLength(0, 50)]
    private string _typeBody;
    [Column("UPLOADED_CODE")]
    [ValidateLength(0, 50)]
    private string _uploadedCode;
    [Column("UPLOADED_DATE")]
    private System.Nullable<System.DateTime> _uploadedDate;
    [Column("RISK_CODE")]
    [ValidateLength(0, 10)]
    private string _riskCode;
    [Column("CONDUCTION_STICKER")]
    [ValidateLength(0, 20)]
    private string _conductionSticker;
    [Column("MARKET_SEGMENT")]
    [ValidateLength(0, 50)]
    private string _marketSegment;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Papin entity attribute.</summary>
    public const string PapinField = "Papin";
    /// <summary>Identifies the FirstName entity attribute.</summary>
    public const string FirstNameField = "FirstName";
    /// <summary>Identifies the MiddleName entity attribute.</summary>
    public const string MiddleNameField = "MiddleName";
    /// <summary>Identifies the Palname entity attribute.</summary>
    public const string PalnameField = "Palname";
    /// <summary>Identifies the CompanyName entity attribute.</summary>
    public const string CompanyNameField = "CompanyName";
    /// <summary>Identifies the ByCompname entity attribute.</summary>
    public const string ByCompnameField = "ByCompname";
    /// <summary>Identifies the Paaddress entity attribute.</summary>
    public const string PaaddressField = "Paaddress";
    /// <summary>Identifies the MvType entity attribute.</summary>
    public const string MvTypeField = "MvType";
    /// <summary>Identifies the VehicleClass entity attribute.</summary>
    public const string VehicleClassField = "VehicleClass";
    /// <summary>Identifies the PlateNo entity attribute.</summary>
    public const string PlateNoField = "PlateNo";
    /// <summary>Identifies the SerialNo entity attribute.</summary>
    public const string SerialNoField = "SerialNo";
    /// <summary>Identifies the MotorNo entity attribute.</summary>
    public const string MotorNoField = "MotorNo";
    /// <summary>Identifies the SeatingCapacity entity attribute.</summary>
    public const string SeatingCapacityField = "SeatingCapacity";
    /// <summary>Identifies the ModelYr entity attribute.</summary>
    public const string ModelYrField = "ModelYr";
    /// <summary>Identifies the CoverageYr entity attribute.</summary>
    public const string CoverageYrField = "CoverageYr";
    /// <summary>Identifies the Make entity attribute.</summary>
    public const string MakeField = "Make";
    /// <summary>Identifies the Series entity attribute.</summary>
    public const string SeriesField = "Series";
    /// <summary>Identifies the ServiceType entity attribute.</summary>
    public const string ServiceTypeField = "ServiceType";
    /// <summary>Identifies the Color entity attribute.</summary>
    public const string ColorField = "Color";
    /// <summary>Identifies the UnWeight entity attribute.</summary>
    public const string UnWeightField = "UnWeight";
    /// <summary>Identifies the AssuredTin entity attribute.</summary>
    public const string AssuredTinField = "AssuredTin";
    /// <summary>Identifies the InsuredFrom entity attribute.</summary>
    public const string InsuredFromField = "InsuredFrom";
    /// <summary>Identifies the InsuredTo entity attribute.</summary>
    public const string InsuredToField = "InsuredTo";
    /// <summary>Identifies the Remarks entity attribute.</summary>
    public const string RemarksField = "Remarks";
    /// <summary>Identifies the TaxType entity attribute.</summary>
    public const string TaxTypeField = "TaxType";
    /// <summary>Identifies the PlaceIssued entity attribute.</summary>
    public const string PlaceIssuedField = "PlaceIssued";
    /// <summary>Identifies the MvFileno entity attribute.</summary>
    public const string MvFilenoField = "MvFileno";
    /// <summary>Identifies the Paregister entity attribute.</summary>
    public const string ParegisterField = "Paregister";
    /// <summary>Identifies the CompId entity attribute.</summary>
    public const string CompIdField = "CompId";
    /// <summary>Identifies the BltFileno entity attribute.</summary>
    public const string BltFilenoField = "BltFileno";
    /// <summary>Identifies the BusProf entity attribute.</summary>
    public const string BusProfField = "BusProf";
    /// <summary>Identifies the NoDays entity attribute.</summary>
    public const string NoDaysField = "NoDays";
    /// <summary>Identifies the ProRata entity attribute.</summary>
    public const string ProRataField = "ProRata";
    /// <summary>Identifies the Fleet entity attribute.</summary>
    public const string FleetField = "Fleet";
    /// <summary>Identifies the Fuel entity attribute.</summary>
    public const string FuelField = "Fuel";
    /// <summary>Identifies the Branch entity attribute.</summary>
    public const string BranchField = "Branch";
    /// <summary>Identifies the NonLto entity attribute.</summary>
    public const string NonLtoField = "NonLto";
    /// <summary>Identifies the VehicleType entity attribute.</summary>
    public const string VehicleTypeField = "VehicleType";
    /// <summary>Identifies the TypeBody entity attribute.</summary>
    public const string TypeBodyField = "TypeBody";
    /// <summary>Identifies the UploadedCode entity attribute.</summary>
    public const string UploadedCodeField = "UploadedCode";
    /// <summary>Identifies the UploadedDate entity attribute.</summary>
    public const string UploadedDateField = "UploadedDate";
    /// <summary>Identifies the RiskCode entity attribute.</summary>
    public const string RiskCodeField = "RiskCode";
    /// <summary>Identifies the ConductionSticker entity attribute.</summary>
    public const string ConductionStickerField = "ConductionSticker";
    /// <summary>Identifies the MarketSegment entity attribute.</summary>
    public const string MarketSegmentField = "MarketSegment";


    #endregion
    
    #region Properties



    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Papin
    {
      get { return Get(ref _papin, "Papin"); }
      set { Set(ref _papin, value, "Papin"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string FirstName
    {
      get { return Get(ref _firstName, "FirstName"); }
      set { Set(ref _firstName, value, "FirstName"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string MiddleName
    {
      get { return Get(ref _middleName, "MiddleName"); }
      set { Set(ref _middleName, value, "MiddleName"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Palname
    {
      get { return Get(ref _palname, "Palname"); }
      set { Set(ref _palname, value, "Palname"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string CompanyName
    {
      get { return Get(ref _companyName, "CompanyName"); }
      set { Set(ref _companyName, value, "CompanyName"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ByCompname
    {
      get { return Get(ref _byCompname, "ByCompname"); }
      set { Set(ref _byCompname, value, "ByCompname"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Paaddress
    {
      get { return Get(ref _paaddress, "Paaddress"); }
      set { Set(ref _paaddress, value, "Paaddress"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string MvType
    {
      get { return Get(ref _mvType, "MvType"); }
      set { Set(ref _mvType, value, "MvType"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string VehicleClass
    {
      get { return Get(ref _vehicleClass, "VehicleClass"); }
      set { Set(ref _vehicleClass, value, "VehicleClass"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string PlateNo
    {
      get { return Get(ref _plateNo, "PlateNo"); }
      set { Set(ref _plateNo, value, "PlateNo"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string SerialNo
    {
      get { return Get(ref _serialNo, "SerialNo"); }
      set { Set(ref _serialNo, value, "SerialNo"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string MotorNo
    {
      get { return Get(ref _motorNo, "MotorNo"); }
      set { Set(ref _motorNo, value, "MotorNo"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string SeatingCapacity
    {
      get { return Get(ref _seatingCapacity, "SeatingCapacity"); }
      set { Set(ref _seatingCapacity, value, "SeatingCapacity"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ModelYr
    {
      get { return Get(ref _modelYr, "ModelYr"); }
      set { Set(ref _modelYr, value, "ModelYr"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string CoverageYr
    {
      get { return Get(ref _coverageYr, "CoverageYr"); }
      set { Set(ref _coverageYr, value, "CoverageYr"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Make
    {
      get { return Get(ref _make, "Make"); }
      set { Set(ref _make, value, "Make"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Series
    {
      get { return Get(ref _series, "Series"); }
      set { Set(ref _series, value, "Series"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ServiceType
    {
      get { return Get(ref _serviceType, "ServiceType"); }
      set { Set(ref _serviceType, value, "ServiceType"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Color
    {
      get { return Get(ref _color, "Color"); }
      set { Set(ref _color, value, "Color"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string UnWeight
    {
      get { return Get(ref _unWeight, "UnWeight"); }
      set { Set(ref _unWeight, value, "UnWeight"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string AssuredTin
    {
      get { return Get(ref _assuredTin, "AssuredTin"); }
      set { Set(ref _assuredTin, value, "AssuredTin"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime InsuredFrom
    {
      get { return Get(ref _insuredFrom, "InsuredFrom"); }
      set { Set(ref _insuredFrom, value, "InsuredFrom"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.DateTime InsuredTo
    {
      get { return Get(ref _insuredTo, "InsuredTo"); }
      set { Set(ref _insuredTo, value, "InsuredTo"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Remarks
    {
      get { return Get(ref _remarks, "Remarks"); }
      set { Set(ref _remarks, value, "Remarks"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string TaxType
    {
      get { return Get(ref _taxType, "TaxType"); }
      set { Set(ref _taxType, value, "TaxType"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string PlaceIssued
    {
      get { return Get(ref _placeIssued, "PlaceIssued"); }
      set { Set(ref _placeIssued, value, "PlaceIssued"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string MvFileno
    {
      get { return Get(ref _mvFileno, "MvFileno"); }
      set { Set(ref _mvFileno, value, "MvFileno"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> Paregister
    {
      get { return Get(ref _paregister, "Paregister"); }
      set { Set(ref _paregister, value, "Paregister"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string CompId
    {
      get { return Get(ref _compId, "CompId"); }
      set { Set(ref _compId, value, "CompId"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string BltFileno
    {
      get { return Get(ref _bltFileno, "BltFileno"); }
      set { Set(ref _bltFileno, value, "BltFileno"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string BusProf
    {
      get { return Get(ref _busProf, "BusProf"); }
      set { Set(ref _busProf, value, "BusProf"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> NoDays
    {
      get { return Get(ref _noDays, "NoDays"); }
      set { Set(ref _noDays, value, "NoDays"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ProRata
    {
      get { return Get(ref _proRata, "ProRata"); }
      set { Set(ref _proRata, value, "ProRata"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Fleet
    {
      get { return Get(ref _fleet, "Fleet"); }
      set { Set(ref _fleet, value, "Fleet"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Fuel
    {
      get { return Get(ref _fuel, "Fuel"); }
      set { Set(ref _fuel, value, "Fuel"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Branch
    {
      get { return Get(ref _branch, "Branch"); }
      set { Set(ref _branch, value, "Branch"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string NonLto
    {
      get { return Get(ref _nonLto, "NonLto"); }
      set { Set(ref _nonLto, value, "NonLto"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string VehicleType
    {
      get { return Get(ref _vehicleType, "VehicleType"); }
      set { Set(ref _vehicleType, value, "VehicleType"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string TypeBody
    {
      get { return Get(ref _typeBody, "TypeBody"); }
      set { Set(ref _typeBody, value, "TypeBody"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string UploadedCode
    {
      get { return Get(ref _uploadedCode, "UploadedCode"); }
      set { Set(ref _uploadedCode, value, "UploadedCode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> UploadedDate
    {
      get { return Get(ref _uploadedDate, "UploadedDate"); }
      set { Set(ref _uploadedDate, value, "UploadedDate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string RiskCode
    {
      get { return Get(ref _riskCode, "RiskCode"); }
      set { Set(ref _riskCode, value, "RiskCode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ConductionSticker
    {
      get { return Get(ref _conductionSticker, "ConductionSticker"); }
      set { Set(ref _conductionSticker, value, "ConductionSticker"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string MarketSegment
    {
      get { return Get(ref _marketSegment, "MarketSegment"); }
      set { Set(ref _marketSegment, value, "MarketSegment"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  [Table("T_BILLCHRGH", IdColumnName="BILLH_ID")]
  public partial class TBillchrgh : Entity<long>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 30)]
    private string _bchchrgno;
    [ValidateLength(0, 15)]
    private string _papin;
    [ValidateLength(0, 12)]
    private string _trkid;
    private System.Nullable<System.DateTime> _bchdte;
    [ValidateLength(0, 50)]
    private string _usrid;
    [ValidateLength(0, 6)]
    private string _pkcd;
    [Column("UPLOADED_CODE")]
    [ValidateLength(0, 50)]
    private string _uploadedCode;
    [Column("UPLOADED_DATE")]
    private System.Nullable<System.DateTime> _uploadedDate;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Bchchrgno entity attribute.</summary>
    public const string BchchrgnoField = "Bchchrgno";
    /// <summary>Identifies the Papin entity attribute.</summary>
    public const string PapinField = "Papin";
    /// <summary>Identifies the Trkid entity attribute.</summary>
    public const string TrkidField = "Trkid";
    /// <summary>Identifies the Bchdte entity attribute.</summary>
    public const string BchdteField = "Bchdte";
    /// <summary>Identifies the Usrid entity attribute.</summary>
    public const string UsridField = "Usrid";
    /// <summary>Identifies the Pkcd entity attribute.</summary>
    public const string PkcdField = "Pkcd";
    /// <summary>Identifies the UploadedCode entity attribute.</summary>
    public const string UploadedCodeField = "UploadedCode";
    /// <summary>Identifies the UploadedDate entity attribute.</summary>
    public const string UploadedDateField = "UploadedDate";


    #endregion
    
    #region Properties



    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Bchchrgno
    {
      get { return Get(ref _bchchrgno, "Bchchrgno"); }
      set { Set(ref _bchchrgno, value, "Bchchrgno"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Papin
    {
      get { return Get(ref _papin, "Papin"); }
      set { Set(ref _papin, value, "Papin"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Trkid
    {
      get { return Get(ref _trkid, "Trkid"); }
      set { Set(ref _trkid, value, "Trkid"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> Bchdte
    {
      get { return Get(ref _bchdte, "Bchdte"); }
      set { Set(ref _bchdte, value, "Bchdte"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Usrid
    {
      get { return Get(ref _usrid, "Usrid"); }
      set { Set(ref _usrid, value, "Usrid"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Pkcd
    {
      get { return Get(ref _pkcd, "Pkcd"); }
      set { Set(ref _pkcd, value, "Pkcd"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string UploadedCode
    {
      get { return Get(ref _uploadedCode, "UploadedCode"); }
      set { Set(ref _uploadedCode, value, "UploadedCode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> UploadedDate
    {
      get { return Get(ref _uploadedDate, "UploadedDate"); }
      set { Set(ref _uploadedDate, value, "UploadedDate"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  [Table("T_BILLCHRGD", IdColumnName="BILLD_ID")]
  public partial class TBillchrgd : Entity<long>
  {
    #region Fields
  
    [ValidatePresence]
    [ValidateLength(0, 30)]
    private string _bchchrgno;
    private int _bcdseries;
    [ValidatePresence]
    [ValidateLength(0, 12)]
    private string _bcditmcd;
    [ValidatePresence]
    [ValidateLength(0, 125)]
    private string _bcdesc;
    private int _bcdqty;
    private decimal _bcdsp;
    private System.Nullable<decimal> _bcdpatcover;
    private System.Nullable<decimal> _bcdpatbal;
    private System.Nullable<decimal> _bcdtppcover;
    [ValidateLength(0, 5)]
    private string _disccd;
    [ValidateLength(0, 8)]
    private string _tpcd;
    [ValidateLength(0, 1)]
    private string _bcdtpptag;
    [ValidateLength(0, 15)]
    private string _colornum;
    [ValidateLength(0, 12)]
    private string _bcdsino;
    private System.Nullable<decimal> _bcdtppbal;
    [Column("DOC_STAMP")]
    private System.Nullable<decimal> _docStamp;
    [Column("E_VAT")]
    private System.Nullable<decimal> _eVat;
    private System.Nullable<decimal> _lgt;
    [Column("SUM_INSIRED")]
    private System.Nullable<decimal> _sumInsired;
    [Column("COMP_FEE")]
    private System.Nullable<decimal> _compFee;
    [Column("CERT_FEE")]
    private System.Nullable<decimal> _certFee;
    [Column("BASIC_PREMIUM")]
    private System.Nullable<decimal> _basicPremium;
    [Column("DOC_OR")]
    [ValidateLength(0, 15)]
    private string _docOr;
    [ValidateLength(0, 20)]
    private string _coi;
    private System.Nullable<decimal> _commission;
    [Column("AUTHEN_CODE")]
    [ValidateLength(0, 20)]
    private string _authenCode;
    [Column("TAX_AMT")]
    private System.Nullable<decimal> _taxAmt;
    [Column("WITH_COM")]
    [ValidateLength(0, 1)]
    private string _withCom;
    [Column("W_TAX")]
    private System.Nullable<decimal> _wTax;
    [Column("W_TAX_NET")]
    private System.Nullable<decimal> _wTaxNet;
    [Column("NO_DAYS")]
    private System.Nullable<decimal> _noDays;
    [Column("PRO_RATA")]
    [ValidateLength(0, 1)]
    private string _proRata;
    [Column("REG_TYPE")]
    [ValidateLength(0, 5)]
    private string _regType;
    [Column("TRANS_TYPE")]
    [ValidateLength(0, 5)]
    private string _transType;
    [ValidateLength(0, 10)]
    private string _region;
    [Column("ENDO_NO")]
    [ValidateLength(0, 20)]
    private string _endoNo;
    [Column("UPLOADED_CODE")]
    [ValidateLength(0, 50)]
    private string _uploadedCode;
    [Column("UPLOADED_DATE")]
    private System.Nullable<System.DateTime> _uploadedDate;
    [Column("LTFRB_DCODE")]
    [ValidateLength(0, 50)]
    private string _ltfrbDcode;
    [Column("LTFRB_DDATE")]
    private System.Nullable<System.DateTime> _ltfrbDdate;
    [Column("VEHICLE_NUMBER")]
    [ValidateLength(0, 20)]
    private string _vehicleNumber;
    private System.Nullable<decimal> _refund;
    [Column("OTH_CHRGES")]
    private System.Nullable<decimal> _othChrges;
    private System.Nullable<decimal> _taxes;
    [Column("CAN_POLICY")]
    [ValidateLength(0, 1)]
    private string _canPolicy;
    [Column("DATE_CANCEL")]
    private System.Nullable<System.DateTime> _dateCancel;
    [Column("can_user")]
    [ValidateLength(0, 50)]
    private string _canUser;
    [ValidateLength(0, 50)]
    private string _prnt;
    [Column("DATE_PRINTED")]
    private System.Nullable<System.DateTime> _datePrinted;
    [Column("REF_NUM")]
    [ValidateLength(0, 50)]
    private string _refNum;
    private System.Nullable<System.DateTime> _datepaid;
    [Column("VEHICLE_CODE")]
    [ValidateLength(0, 50)]
    private string _vehicleCode;
    [Column("COMP_SHARE")]
    private System.Nullable<decimal> _compShare;
    [Column("TPP_SHARE")]
    private System.Nullable<decimal> _tppShare;
    [Column("QR_IMAGE")]
    private byte[] _qrImage;
    private System.Nullable<decimal> _ctpl;
    private System.Nullable<decimal> _pl;
    [Column("AUTHEN_FEE")]
    private System.Nullable<decimal> _authenFee;
    [ValidateLength(0, 10)]
    private string _municipality;
    [Column("COC_SERIES")]
    [ValidateLength(0, 10)]
    private string _cocSeries;
    [Column("BAYAD_CENTER")]
    private System.Nullable<decimal> _bayadCenter;
    [Column("RISK_CODE")]
    [ValidateLength(0, 10)]
    private string _riskCode;
    [Column("LGT_RATE")]
    private System.Nullable<decimal> _lgtRate;
    [Column("INCEPTION_FROM")]
    private System.Nullable<System.DateTime> _inceptionFrom;
    [Column("INCEPTION_TO")]
    private System.Nullable<System.DateTime> _inceptionTo;
    [Column("CHARGES_OR")]
    [ValidateLength(0, 20)]
    private string _chargesOr;
    [Column("W_TAX_SHARE")]
    private System.Nullable<decimal> _wTaxShare;
    [Column("WITH_CLAIMS")]
    [ValidateLength(0, 1)]
    private string _withClaims;
    [Column("CLAIM_BRANCH")]
    [ValidateLength(0, 10)]
    private string _claimBranch;
    [Column("AGENT_OR")]
    [ValidateLength(0, 10)]
    private string _agentOr;
    [Column("AGENT_OR_DATE")]
    private System.Nullable<System.DateTime> _agentOrDate;
    [Column("AGENT_OR_AMOUNT")]
    private System.Nullable<decimal> _agentOrAmount;
    [Column("BATCH_CODE")]
    [ValidateLength(0, 50)]
    private string _batchCode;
    [Column("AUTHENTICATION_MESSAGE")]
    [ValidateLength(0, 150)]
    private string _authenticationMessage;
    [Column("AUTHEN_STATUS")]
    [ValidateLength(0, 1)]
    private string _authenStatus;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Bchchrgno entity attribute.</summary>
    public const string BchchrgnoField = "Bchchrgno";
    /// <summary>Identifies the Bcdseries entity attribute.</summary>
    public const string BcdseriesField = "Bcdseries";
    /// <summary>Identifies the Bcditmcd entity attribute.</summary>
    public const string BcditmcdField = "Bcditmcd";
    /// <summary>Identifies the Bcdesc entity attribute.</summary>
    public const string BcdescField = "Bcdesc";
    /// <summary>Identifies the Bcdqty entity attribute.</summary>
    public const string BcdqtyField = "Bcdqty";
    /// <summary>Identifies the Bcdsp entity attribute.</summary>
    public const string BcdspField = "Bcdsp";
    /// <summary>Identifies the Bcdpatcover entity attribute.</summary>
    public const string BcdpatcoverField = "Bcdpatcover";
    /// <summary>Identifies the Bcdpatbal entity attribute.</summary>
    public const string BcdpatbalField = "Bcdpatbal";
    /// <summary>Identifies the Bcdtppcover entity attribute.</summary>
    public const string BcdtppcoverField = "Bcdtppcover";
    /// <summary>Identifies the Disccd entity attribute.</summary>
    public const string DisccdField = "Disccd";
    /// <summary>Identifies the Tpcd entity attribute.</summary>
    public const string TpcdField = "Tpcd";
    /// <summary>Identifies the Bcdtpptag entity attribute.</summary>
    public const string BcdtpptagField = "Bcdtpptag";
    /// <summary>Identifies the Colornum entity attribute.</summary>
    public const string ColornumField = "Colornum";
    /// <summary>Identifies the Bcdsino entity attribute.</summary>
    public const string BcdsinoField = "Bcdsino";
    /// <summary>Identifies the Bcdtppbal entity attribute.</summary>
    public const string BcdtppbalField = "Bcdtppbal";
    /// <summary>Identifies the DocStamp entity attribute.</summary>
    public const string DocStampField = "DocStamp";
    /// <summary>Identifies the EVat entity attribute.</summary>
    public const string EVatField = "EVat";
    /// <summary>Identifies the Lgt entity attribute.</summary>
    public const string LgtField = "Lgt";
    /// <summary>Identifies the SumInsired entity attribute.</summary>
    public const string SumInsiredField = "SumInsired";
    /// <summary>Identifies the CompFee entity attribute.</summary>
    public const string CompFeeField = "CompFee";
    /// <summary>Identifies the CertFee entity attribute.</summary>
    public const string CertFeeField = "CertFee";
    /// <summary>Identifies the BasicPremium entity attribute.</summary>
    public const string BasicPremiumField = "BasicPremium";
    /// <summary>Identifies the DocOr entity attribute.</summary>
    public const string DocOrField = "DocOr";
    /// <summary>Identifies the Coi entity attribute.</summary>
    public const string CoiField = "Coi";
    /// <summary>Identifies the Commission entity attribute.</summary>
    public const string CommissionField = "Commission";
    /// <summary>Identifies the AuthenCode entity attribute.</summary>
    public const string AuthenCodeField = "AuthenCode";
    /// <summary>Identifies the TaxAmt entity attribute.</summary>
    public const string TaxAmtField = "TaxAmt";
    /// <summary>Identifies the WithCom entity attribute.</summary>
    public const string WithComField = "WithCom";
    /// <summary>Identifies the WTax entity attribute.</summary>
    public const string WTaxField = "WTax";
    /// <summary>Identifies the WTaxNet entity attribute.</summary>
    public const string WTaxNetField = "WTaxNet";
    /// <summary>Identifies the NoDays entity attribute.</summary>
    public const string NoDaysField = "NoDays";
    /// <summary>Identifies the ProRata entity attribute.</summary>
    public const string ProRataField = "ProRata";
    /// <summary>Identifies the RegType entity attribute.</summary>
    public const string RegTypeField = "RegType";
    /// <summary>Identifies the TransType entity attribute.</summary>
    public const string TransTypeField = "TransType";
    /// <summary>Identifies the Region entity attribute.</summary>
    public const string RegionField = "Region";
    /// <summary>Identifies the EndoNo entity attribute.</summary>
    public const string EndoNoField = "EndoNo";
    /// <summary>Identifies the UploadedCode entity attribute.</summary>
    public const string UploadedCodeField = "UploadedCode";
    /// <summary>Identifies the UploadedDate entity attribute.</summary>
    public const string UploadedDateField = "UploadedDate";
    /// <summary>Identifies the LtfrbDcode entity attribute.</summary>
    public const string LtfrbDcodeField = "LtfrbDcode";
    /// <summary>Identifies the LtfrbDdate entity attribute.</summary>
    public const string LtfrbDdateField = "LtfrbDdate";
    /// <summary>Identifies the VehicleNumber entity attribute.</summary>
    public const string VehicleNumberField = "VehicleNumber";
    /// <summary>Identifies the Refund entity attribute.</summary>
    public const string RefundField = "Refund";
    /// <summary>Identifies the OthChrges entity attribute.</summary>
    public const string OthChrgesField = "OthChrges";
    /// <summary>Identifies the Taxes entity attribute.</summary>
    public const string TaxesField = "Taxes";
    /// <summary>Identifies the CanPolicy entity attribute.</summary>
    public const string CanPolicyField = "CanPolicy";
    /// <summary>Identifies the DateCancel entity attribute.</summary>
    public const string DateCancelField = "DateCancel";
    /// <summary>Identifies the CanUser entity attribute.</summary>
    public const string CanUserField = "CanUser";
    /// <summary>Identifies the Prnt entity attribute.</summary>
    public const string PrntField = "Prnt";
    /// <summary>Identifies the DatePrinted entity attribute.</summary>
    public const string DatePrintedField = "DatePrinted";
    /// <summary>Identifies the RefNum entity attribute.</summary>
    public const string RefNumField = "RefNum";
    /// <summary>Identifies the Datepaid entity attribute.</summary>
    public const string DatepaidField = "Datepaid";
    /// <summary>Identifies the VehicleCode entity attribute.</summary>
    public const string VehicleCodeField = "VehicleCode";
    /// <summary>Identifies the CompShare entity attribute.</summary>
    public const string CompShareField = "CompShare";
    /// <summary>Identifies the TppShare entity attribute.</summary>
    public const string TppShareField = "TppShare";
    /// <summary>Identifies the QrImage entity attribute.</summary>
    public const string QrImageField = "QrImage";
    /// <summary>Identifies the Ctpl entity attribute.</summary>
    public const string CtplField = "Ctpl";
    /// <summary>Identifies the Pl entity attribute.</summary>
    public const string PlField = "Pl";
    /// <summary>Identifies the AuthenFee entity attribute.</summary>
    public const string AuthenFeeField = "AuthenFee";
    /// <summary>Identifies the Municipality entity attribute.</summary>
    public const string MunicipalityField = "Municipality";
    /// <summary>Identifies the CocSeries entity attribute.</summary>
    public const string CocSeriesField = "CocSeries";
    /// <summary>Identifies the BayadCenter entity attribute.</summary>
    public const string BayadCenterField = "BayadCenter";
    /// <summary>Identifies the RiskCode entity attribute.</summary>
    public const string RiskCodeField = "RiskCode";
    /// <summary>Identifies the LgtRate entity attribute.</summary>
    public const string LgtRateField = "LgtRate";
    /// <summary>Identifies the InceptionFrom entity attribute.</summary>
    public const string InceptionFromField = "InceptionFrom";
    /// <summary>Identifies the InceptionTo entity attribute.</summary>
    public const string InceptionToField = "InceptionTo";
    /// <summary>Identifies the ChargesOr entity attribute.</summary>
    public const string ChargesOrField = "ChargesOr";
    /// <summary>Identifies the WTaxShare entity attribute.</summary>
    public const string WTaxShareField = "WTaxShare";
    /// <summary>Identifies the WithClaims entity attribute.</summary>
    public const string WithClaimsField = "WithClaims";
    /// <summary>Identifies the ClaimBranch entity attribute.</summary>
    public const string ClaimBranchField = "ClaimBranch";
    /// <summary>Identifies the AgentOr entity attribute.</summary>
    public const string AgentOrField = "AgentOr";
    /// <summary>Identifies the AgentOrDate entity attribute.</summary>
    public const string AgentOrDateField = "AgentOrDate";
    /// <summary>Identifies the AgentOrAmount entity attribute.</summary>
    public const string AgentOrAmountField = "AgentOrAmount";
    /// <summary>Identifies the BatchCode entity attribute.</summary>
    public const string BatchCodeField = "BatchCode";
    /// <summary>Identifies the AuthenticationMessage entity attribute.</summary>
    public const string AuthenticationMessageField = "AuthenticationMessage";
    /// <summary>Identifies the AuthenStatus entity attribute.</summary>
    public const string AuthenStatusField = "AuthenStatus";


    #endregion
    
    #region Properties



    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Bchchrgno
    {
      get { return Get(ref _bchchrgno, "Bchchrgno"); }
      set { Set(ref _bchchrgno, value, "Bchchrgno"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public int Bcdseries
    {
      get { return Get(ref _bcdseries, "Bcdseries"); }
      set { Set(ref _bcdseries, value, "Bcdseries"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Bcditmcd
    {
      get { return Get(ref _bcditmcd, "Bcditmcd"); }
      set { Set(ref _bcditmcd, value, "Bcditmcd"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Bcdesc
    {
      get { return Get(ref _bcdesc, "Bcdesc"); }
      set { Set(ref _bcdesc, value, "Bcdesc"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public int Bcdqty
    {
      get { return Get(ref _bcdqty, "Bcdqty"); }
      set { Set(ref _bcdqty, value, "Bcdqty"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public decimal Bcdsp
    {
      get { return Get(ref _bcdsp, "Bcdsp"); }
      set { Set(ref _bcdsp, value, "Bcdsp"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Bcdpatcover
    {
      get { return Get(ref _bcdpatcover, "Bcdpatcover"); }
      set { Set(ref _bcdpatcover, value, "Bcdpatcover"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Bcdpatbal
    {
      get { return Get(ref _bcdpatbal, "Bcdpatbal"); }
      set { Set(ref _bcdpatbal, value, "Bcdpatbal"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Bcdtppcover
    {
      get { return Get(ref _bcdtppcover, "Bcdtppcover"); }
      set { Set(ref _bcdtppcover, value, "Bcdtppcover"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Disccd
    {
      get { return Get(ref _disccd, "Disccd"); }
      set { Set(ref _disccd, value, "Disccd"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Tpcd
    {
      get { return Get(ref _tpcd, "Tpcd"); }
      set { Set(ref _tpcd, value, "Tpcd"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Bcdtpptag
    {
      get { return Get(ref _bcdtpptag, "Bcdtpptag"); }
      set { Set(ref _bcdtpptag, value, "Bcdtpptag"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Colornum
    {
      get { return Get(ref _colornum, "Colornum"); }
      set { Set(ref _colornum, value, "Colornum"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Bcdsino
    {
      get { return Get(ref _bcdsino, "Bcdsino"); }
      set { Set(ref _bcdsino, value, "Bcdsino"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Bcdtppbal
    {
      get { return Get(ref _bcdtppbal, "Bcdtppbal"); }
      set { Set(ref _bcdtppbal, value, "Bcdtppbal"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> DocStamp
    {
      get { return Get(ref _docStamp, "DocStamp"); }
      set { Set(ref _docStamp, value, "DocStamp"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> EVat
    {
      get { return Get(ref _eVat, "EVat"); }
      set { Set(ref _eVat, value, "EVat"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Lgt
    {
      get { return Get(ref _lgt, "Lgt"); }
      set { Set(ref _lgt, value, "Lgt"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> SumInsired
    {
      get { return Get(ref _sumInsired, "SumInsired"); }
      set { Set(ref _sumInsired, value, "SumInsired"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> CompFee
    {
      get { return Get(ref _compFee, "CompFee"); }
      set { Set(ref _compFee, value, "CompFee"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> CertFee
    {
      get { return Get(ref _certFee, "CertFee"); }
      set { Set(ref _certFee, value, "CertFee"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> BasicPremium
    {
      get { return Get(ref _basicPremium, "BasicPremium"); }
      set { Set(ref _basicPremium, value, "BasicPremium"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string DocOr
    {
      get { return Get(ref _docOr, "DocOr"); }
      set { Set(ref _docOr, value, "DocOr"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Coi
    {
      get { return Get(ref _coi, "Coi"); }
      set { Set(ref _coi, value, "Coi"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Commission
    {
      get { return Get(ref _commission, "Commission"); }
      set { Set(ref _commission, value, "Commission"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string AuthenCode
    {
      get { return Get(ref _authenCode, "AuthenCode"); }
      set { Set(ref _authenCode, value, "AuthenCode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> TaxAmt
    {
      get { return Get(ref _taxAmt, "TaxAmt"); }
      set { Set(ref _taxAmt, value, "TaxAmt"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string WithCom
    {
      get { return Get(ref _withCom, "WithCom"); }
      set { Set(ref _withCom, value, "WithCom"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> WTax
    {
      get { return Get(ref _wTax, "WTax"); }
      set { Set(ref _wTax, value, "WTax"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> WTaxNet
    {
      get { return Get(ref _wTaxNet, "WTaxNet"); }
      set { Set(ref _wTaxNet, value, "WTaxNet"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> NoDays
    {
      get { return Get(ref _noDays, "NoDays"); }
      set { Set(ref _noDays, value, "NoDays"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ProRata
    {
      get { return Get(ref _proRata, "ProRata"); }
      set { Set(ref _proRata, value, "ProRata"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string RegType
    {
      get { return Get(ref _regType, "RegType"); }
      set { Set(ref _regType, value, "RegType"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string TransType
    {
      get { return Get(ref _transType, "TransType"); }
      set { Set(ref _transType, value, "TransType"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Region
    {
      get { return Get(ref _region, "Region"); }
      set { Set(ref _region, value, "Region"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string EndoNo
    {
      get { return Get(ref _endoNo, "EndoNo"); }
      set { Set(ref _endoNo, value, "EndoNo"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string UploadedCode
    {
      get { return Get(ref _uploadedCode, "UploadedCode"); }
      set { Set(ref _uploadedCode, value, "UploadedCode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> UploadedDate
    {
      get { return Get(ref _uploadedDate, "UploadedDate"); }
      set { Set(ref _uploadedDate, value, "UploadedDate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string LtfrbDcode
    {
      get { return Get(ref _ltfrbDcode, "LtfrbDcode"); }
      set { Set(ref _ltfrbDcode, value, "LtfrbDcode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> LtfrbDdate
    {
      get { return Get(ref _ltfrbDdate, "LtfrbDdate"); }
      set { Set(ref _ltfrbDdate, value, "LtfrbDdate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string VehicleNumber
    {
      get { return Get(ref _vehicleNumber, "VehicleNumber"); }
      set { Set(ref _vehicleNumber, value, "VehicleNumber"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Refund
    {
      get { return Get(ref _refund, "Refund"); }
      set { Set(ref _refund, value, "Refund"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> OthChrges
    {
      get { return Get(ref _othChrges, "OthChrges"); }
      set { Set(ref _othChrges, value, "OthChrges"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Taxes
    {
      get { return Get(ref _taxes, "Taxes"); }
      set { Set(ref _taxes, value, "Taxes"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string CanPolicy
    {
      get { return Get(ref _canPolicy, "CanPolicy"); }
      set { Set(ref _canPolicy, value, "CanPolicy"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> DateCancel
    {
      get { return Get(ref _dateCancel, "DateCancel"); }
      set { Set(ref _dateCancel, value, "DateCancel"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string CanUser
    {
      get { return Get(ref _canUser, "CanUser"); }
      set { Set(ref _canUser, value, "CanUser"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Prnt
    {
      get { return Get(ref _prnt, "Prnt"); }
      set { Set(ref _prnt, value, "Prnt"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> DatePrinted
    {
      get { return Get(ref _datePrinted, "DatePrinted"); }
      set { Set(ref _datePrinted, value, "DatePrinted"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string RefNum
    {
      get { return Get(ref _refNum, "RefNum"); }
      set { Set(ref _refNum, value, "RefNum"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> Datepaid
    {
      get { return Get(ref _datepaid, "Datepaid"); }
      set { Set(ref _datepaid, value, "Datepaid"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string VehicleCode
    {
      get { return Get(ref _vehicleCode, "VehicleCode"); }
      set { Set(ref _vehicleCode, value, "VehicleCode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> CompShare
    {
      get { return Get(ref _compShare, "CompShare"); }
      set { Set(ref _compShare, value, "CompShare"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> TppShare
    {
      get { return Get(ref _tppShare, "TppShare"); }
      set { Set(ref _tppShare, value, "TppShare"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public byte[] QrImage
    {
      get { return Get(ref _qrImage, "QrImage"); }
      set { Set(ref _qrImage, value, "QrImage"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Ctpl
    {
      get { return Get(ref _ctpl, "Ctpl"); }
      set { Set(ref _ctpl, value, "Ctpl"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> Pl
    {
      get { return Get(ref _pl, "Pl"); }
      set { Set(ref _pl, value, "Pl"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> AuthenFee
    {
      get { return Get(ref _authenFee, "AuthenFee"); }
      set { Set(ref _authenFee, value, "AuthenFee"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Municipality
    {
      get { return Get(ref _municipality, "Municipality"); }
      set { Set(ref _municipality, value, "Municipality"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string CocSeries
    {
      get { return Get(ref _cocSeries, "CocSeries"); }
      set { Set(ref _cocSeries, value, "CocSeries"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> BayadCenter
    {
      get { return Get(ref _bayadCenter, "BayadCenter"); }
      set { Set(ref _bayadCenter, value, "BayadCenter"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string RiskCode
    {
      get { return Get(ref _riskCode, "RiskCode"); }
      set { Set(ref _riskCode, value, "RiskCode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> LgtRate
    {
      get { return Get(ref _lgtRate, "LgtRate"); }
      set { Set(ref _lgtRate, value, "LgtRate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> InceptionFrom
    {
      get { return Get(ref _inceptionFrom, "InceptionFrom"); }
      set { Set(ref _inceptionFrom, value, "InceptionFrom"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> InceptionTo
    {
      get { return Get(ref _inceptionTo, "InceptionTo"); }
      set { Set(ref _inceptionTo, value, "InceptionTo"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ChargesOr
    {
      get { return Get(ref _chargesOr, "ChargesOr"); }
      set { Set(ref _chargesOr, value, "ChargesOr"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> WTaxShare
    {
      get { return Get(ref _wTaxShare, "WTaxShare"); }
      set { Set(ref _wTaxShare, value, "WTaxShare"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string WithClaims
    {
      get { return Get(ref _withClaims, "WithClaims"); }
      set { Set(ref _withClaims, value, "WithClaims"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string ClaimBranch
    {
      get { return Get(ref _claimBranch, "ClaimBranch"); }
      set { Set(ref _claimBranch, value, "ClaimBranch"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string AgentOr
    {
      get { return Get(ref _agentOr, "AgentOr"); }
      set { Set(ref _agentOr, value, "AgentOr"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> AgentOrDate
    {
      get { return Get(ref _agentOrDate, "AgentOrDate"); }
      set { Set(ref _agentOrDate, value, "AgentOrDate"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<decimal> AgentOrAmount
    {
      get { return Get(ref _agentOrAmount, "AgentOrAmount"); }
      set { Set(ref _agentOrAmount, value, "AgentOrAmount"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string BatchCode
    {
      get { return Get(ref _batchCode, "BatchCode"); }
      set { Set(ref _batchCode, value, "BatchCode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string AuthenticationMessage
    {
      get { return Get(ref _authenticationMessage, "AuthenticationMessage"); }
      set { Set(ref _authenticationMessage, value, "AuthenticationMessage"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string AuthenStatus
    {
      get { return Get(ref _authenStatus, "AuthenStatus"); }
      set { Set(ref _authenStatus, value, "AuthenStatus"); }
    }

    #endregion
  }


  [Serializable]
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  [System.ComponentModel.DataObject]
  [System.Runtime.Serialization.DataContract]
  [Table("TBL_BILLDHIST")]
  public partial class TblBilldhist : Entity<long>
  {
    #region Fields
  
    [ValidateLength(0, 20)]
    private string _coi;
    [Column("AUTHEN_CODE")]
    [ValidateLength(0, 20)]
    private string _authenCode;
    [Column("AUTHENTICATION_MESSAGE")]
    [ValidateLength(0, 150)]
    private string _authenticationMessage;
    [Column("DATE_TRANS")]
    private System.Nullable<System.DateTime> _dateTrans;

    #endregion
    
    #region Field attribute and view names
    
    /// <summary>Identifies the Coi entity attribute.</summary>
    public const string CoiField = "Coi";
    /// <summary>Identifies the AuthenCode entity attribute.</summary>
    public const string AuthenCodeField = "AuthenCode";
    /// <summary>Identifies the AuthenticationMessage entity attribute.</summary>
    public const string AuthenticationMessageField = "AuthenticationMessage";
    /// <summary>Identifies the DateTrans entity attribute.</summary>
    public const string DateTransField = "DateTrans";


    #endregion
    
    #region Properties



    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string Coi
    {
      get { return Get(ref _coi, "Coi"); }
      set { Set(ref _coi, value, "Coi"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string AuthenCode
    {
      get { return Get(ref _authenCode, "AuthenCode"); }
      set { Set(ref _authenCode, value, "AuthenCode"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public string AuthenticationMessage
    {
      get { return Get(ref _authenticationMessage, "AuthenticationMessage"); }
      set { Set(ref _authenticationMessage, value, "AuthenticationMessage"); }
    }

    [System.Runtime.Serialization.DataMember]
    [System.Diagnostics.DebuggerNonUserCode]
    public System.Nullable<System.DateTime> DateTrans
    {
      get { return Get(ref _dateTrans, "DateTrans"); }
      set { Set(ref _dateTrans, value, "DateTrans"); }
    }

    #endregion
  }




  /// <summary>
  /// Provides a strong-typed unit of work for working with the LSMAuthentication model.
  /// </summary>
  [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
  public partial class LSMAuthenticationUnitOfWork : Mindscape.LightSpeed.UnitOfWork
  {

    public System.Linq.IQueryable<MPaip> MPaips
    {
      get { return this.Query<MPaip>(); }
    }
    
    public System.Linq.IQueryable<TBillchrgh> TBillchrghs
    {
      get { return this.Query<TBillchrgh>(); }
    }
    
    public System.Linq.IQueryable<TBillchrgd> TBillchrgds
    {
      get { return this.Query<TBillchrgd>(); }
    }
    
    public System.Linq.IQueryable<TblBilldhist> TblBilldhists
    {
      get { return this.Query<TblBilldhist>(); }
    }
    
  }

#if LS3_DTOS

  namespace Contracts.Data
  {
    [System.Runtime.Serialization.DataContract(Name="LSMAuthenticationDtoBase")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class LSMAuthenticationDtoBase
    {
    }

    [System.Runtime.Serialization.DataContract(Name="MPaip")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class MPaipDto : LSMAuthenticationDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Papin { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string FirstName { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string MiddleName { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Palname { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string CompanyName { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ByCompname { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Paaddress { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string MvType { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string VehicleClass { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string PlateNo { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string SerialNo { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string MotorNo { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string SeatingCapacity { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ModelYr { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string CoverageYr { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Make { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Series { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ServiceType { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Color { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string UnWeight { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string AssuredTin { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.DateTime InsuredFrom { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.DateTime InsuredTo { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Remarks { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string TaxType { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string PlaceIssued { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string MvFileno { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> Paregister { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string CompId { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string BltFileno { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string BusProf { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> NoDays { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ProRata { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Fleet { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Fuel { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Branch { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string NonLto { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string VehicleType { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string TypeBody { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string UploadedCode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> UploadedDate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string RiskCode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ConductionSticker { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string MarketSegment { get; set; }
    }

    [System.Runtime.Serialization.DataContract(Name="TBillchrgh")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class TBillchrghDto : LSMAuthenticationDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Bchchrgno { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Papin { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Trkid { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> Bchdte { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Usrid { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Pkcd { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string UploadedCode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> UploadedDate { get; set; }
    }

    [System.Runtime.Serialization.DataContract(Name="TBillchrgd")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class TBillchrgdDto : LSMAuthenticationDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Bchchrgno { get; set; }
      [System.Runtime.Serialization.DataMember]
      public int Bcdseries { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Bcditmcd { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Bcdesc { get; set; }
      [System.Runtime.Serialization.DataMember]
      public int Bcdqty { get; set; }
      [System.Runtime.Serialization.DataMember]
      public decimal Bcdsp { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Bcdpatcover { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Bcdpatbal { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Bcdtppcover { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Disccd { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Tpcd { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Bcdtpptag { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Colornum { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Bcdsino { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Bcdtppbal { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> DocStamp { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> EVat { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Lgt { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> SumInsired { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> CompFee { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> CertFee { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> BasicPremium { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string DocOr { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Coi { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Commission { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string AuthenCode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> TaxAmt { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string WithCom { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> WTax { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> WTaxNet { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> NoDays { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ProRata { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string RegType { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string TransType { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Region { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string EndoNo { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string UploadedCode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> UploadedDate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string LtfrbDcode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> LtfrbDdate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string VehicleNumber { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Refund { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> OthChrges { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Taxes { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string CanPolicy { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> DateCancel { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string CanUser { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Prnt { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> DatePrinted { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string RefNum { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> Datepaid { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string VehicleCode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> CompShare { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> TppShare { get; set; }
      [System.Runtime.Serialization.DataMember]
      public byte[] QrImage { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Ctpl { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> Pl { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> AuthenFee { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string Municipality { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string CocSeries { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> BayadCenter { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string RiskCode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> LgtRate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> InceptionFrom { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> InceptionTo { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ChargesOr { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> WTaxShare { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string WithClaims { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string ClaimBranch { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string AgentOr { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> AgentOrDate { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<decimal> AgentOrAmount { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string BatchCode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string AuthenticationMessage { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string AuthenStatus { get; set; }
    }

    [System.Runtime.Serialization.DataContract(Name="TblBilldhist")]
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public partial class TblBilldhistDto : LSMAuthenticationDtoBase
    {
      [System.Runtime.Serialization.DataMember]
      public string Coi { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string AuthenCode { get; set; }
      [System.Runtime.Serialization.DataMember]
      public string AuthenticationMessage { get; set; }
      [System.Runtime.Serialization.DataMember]
      public System.Nullable<System.DateTime> DateTrans { get; set; }
    }


    
    [System.CodeDom.Compiler.GeneratedCode("LightSpeedModelGenerator", "1.0.0.0")]
    public static partial class LSMAuthenticationDtoExtensions
    {
      static partial void CopyLSMAuthenticationDtoBase(Entity entity, LSMAuthenticationDtoBase dto);
      static partial void CopyLSMAuthenticationDtoBase(LSMAuthenticationDtoBase dto, Entity entity);

      static partial void BeforeCopyMPaip(MPaip entity, MPaipDto dto);
      static partial void AfterCopyMPaip(MPaip entity, MPaipDto dto);
      static partial void BeforeCopyMPaip(MPaipDto dto, MPaip entity);
      static partial void AfterCopyMPaip(MPaipDto dto, MPaip entity);
      
      private static void CopyMPaip(MPaip entity, MPaipDto dto)
      {
        BeforeCopyMPaip(entity, dto);
        CopyLSMAuthenticationDtoBase(entity, dto);
        dto.Papin = entity.Papin;
        dto.FirstName = entity.FirstName;
        dto.MiddleName = entity.MiddleName;
        dto.Palname = entity.Palname;
        dto.CompanyName = entity.CompanyName;
        dto.ByCompname = entity.ByCompname;
        dto.Paaddress = entity.Paaddress;
        dto.MvType = entity.MvType;
        dto.VehicleClass = entity.VehicleClass;
        dto.PlateNo = entity.PlateNo;
        dto.SerialNo = entity.SerialNo;
        dto.MotorNo = entity.MotorNo;
        dto.SeatingCapacity = entity.SeatingCapacity;
        dto.ModelYr = entity.ModelYr;
        dto.CoverageYr = entity.CoverageYr;
        dto.Make = entity.Make;
        dto.Series = entity.Series;
        dto.ServiceType = entity.ServiceType;
        dto.Color = entity.Color;
        dto.UnWeight = entity.UnWeight;
        dto.AssuredTin = entity.AssuredTin;
        dto.InsuredFrom = entity.InsuredFrom;
        dto.InsuredTo = entity.InsuredTo;
        dto.Remarks = entity.Remarks;
        dto.TaxType = entity.TaxType;
        dto.PlaceIssued = entity.PlaceIssued;
        dto.MvFileno = entity.MvFileno;
        dto.Paregister = entity.Paregister;
        dto.CompId = entity.CompId;
        dto.BltFileno = entity.BltFileno;
        dto.BusProf = entity.BusProf;
        dto.NoDays = entity.NoDays;
        dto.ProRata = entity.ProRata;
        dto.Fleet = entity.Fleet;
        dto.Fuel = entity.Fuel;
        dto.Branch = entity.Branch;
        dto.NonLto = entity.NonLto;
        dto.VehicleType = entity.VehicleType;
        dto.TypeBody = entity.TypeBody;
        dto.UploadedCode = entity.UploadedCode;
        dto.UploadedDate = entity.UploadedDate;
        dto.RiskCode = entity.RiskCode;
        dto.ConductionSticker = entity.ConductionSticker;
        dto.MarketSegment = entity.MarketSegment;
        AfterCopyMPaip(entity, dto);
      }
      
      private static void CopyMPaip(MPaipDto dto, MPaip entity)
      {
        BeforeCopyMPaip(dto, entity);
        CopyLSMAuthenticationDtoBase(dto, entity);
        entity.Papin = dto.Papin;
        entity.FirstName = dto.FirstName;
        entity.MiddleName = dto.MiddleName;
        entity.Palname = dto.Palname;
        entity.CompanyName = dto.CompanyName;
        entity.ByCompname = dto.ByCompname;
        entity.Paaddress = dto.Paaddress;
        entity.MvType = dto.MvType;
        entity.VehicleClass = dto.VehicleClass;
        entity.PlateNo = dto.PlateNo;
        entity.SerialNo = dto.SerialNo;
        entity.MotorNo = dto.MotorNo;
        entity.SeatingCapacity = dto.SeatingCapacity;
        entity.ModelYr = dto.ModelYr;
        entity.CoverageYr = dto.CoverageYr;
        entity.Make = dto.Make;
        entity.Series = dto.Series;
        entity.ServiceType = dto.ServiceType;
        entity.Color = dto.Color;
        entity.UnWeight = dto.UnWeight;
        entity.AssuredTin = dto.AssuredTin;
        entity.InsuredFrom = dto.InsuredFrom;
        entity.InsuredTo = dto.InsuredTo;
        entity.Remarks = dto.Remarks;
        entity.TaxType = dto.TaxType;
        entity.PlaceIssued = dto.PlaceIssued;
        entity.MvFileno = dto.MvFileno;
        entity.Paregister = dto.Paregister;
        entity.CompId = dto.CompId;
        entity.BltFileno = dto.BltFileno;
        entity.BusProf = dto.BusProf;
        entity.NoDays = dto.NoDays;
        entity.ProRata = dto.ProRata;
        entity.Fleet = dto.Fleet;
        entity.Fuel = dto.Fuel;
        entity.Branch = dto.Branch;
        entity.NonLto = dto.NonLto;
        entity.VehicleType = dto.VehicleType;
        entity.TypeBody = dto.TypeBody;
        entity.UploadedCode = dto.UploadedCode;
        entity.UploadedDate = dto.UploadedDate;
        entity.RiskCode = dto.RiskCode;
        entity.ConductionSticker = dto.ConductionSticker;
        entity.MarketSegment = dto.MarketSegment;
        AfterCopyMPaip(dto, entity);
      }
      
      public static MPaipDto AsDto(this MPaip entity)
      {
        MPaipDto dto = new MPaipDto();
        CopyMPaip(entity, dto);
        return dto;
      }
      
      public static MPaip CopyTo(this MPaipDto source, MPaip entity)
      {
        CopyMPaip(source, entity);
        return entity;
      }

      static partial void BeforeCopyTBillchrgh(TBillchrgh entity, TBillchrghDto dto);
      static partial void AfterCopyTBillchrgh(TBillchrgh entity, TBillchrghDto dto);
      static partial void BeforeCopyTBillchrgh(TBillchrghDto dto, TBillchrgh entity);
      static partial void AfterCopyTBillchrgh(TBillchrghDto dto, TBillchrgh entity);
      
      private static void CopyTBillchrgh(TBillchrgh entity, TBillchrghDto dto)
      {
        BeforeCopyTBillchrgh(entity, dto);
        CopyLSMAuthenticationDtoBase(entity, dto);
        dto.Bchchrgno = entity.Bchchrgno;
        dto.Papin = entity.Papin;
        dto.Trkid = entity.Trkid;
        dto.Bchdte = entity.Bchdte;
        dto.Usrid = entity.Usrid;
        dto.Pkcd = entity.Pkcd;
        dto.UploadedCode = entity.UploadedCode;
        dto.UploadedDate = entity.UploadedDate;
        AfterCopyTBillchrgh(entity, dto);
      }
      
      private static void CopyTBillchrgh(TBillchrghDto dto, TBillchrgh entity)
      {
        BeforeCopyTBillchrgh(dto, entity);
        CopyLSMAuthenticationDtoBase(dto, entity);
        entity.Bchchrgno = dto.Bchchrgno;
        entity.Papin = dto.Papin;
        entity.Trkid = dto.Trkid;
        entity.Bchdte = dto.Bchdte;
        entity.Usrid = dto.Usrid;
        entity.Pkcd = dto.Pkcd;
        entity.UploadedCode = dto.UploadedCode;
        entity.UploadedDate = dto.UploadedDate;
        AfterCopyTBillchrgh(dto, entity);
      }
      
      public static TBillchrghDto AsDto(this TBillchrgh entity)
      {
        TBillchrghDto dto = new TBillchrghDto();
        CopyTBillchrgh(entity, dto);
        return dto;
      }
      
      public static TBillchrgh CopyTo(this TBillchrghDto source, TBillchrgh entity)
      {
        CopyTBillchrgh(source, entity);
        return entity;
      }

      static partial void BeforeCopyTBillchrgd(TBillchrgd entity, TBillchrgdDto dto);
      static partial void AfterCopyTBillchrgd(TBillchrgd entity, TBillchrgdDto dto);
      static partial void BeforeCopyTBillchrgd(TBillchrgdDto dto, TBillchrgd entity);
      static partial void AfterCopyTBillchrgd(TBillchrgdDto dto, TBillchrgd entity);
      
      private static void CopyTBillchrgd(TBillchrgd entity, TBillchrgdDto dto)
      {
        BeforeCopyTBillchrgd(entity, dto);
        CopyLSMAuthenticationDtoBase(entity, dto);
        dto.Bchchrgno = entity.Bchchrgno;
        dto.Bcdseries = entity.Bcdseries;
        dto.Bcditmcd = entity.Bcditmcd;
        dto.Bcdesc = entity.Bcdesc;
        dto.Bcdqty = entity.Bcdqty;
        dto.Bcdsp = entity.Bcdsp;
        dto.Bcdpatcover = entity.Bcdpatcover;
        dto.Bcdpatbal = entity.Bcdpatbal;
        dto.Bcdtppcover = entity.Bcdtppcover;
        dto.Disccd = entity.Disccd;
        dto.Tpcd = entity.Tpcd;
        dto.Bcdtpptag = entity.Bcdtpptag;
        dto.Colornum = entity.Colornum;
        dto.Bcdsino = entity.Bcdsino;
        dto.Bcdtppbal = entity.Bcdtppbal;
        dto.DocStamp = entity.DocStamp;
        dto.EVat = entity.EVat;
        dto.Lgt = entity.Lgt;
        dto.SumInsired = entity.SumInsired;
        dto.CompFee = entity.CompFee;
        dto.CertFee = entity.CertFee;
        dto.BasicPremium = entity.BasicPremium;
        dto.DocOr = entity.DocOr;
        dto.Coi = entity.Coi;
        dto.Commission = entity.Commission;
        dto.AuthenCode = entity.AuthenCode;
        dto.TaxAmt = entity.TaxAmt;
        dto.WithCom = entity.WithCom;
        dto.WTax = entity.WTax;
        dto.WTaxNet = entity.WTaxNet;
        dto.NoDays = entity.NoDays;
        dto.ProRata = entity.ProRata;
        dto.RegType = entity.RegType;
        dto.TransType = entity.TransType;
        dto.Region = entity.Region;
        dto.EndoNo = entity.EndoNo;
        dto.UploadedCode = entity.UploadedCode;
        dto.UploadedDate = entity.UploadedDate;
        dto.LtfrbDcode = entity.LtfrbDcode;
        dto.LtfrbDdate = entity.LtfrbDdate;
        dto.VehicleNumber = entity.VehicleNumber;
        dto.Refund = entity.Refund;
        dto.OthChrges = entity.OthChrges;
        dto.Taxes = entity.Taxes;
        dto.CanPolicy = entity.CanPolicy;
        dto.DateCancel = entity.DateCancel;
        dto.CanUser = entity.CanUser;
        dto.Prnt = entity.Prnt;
        dto.DatePrinted = entity.DatePrinted;
        dto.RefNum = entity.RefNum;
        dto.Datepaid = entity.Datepaid;
        dto.VehicleCode = entity.VehicleCode;
        dto.CompShare = entity.CompShare;
        dto.TppShare = entity.TppShare;
        dto.QrImage = entity.QrImage;
        dto.Ctpl = entity.Ctpl;
        dto.Pl = entity.Pl;
        dto.AuthenFee = entity.AuthenFee;
        dto.Municipality = entity.Municipality;
        dto.CocSeries = entity.CocSeries;
        dto.BayadCenter = entity.BayadCenter;
        dto.RiskCode = entity.RiskCode;
        dto.LgtRate = entity.LgtRate;
        dto.InceptionFrom = entity.InceptionFrom;
        dto.InceptionTo = entity.InceptionTo;
        dto.ChargesOr = entity.ChargesOr;
        dto.WTaxShare = entity.WTaxShare;
        dto.WithClaims = entity.WithClaims;
        dto.ClaimBranch = entity.ClaimBranch;
        dto.AgentOr = entity.AgentOr;
        dto.AgentOrDate = entity.AgentOrDate;
        dto.AgentOrAmount = entity.AgentOrAmount;
        dto.BatchCode = entity.BatchCode;
        dto.AuthenticationMessage = entity.AuthenticationMessage;
        dto.AuthenStatus = entity.AuthenStatus;
        AfterCopyTBillchrgd(entity, dto);
      }
      
      private static void CopyTBillchrgd(TBillchrgdDto dto, TBillchrgd entity)
      {
        BeforeCopyTBillchrgd(dto, entity);
        CopyLSMAuthenticationDtoBase(dto, entity);
        entity.Bchchrgno = dto.Bchchrgno;
        entity.Bcdseries = dto.Bcdseries;
        entity.Bcditmcd = dto.Bcditmcd;
        entity.Bcdesc = dto.Bcdesc;
        entity.Bcdqty = dto.Bcdqty;
        entity.Bcdsp = dto.Bcdsp;
        entity.Bcdpatcover = dto.Bcdpatcover;
        entity.Bcdpatbal = dto.Bcdpatbal;
        entity.Bcdtppcover = dto.Bcdtppcover;
        entity.Disccd = dto.Disccd;
        entity.Tpcd = dto.Tpcd;
        entity.Bcdtpptag = dto.Bcdtpptag;
        entity.Colornum = dto.Colornum;
        entity.Bcdsino = dto.Bcdsino;
        entity.Bcdtppbal = dto.Bcdtppbal;
        entity.DocStamp = dto.DocStamp;
        entity.EVat = dto.EVat;
        entity.Lgt = dto.Lgt;
        entity.SumInsired = dto.SumInsired;
        entity.CompFee = dto.CompFee;
        entity.CertFee = dto.CertFee;
        entity.BasicPremium = dto.BasicPremium;
        entity.DocOr = dto.DocOr;
        entity.Coi = dto.Coi;
        entity.Commission = dto.Commission;
        entity.AuthenCode = dto.AuthenCode;
        entity.TaxAmt = dto.TaxAmt;
        entity.WithCom = dto.WithCom;
        entity.WTax = dto.WTax;
        entity.WTaxNet = dto.WTaxNet;
        entity.NoDays = dto.NoDays;
        entity.ProRata = dto.ProRata;
        entity.RegType = dto.RegType;
        entity.TransType = dto.TransType;
        entity.Region = dto.Region;
        entity.EndoNo = dto.EndoNo;
        entity.UploadedCode = dto.UploadedCode;
        entity.UploadedDate = dto.UploadedDate;
        entity.LtfrbDcode = dto.LtfrbDcode;
        entity.LtfrbDdate = dto.LtfrbDdate;
        entity.VehicleNumber = dto.VehicleNumber;
        entity.Refund = dto.Refund;
        entity.OthChrges = dto.OthChrges;
        entity.Taxes = dto.Taxes;
        entity.CanPolicy = dto.CanPolicy;
        entity.DateCancel = dto.DateCancel;
        entity.CanUser = dto.CanUser;
        entity.Prnt = dto.Prnt;
        entity.DatePrinted = dto.DatePrinted;
        entity.RefNum = dto.RefNum;
        entity.Datepaid = dto.Datepaid;
        entity.VehicleCode = dto.VehicleCode;
        entity.CompShare = dto.CompShare;
        entity.TppShare = dto.TppShare;
        entity.QrImage = dto.QrImage;
        entity.Ctpl = dto.Ctpl;
        entity.Pl = dto.Pl;
        entity.AuthenFee = dto.AuthenFee;
        entity.Municipality = dto.Municipality;
        entity.CocSeries = dto.CocSeries;
        entity.BayadCenter = dto.BayadCenter;
        entity.RiskCode = dto.RiskCode;
        entity.LgtRate = dto.LgtRate;
        entity.InceptionFrom = dto.InceptionFrom;
        entity.InceptionTo = dto.InceptionTo;
        entity.ChargesOr = dto.ChargesOr;
        entity.WTaxShare = dto.WTaxShare;
        entity.WithClaims = dto.WithClaims;
        entity.ClaimBranch = dto.ClaimBranch;
        entity.AgentOr = dto.AgentOr;
        entity.AgentOrDate = dto.AgentOrDate;
        entity.AgentOrAmount = dto.AgentOrAmount;
        entity.BatchCode = dto.BatchCode;
        entity.AuthenticationMessage = dto.AuthenticationMessage;
        entity.AuthenStatus = dto.AuthenStatus;
        AfterCopyTBillchrgd(dto, entity);
      }
      
      public static TBillchrgdDto AsDto(this TBillchrgd entity)
      {
        TBillchrgdDto dto = new TBillchrgdDto();
        CopyTBillchrgd(entity, dto);
        return dto;
      }
      
      public static TBillchrgd CopyTo(this TBillchrgdDto source, TBillchrgd entity)
      {
        CopyTBillchrgd(source, entity);
        return entity;
      }

      static partial void BeforeCopyTblBilldhist(TblBilldhist entity, TblBilldhistDto dto);
      static partial void AfterCopyTblBilldhist(TblBilldhist entity, TblBilldhistDto dto);
      static partial void BeforeCopyTblBilldhist(TblBilldhistDto dto, TblBilldhist entity);
      static partial void AfterCopyTblBilldhist(TblBilldhistDto dto, TblBilldhist entity);
      
      private static void CopyTblBilldhist(TblBilldhist entity, TblBilldhistDto dto)
      {
        BeforeCopyTblBilldhist(entity, dto);
        CopyLSMAuthenticationDtoBase(entity, dto);
        dto.Coi = entity.Coi;
        dto.AuthenCode = entity.AuthenCode;
        dto.AuthenticationMessage = entity.AuthenticationMessage;
        dto.DateTrans = entity.DateTrans;
        AfterCopyTblBilldhist(entity, dto);
      }
      
      private static void CopyTblBilldhist(TblBilldhistDto dto, TblBilldhist entity)
      {
        BeforeCopyTblBilldhist(dto, entity);
        CopyLSMAuthenticationDtoBase(dto, entity);
        entity.Coi = dto.Coi;
        entity.AuthenCode = dto.AuthenCode;
        entity.AuthenticationMessage = dto.AuthenticationMessage;
        entity.DateTrans = dto.DateTrans;
        AfterCopyTblBilldhist(dto, entity);
      }
      
      public static TblBilldhistDto AsDto(this TblBilldhist entity)
      {
        TblBilldhistDto dto = new TblBilldhistDto();
        CopyTblBilldhist(entity, dto);
        return dto;
      }
      
      public static TblBilldhist CopyTo(this TblBilldhistDto source, TblBilldhist entity)
      {
        CopyTblBilldhist(source, entity);
        return entity;
      }


    }

  }

#endif
}
