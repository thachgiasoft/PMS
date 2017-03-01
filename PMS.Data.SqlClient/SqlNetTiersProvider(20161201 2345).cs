#region Using directives

using System;
using System.Collections;
using System.Collections.Specialized;


using System.Web.Configuration;
using System.Data;
using System.Data.Common;
using System.Configuration.Provider;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;

#endregion

namespace PMS.Data.SqlClient
{
	/// <summary>
	/// This class is the Sql implementation of the NetTiersProvider.
	/// </summary>
	public sealed class SqlNetTiersProvider : PMS.Data.Bases.NetTiersProvider
	{
		private static object syncRoot = new Object();
		private string _applicationName;
        private string _connectionString;
        private bool _useStoredProcedure;
        string _providerInvariantName;
		
		/// <summary>
		/// Initializes a new instance of the <see cref="SqlNetTiersProvider"/> class.
		///</summary>
		public SqlNetTiersProvider()
		{	
		}		
		
            public static string DecodeString(string s)
        {
            string result = string.Empty;
            if (s == string.Empty) return string.Empty;
            for (int i = 0; i < s.Length; i += 16)
            {
                string temp = string.Empty;
                for (int j = 0; j < 16; j++)
                {
                    temp += s[i + j].ToString();
                }
                result += ConvertFromBinaryToCharacter(temp);
            }
            return result;
        }

        private static string ConvertFromBinaryToCharacter(string b)
        {
            double result = 0;
            for (int i = 0; i < 16; i++)
            {
                if (b[i] == '1') result += Math.Pow(2, 15 - i);
            }
            return Convert.ToChar(Convert.ToInt32(result)).ToString();
        }
        
		/// <summary>
        /// Initializes the provider.
        /// </summary>
        /// <param name="name">The friendly name of the provider.</param>
        /// <param name="config">A collection of the name/value pairs representing the provider-specific attributes specified in the configuration for this provider.</param>
        /// <exception cref="T:System.ArgumentNullException">The name of the provider is null.</exception>
        /// <exception cref="T:System.InvalidOperationException">An attempt is made to call <see cref="M:System.Configuration.Provider.ProviderBase.Initialize(System.String,System.Collections.Specialized.NameValueCollection)"></see> on a provider after the provider has already been initialized.</exception>
        /// <exception cref="T:System.ArgumentException">The name of the provider has a length of zero.</exception>
		public override void Initialize(string name, NameValueCollection config)
        {
            // Verify that config isn't null
            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            // Assign the provider a default name if it doesn't have one
            if (String.IsNullOrEmpty(name))
            {
                name = "SqlNetTiersProvider";
            }

            // Add a default "description" attribute to config if the
            // attribute doesn't exist or is empty
            if (string.IsNullOrEmpty(config["description"]))
            {
                config.Remove("description");
                config.Add("description", "NetTiers Sql provider");
            }

            // Call the base class's Initialize method
            base.Initialize(name, config);

            // Initialize _applicationName
            _applicationName = config["applicationName"];

            if (string.IsNullOrEmpty(_applicationName))
            {
                _applicationName = "/";
            }
            config.Remove("applicationName");


            #region "Initialize UseStoredProcedure"
            string storedProcedure  = config["useStoredProcedure"];
           	if (string.IsNullOrEmpty(storedProcedure))
            {
                throw new ProviderException("Empty or missing useStoredProcedure");
            }
            this._useStoredProcedure = Convert.ToBoolean(config["useStoredProcedure"]);
            config.Remove("useStoredProcedure");
            #endregion

			#region ConnectionString

			// Initialize _connectionString
			_connectionString = config["connectionString"];
			config.Remove("connectionString");

			string connect = config["connectionStringName"];
			config.Remove("connectionStringName");

			if ( String.IsNullOrEmpty(_connectionString) )
			{
				if ( String.IsNullOrEmpty(connect) )
				{
					throw new ProviderException("Empty or missing connectionStringName");
				}

				if ( DataRepository.ConnectionStrings[connect] == null )
				{
					throw new ProviderException("Missing connection string");
				}

				 //_connectionString = DataRepository.ConnectionStrings[connect].ConnectionString;
                try
                {
                    bool flag = false;
                    foreach (char c in DataRepository.ConnectionStrings[connect].ConnectionString)
                    {
                        if (c != '0' && c != '1')//Mã hoá cũ: bit 01
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag)
                        _connectionString = CipherLib.PSCExtensions.DecodeString(DataRepository.ConnectionStrings[connect].ConnectionString) + ";Max Pool Size=1000";
                    else
                        _connectionString = DecodeString(DataRepository.ConnectionStrings[connect].ConnectionString);

                }
                catch
                {
                    _connectionString = DataRepository.ConnectionStrings[connect].ConnectionString;
                }
			}

            if ( String.IsNullOrEmpty(_connectionString) )
            {
                throw new ProviderException("Empty connection string");
			}

			#endregion
            
             #region "_providerInvariantName"

            // initialize _providerInvariantName
            this._providerInvariantName = config["providerInvariantName"];

            if (String.IsNullOrEmpty(_providerInvariantName))
            {
                throw new ProviderException("Empty or missing providerInvariantName");
            }
            config.Remove("providerInvariantName");

            #endregion

        }
		
		/// <summary>
		/// Creates a new <see cref="TransactionManager"/> instance from the current datasource.
		/// </summary>
		/// <returns></returns>
		public override TransactionManager CreateTransaction()
		{
			return new TransactionManager(this._connectionString);
		}
		
		/// <summary>
		/// Gets a value indicating whether to use stored procedure or not.
		/// </summary>
		/// <value>
		/// 	<c>true</c> if this repository use stored procedures; otherwise, <c>false</c>.
		/// </value>
		public bool UseStoredProcedure
		{
			get {return this._useStoredProcedure;}
			set {this._useStoredProcedure = value;}
		}
		
		 /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        /// <value>The connection string.</value>
		public string ConnectionString
		{
			get {return this._connectionString;}
			set {this._connectionString = value;}
		}
		
		/// <summary>
	    /// Gets or sets the invariant provider name listed in the DbProviderFactories machine.config section.
	    /// </summary>
	    /// <value>The name of the provider invariant.</value>
	    public string ProviderInvariantName
	    {
	        get { return this._providerInvariantName; }
	        set { this._providerInvariantName = value; }
	    }		
		
		///<summary>
		/// Indicates if the current <see cref="NetTiersProvider"/> implementation supports Transacton.
		///</summary>
		public override bool IsTransactionSupported
		{
			get
			{
				return true;
			}
		}

		
		#region "BangPhuTroiGioDayGiangVienProvider"
			
		private SqlBangPhuTroiGioDayGiangVienProvider innerSqlBangPhuTroiGioDayGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="BangPhuTroiGioDayGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override BangPhuTroiGioDayGiangVienProviderBase BangPhuTroiGioDayGiangVienProvider
		{
			get
			{
				if (innerSqlBangPhuTroiGioDayGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlBangPhuTroiGioDayGiangVienProvider == null)
						{
							this.innerSqlBangPhuTroiGioDayGiangVienProvider = new SqlBangPhuTroiGioDayGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlBangPhuTroiGioDayGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlBangPhuTroiGioDayGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlBangPhuTroiGioDayGiangVienProvider SqlBangPhuTroiGioDayGiangVienProvider
		{
			get {return BangPhuTroiGioDayGiangVienProvider as SqlBangPhuTroiGioDayGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "DanhMucGioGiangProvider"
			
		private SqlDanhMucGioGiangProvider innerSqlDanhMucGioGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DanhMucGioGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DanhMucGioGiangProviderBase DanhMucGioGiangProvider
		{
			get
			{
				if (innerSqlDanhMucGioGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDanhMucGioGiangProvider == null)
						{
							this.innerSqlDanhMucGioGiangProvider = new SqlDanhMucGioGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDanhMucGioGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDanhMucGioGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDanhMucGioGiangProvider SqlDanhMucGioGiangProvider
		{
			get {return DanhMucGioGiangProvider as SqlDanhMucGioGiangProvider;}
		}
		
		#endregion
		
		
		#region "TcbKetQuaQuyDoiProvider"
			
		private SqlTcbKetQuaQuyDoiProvider innerSqlTcbKetQuaQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TcbKetQuaQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TcbKetQuaQuyDoiProviderBase TcbKetQuaQuyDoiProvider
		{
			get
			{
				if (innerSqlTcbKetQuaQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTcbKetQuaQuyDoiProvider == null)
						{
							this.innerSqlTcbKetQuaQuyDoiProvider = new SqlTcbKetQuaQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTcbKetQuaQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTcbKetQuaQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTcbKetQuaQuyDoiProvider SqlTcbKetQuaQuyDoiProvider
		{
			get {return TcbKetQuaQuyDoiProvider as SqlTcbKetQuaQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "MucDoHoanThanhNckhProvider"
			
		private SqlMucDoHoanThanhNckhProvider innerSqlMucDoHoanThanhNckhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MucDoHoanThanhNckh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MucDoHoanThanhNckhProviderBase MucDoHoanThanhNckhProvider
		{
			get
			{
				if (innerSqlMucDoHoanThanhNckhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMucDoHoanThanhNckhProvider == null)
						{
							this.innerSqlMucDoHoanThanhNckhProvider = new SqlMucDoHoanThanhNckhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMucDoHoanThanhNckhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMucDoHoanThanhNckhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMucDoHoanThanhNckhProvider SqlMucDoHoanThanhNckhProvider
		{
			get {return MucDoHoanThanhNckhProvider as SqlMucDoHoanThanhNckhProvider;}
		}
		
		#endregion
		
		
		#region "MonKhongTinhProvider"
			
		private SqlMonKhongTinhProvider innerSqlMonKhongTinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonKhongTinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonKhongTinhProviderBase MonKhongTinhProvider
		{
			get
			{
				if (innerSqlMonKhongTinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonKhongTinhProvider == null)
						{
							this.innerSqlMonKhongTinhProvider = new SqlMonKhongTinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonKhongTinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonKhongTinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonKhongTinhProvider SqlMonKhongTinhProvider
		{
			get {return MonKhongTinhProvider as SqlMonKhongTinhProvider;}
		}
		
		#endregion
		
		
		#region "QuyDinhTienCanTrenProvider"
			
		private SqlQuyDinhTienCanTrenProvider innerSqlQuyDinhTienCanTrenProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="QuyDinhTienCanTren"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override QuyDinhTienCanTrenProviderBase QuyDinhTienCanTrenProvider
		{
			get
			{
				if (innerSqlQuyDinhTienCanTrenProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlQuyDinhTienCanTrenProvider == null)
						{
							this.innerSqlQuyDinhTienCanTrenProvider = new SqlQuyDinhTienCanTrenProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlQuyDinhTienCanTrenProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlQuyDinhTienCanTrenProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlQuyDinhTienCanTrenProvider SqlQuyDinhTienCanTrenProvider
		{
			get {return QuyDinhTienCanTrenProvider as SqlQuyDinhTienCanTrenProvider;}
		}
		
		#endregion
		
		
		#region "NamHocProvider"
			
		private SqlNamHocProvider innerSqlNamHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NamHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NamHocProviderBase NamHocProvider
		{
			get
			{
				if (innerSqlNamHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNamHocProvider == null)
						{
							this.innerSqlNamHocProvider = new SqlNamHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNamHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNamHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNamHocProvider SqlNamHocProvider
		{
			get {return NamHocProvider as SqlNamHocProvider;}
		}
		
		#endregion
		
		
		#region "NgonNguGiangDayProvider"
			
		private SqlNgonNguGiangDayProvider innerSqlNgonNguGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NgonNguGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NgonNguGiangDayProviderBase NgonNguGiangDayProvider
		{
			get
			{
				if (innerSqlNgonNguGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNgonNguGiangDayProvider == null)
						{
							this.innerSqlNgonNguGiangDayProvider = new SqlNgonNguGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNgonNguGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNgonNguGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNgonNguGiangDayProvider SqlNgonNguGiangDayProvider
		{
			get {return NgonNguGiangDayProvider as SqlNgonNguGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "MonHocKhongTinhKhoiLuongProvider"
			
		private SqlMonHocKhongTinhKhoiLuongProvider innerSqlMonHocKhongTinhKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonHocKhongTinhKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonHocKhongTinhKhoiLuongProviderBase MonHocKhongTinhKhoiLuongProvider
		{
			get
			{
				if (innerSqlMonHocKhongTinhKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonHocKhongTinhKhoiLuongProvider == null)
						{
							this.innerSqlMonHocKhongTinhKhoiLuongProvider = new SqlMonHocKhongTinhKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonHocKhongTinhKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonHocKhongTinhKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonHocKhongTinhKhoiLuongProvider SqlMonHocKhongTinhKhoiLuongProvider
		{
			get {return MonHocKhongTinhKhoiLuongProvider as SqlMonHocKhongTinhKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "NghienCuuKhoaHocProvider"
			
		private SqlNghienCuuKhoaHocProvider innerSqlNghienCuuKhoaHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NghienCuuKhoaHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NghienCuuKhoaHocProviderBase NghienCuuKhoaHocProvider
		{
			get
			{
				if (innerSqlNghienCuuKhoaHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNghienCuuKhoaHocProvider == null)
						{
							this.innerSqlNghienCuuKhoaHocProvider = new SqlNghienCuuKhoaHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNghienCuuKhoaHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNghienCuuKhoaHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNghienCuuKhoaHocProvider SqlNghienCuuKhoaHocProvider
		{
			get {return NghienCuuKhoaHocProvider as SqlNghienCuuKhoaHocProvider;}
		}
		
		#endregion
		
		
		#region "PhanLoaiGiangVienProvider"
			
		private SqlPhanLoaiGiangVienProvider innerSqlPhanLoaiGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PhanLoaiGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PhanLoaiGiangVienProviderBase PhanLoaiGiangVienProvider
		{
			get
			{
				if (innerSqlPhanLoaiGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPhanLoaiGiangVienProvider == null)
						{
							this.innerSqlPhanLoaiGiangVienProvider = new SqlPhanLoaiGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPhanLoaiGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPhanLoaiGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPhanLoaiGiangVienProvider SqlPhanLoaiGiangVienProvider
		{
			get {return PhanLoaiGiangVienProvider as SqlPhanLoaiGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "NhomChucNangProvider"
			
		private SqlNhomChucNangProvider innerSqlNhomChucNangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NhomChucNang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NhomChucNangProviderBase NhomChucNangProvider
		{
			get
			{
				if (innerSqlNhomChucNangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNhomChucNangProvider == null)
						{
							this.innerSqlNhomChucNangProvider = new SqlNhomChucNangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNhomChucNangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNhomChucNangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNhomChucNangProvider SqlNhomChucNangProvider
		{
			get {return NhomChucNangProvider as SqlNhomChucNangProvider;}
		}
		
		#endregion
		
		
		#region "MonHocCoNganHangDeThiProvider"
			
		private SqlMonHocCoNganHangDeThiProvider innerSqlMonHocCoNganHangDeThiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonHocCoNganHangDeThi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonHocCoNganHangDeThiProviderBase MonHocCoNganHangDeThiProvider
		{
			get
			{
				if (innerSqlMonHocCoNganHangDeThiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonHocCoNganHangDeThiProvider == null)
						{
							this.innerSqlMonHocCoNganHangDeThiProvider = new SqlMonHocCoNganHangDeThiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonHocCoNganHangDeThiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonHocCoNganHangDeThiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonHocCoNganHangDeThiProvider SqlMonHocCoNganHangDeThiProvider
		{
			get {return MonHocCoNganHangDeThiProvider as SqlMonHocCoNganHangDeThiProvider;}
		}
		
		#endregion
		
		
		#region "NhomKhoiLuongProvider"
			
		private SqlNhomKhoiLuongProvider innerSqlNhomKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NhomKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NhomKhoiLuongProviderBase NhomKhoiLuongProvider
		{
			get
			{
				if (innerSqlNhomKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNhomKhoiLuongProvider == null)
						{
							this.innerSqlNhomKhoiLuongProvider = new SqlNhomKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNhomKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNhomKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNhomKhoiLuongProvider SqlNhomKhoiLuongProvider
		{
			get {return NhomKhoiLuongProvider as SqlNhomKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "MonThucTapTotNghiepProvider"
			
		private SqlMonThucTapTotNghiepProvider innerSqlMonThucTapTotNghiepProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonThucTapTotNghiep"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonThucTapTotNghiepProviderBase MonThucTapTotNghiepProvider
		{
			get
			{
				if (innerSqlMonThucTapTotNghiepProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonThucTapTotNghiepProvider == null)
						{
							this.innerSqlMonThucTapTotNghiepProvider = new SqlMonThucTapTotNghiepProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonThucTapTotNghiepProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonThucTapTotNghiepProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonThucTapTotNghiepProvider SqlMonThucTapTotNghiepProvider
		{
			get {return MonThucTapTotNghiepProvider as SqlMonThucTapTotNghiepProvider;}
		}
		
		#endregion
		
		
		#region "NhomHoatDongNgoaiGiangDayProvider"
			
		private SqlNhomHoatDongNgoaiGiangDayProvider innerSqlNhomHoatDongNgoaiGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NhomHoatDongNgoaiGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NhomHoatDongNgoaiGiangDayProviderBase NhomHoatDongNgoaiGiangDayProvider
		{
			get
			{
				if (innerSqlNhomHoatDongNgoaiGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNhomHoatDongNgoaiGiangDayProvider == null)
						{
							this.innerSqlNhomHoatDongNgoaiGiangDayProvider = new SqlNhomHoatDongNgoaiGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNhomHoatDongNgoaiGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNhomHoatDongNgoaiGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNhomHoatDongNgoaiGiangDayProvider SqlNhomHoatDongNgoaiGiangDayProvider
		{
			get {return NhomHoatDongNgoaiGiangDayProvider as SqlNhomHoatDongNgoaiGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "NamHocHienThiThuLaoLenWebProvider"
			
		private SqlNamHocHienThiThuLaoLenWebProvider innerSqlNamHocHienThiThuLaoLenWebProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NamHocHienThiThuLaoLenWeb"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NamHocHienThiThuLaoLenWebProviderBase NamHocHienThiThuLaoLenWebProvider
		{
			get
			{
				if (innerSqlNamHocHienThiThuLaoLenWebProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNamHocHienThiThuLaoLenWebProvider == null)
						{
							this.innerSqlNamHocHienThiThuLaoLenWebProvider = new SqlNamHocHienThiThuLaoLenWebProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNamHocHienThiThuLaoLenWebProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNamHocHienThiThuLaoLenWebProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNamHocHienThiThuLaoLenWebProvider SqlNamHocHienThiThuLaoLenWebProvider
		{
			get {return NamHocHienThiThuLaoLenWebProvider as SqlNamHocHienThiThuLaoLenWebProvider;}
		}
		
		#endregion
		
		
		#region "MonXepLichChuNhatKhongTinhHeSoProvider"
			
		private SqlMonXepLichChuNhatKhongTinhHeSoProvider innerSqlMonXepLichChuNhatKhongTinhHeSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonXepLichChuNhatKhongTinhHeSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonXepLichChuNhatKhongTinhHeSoProviderBase MonXepLichChuNhatKhongTinhHeSoProvider
		{
			get
			{
				if (innerSqlMonXepLichChuNhatKhongTinhHeSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonXepLichChuNhatKhongTinhHeSoProvider == null)
						{
							this.innerSqlMonXepLichChuNhatKhongTinhHeSoProvider = new SqlMonXepLichChuNhatKhongTinhHeSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonXepLichChuNhatKhongTinhHeSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonXepLichChuNhatKhongTinhHeSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonXepLichChuNhatKhongTinhHeSoProvider SqlMonXepLichChuNhatKhongTinhHeSoProvider
		{
			get {return MonXepLichChuNhatKhongTinhHeSoProvider as SqlMonXepLichChuNhatKhongTinhHeSoProvider;}
		}
		
		#endregion
		
		
		#region "PhuCapHanhChinhProvider"
			
		private SqlPhuCapHanhChinhProvider innerSqlPhuCapHanhChinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PhuCapHanhChinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PhuCapHanhChinhProviderBase PhuCapHanhChinhProvider
		{
			get
			{
				if (innerSqlPhuCapHanhChinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPhuCapHanhChinhProvider == null)
						{
							this.innerSqlPhuCapHanhChinhProvider = new SqlPhuCapHanhChinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPhuCapHanhChinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPhuCapHanhChinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPhuCapHanhChinhProvider SqlPhuCapHanhChinhProvider
		{
			get {return PhuCapHanhChinhProvider as SqlPhuCapHanhChinhProvider;}
		}
		
		#endregion
		
		
		#region "PhanCongDoAnTotNghiepProvider"
			
		private SqlPhanCongDoAnTotNghiepProvider innerSqlPhanCongDoAnTotNghiepProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PhanCongDoAnTotNghiep"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PhanCongDoAnTotNghiepProviderBase PhanCongDoAnTotNghiepProvider
		{
			get
			{
				if (innerSqlPhanCongDoAnTotNghiepProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPhanCongDoAnTotNghiepProvider == null)
						{
							this.innerSqlPhanCongDoAnTotNghiepProvider = new SqlPhanCongDoAnTotNghiepProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPhanCongDoAnTotNghiepProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPhanCongDoAnTotNghiepProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPhanCongDoAnTotNghiepProvider SqlPhanCongDoAnTotNghiepProvider
		{
			get {return PhanCongDoAnTotNghiepProvider as SqlPhanCongDoAnTotNghiepProvider;}
		}
		
		#endregion
		
		
		#region "NoiDungDanhGiaProvider"
			
		private SqlNoiDungDanhGiaProvider innerSqlNoiDungDanhGiaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NoiDungDanhGia"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NoiDungDanhGiaProviderBase NoiDungDanhGiaProvider
		{
			get
			{
				if (innerSqlNoiDungDanhGiaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNoiDungDanhGiaProvider == null)
						{
							this.innerSqlNoiDungDanhGiaProvider = new SqlNoiDungDanhGiaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNoiDungDanhGiaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNoiDungDanhGiaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNoiDungDanhGiaProvider SqlNoiDungDanhGiaProvider
		{
			get {return NoiDungDanhGiaProvider as SqlNoiDungDanhGiaProvider;}
		}
		
		#endregion
		
		
		#region "NhomQuyenProvider"
			
		private SqlNhomQuyenProvider innerSqlNhomQuyenProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NhomQuyen"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NhomQuyenProviderBase NhomQuyenProvider
		{
			get
			{
				if (innerSqlNhomQuyenProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNhomQuyenProvider == null)
						{
							this.innerSqlNhomQuyenProvider = new SqlNhomQuyenProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNhomQuyenProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNhomQuyenProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNhomQuyenProvider SqlNhomQuyenProvider
		{
			get {return NhomQuyenProvider as SqlNhomQuyenProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoRaDeThiVhuexProvider"
			
		private SqlThuLaoRaDeThiVhuexProvider innerSqlThuLaoRaDeThiVhuexProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoRaDeThiVhuex"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoRaDeThiVhuexProviderBase ThuLaoRaDeThiVhuexProvider
		{
			get
			{
				if (innerSqlThuLaoRaDeThiVhuexProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoRaDeThiVhuexProvider == null)
						{
							this.innerSqlThuLaoRaDeThiVhuexProvider = new SqlThuLaoRaDeThiVhuexProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoRaDeThiVhuexProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoRaDeThiVhuexProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoRaDeThiVhuexProvider SqlThuLaoRaDeThiVhuexProvider
		{
			get {return ThuLaoRaDeThiVhuexProvider as SqlThuLaoRaDeThiVhuexProvider;}
		}
		
		#endregion
		
		
		#region "TrinhDoChinhTriProvider"
			
		private SqlTrinhDoChinhTriProvider innerSqlTrinhDoChinhTriProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrinhDoChinhTri"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrinhDoChinhTriProviderBase TrinhDoChinhTriProvider
		{
			get
			{
				if (innerSqlTrinhDoChinhTriProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrinhDoChinhTriProvider == null)
						{
							this.innerSqlTrinhDoChinhTriProvider = new SqlTrinhDoChinhTriProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrinhDoChinhTriProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTrinhDoChinhTriProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrinhDoChinhTriProvider SqlTrinhDoChinhTriProvider
		{
			get {return TrinhDoChinhTriProvider as SqlTrinhDoChinhTriProvider;}
		}
		
		#endregion
		
		
		#region "NhomMonHocProvider"
			
		private SqlNhomMonHocProvider innerSqlNhomMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NhomMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NhomMonHocProviderBase NhomMonHocProvider
		{
			get
			{
				if (innerSqlNhomMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNhomMonHocProvider == null)
						{
							this.innerSqlNhomMonHocProvider = new SqlNhomMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNhomMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNhomMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNhomMonHocProvider SqlNhomMonHocProvider
		{
			get {return NhomMonHocProvider as SqlNhomMonHocProvider;}
		}
		
		#endregion
		
		
		#region "PscUserConfigApplicationProvider"
			
		private SqlPscUserConfigApplicationProvider innerSqlPscUserConfigApplicationProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PscUserConfigApplication"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PscUserConfigApplicationProviderBase PscUserConfigApplicationProvider
		{
			get
			{
				if (innerSqlPscUserConfigApplicationProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPscUserConfigApplicationProvider == null)
						{
							this.innerSqlPscUserConfigApplicationProvider = new SqlPscUserConfigApplicationProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPscUserConfigApplicationProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPscUserConfigApplicationProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPscUserConfigApplicationProvider SqlPscUserConfigApplicationProvider
		{
			get {return PscUserConfigApplicationProvider as SqlPscUserConfigApplicationProvider;}
		}
		
		#endregion
		
		
		#region "TrinhDoNgoaiNguProvider"
			
		private SqlTrinhDoNgoaiNguProvider innerSqlTrinhDoNgoaiNguProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrinhDoNgoaiNgu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrinhDoNgoaiNguProviderBase TrinhDoNgoaiNguProvider
		{
			get
			{
				if (innerSqlTrinhDoNgoaiNguProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrinhDoNgoaiNguProvider == null)
						{
							this.innerSqlTrinhDoNgoaiNguProvider = new SqlTrinhDoNgoaiNguProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrinhDoNgoaiNguProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTrinhDoNgoaiNguProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrinhDoNgoaiNguProvider SqlTrinhDoNgoaiNguProvider
		{
			get {return TrinhDoNgoaiNguProvider as SqlTrinhDoNgoaiNguProvider;}
		}
		
		#endregion
		
		
		#region "PscDotThanhToanCoiThiChamThiProvider"
			
		private SqlPscDotThanhToanCoiThiChamThiProvider innerSqlPscDotThanhToanCoiThiChamThiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PscDotThanhToanCoiThiChamThi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PscDotThanhToanCoiThiChamThiProviderBase PscDotThanhToanCoiThiChamThiProvider
		{
			get
			{
				if (innerSqlPscDotThanhToanCoiThiChamThiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPscDotThanhToanCoiThiChamThiProvider == null)
						{
							this.innerSqlPscDotThanhToanCoiThiChamThiProvider = new SqlPscDotThanhToanCoiThiChamThiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPscDotThanhToanCoiThiChamThiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPscDotThanhToanCoiThiChamThiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPscDotThanhToanCoiThiChamThiProvider SqlPscDotThanhToanCoiThiChamThiProvider
		{
			get {return PscDotThanhToanCoiThiChamThiProvider as SqlPscDotThanhToanCoiThiChamThiProvider;}
		}
		
		#endregion
		
		
		#region "MonHocTinhHeSoKhoiNganhProvider"
			
		private SqlMonHocTinhHeSoKhoiNganhProvider innerSqlMonHocTinhHeSoKhoiNganhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonHocTinhHeSoKhoiNganh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonHocTinhHeSoKhoiNganhProviderBase MonHocTinhHeSoKhoiNganhProvider
		{
			get
			{
				if (innerSqlMonHocTinhHeSoKhoiNganhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonHocTinhHeSoKhoiNganhProvider == null)
						{
							this.innerSqlMonHocTinhHeSoKhoiNganhProvider = new SqlMonHocTinhHeSoKhoiNganhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonHocTinhHeSoKhoiNganhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonHocTinhHeSoKhoiNganhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonHocTinhHeSoKhoiNganhProvider SqlMonHocTinhHeSoKhoiNganhProvider
		{
			get {return MonHocTinhHeSoKhoiNganhProvider as SqlMonHocTinhHeSoKhoiNganhProvider;}
		}
		
		#endregion
		
		
		#region "QuocTichProvider"
			
		private SqlQuocTichProvider innerSqlQuocTichProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="QuocTich"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override QuocTichProviderBase QuocTichProvider
		{
			get
			{
				if (innerSqlQuocTichProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlQuocTichProvider == null)
						{
							this.innerSqlQuocTichProvider = new SqlQuocTichProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlQuocTichProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlQuocTichProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlQuocTichProvider SqlQuocTichProvider
		{
			get {return QuocTichProvider as SqlQuocTichProvider;}
		}
		
		#endregion
		
		
		#region "PscExBarCodesProvider"
			
		private SqlPscExBarCodesProvider innerSqlPscExBarCodesProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PscExBarCodes"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PscExBarCodesProviderBase PscExBarCodesProvider
		{
			get
			{
				if (innerSqlPscExBarCodesProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPscExBarCodesProvider == null)
						{
							this.innerSqlPscExBarCodesProvider = new SqlPscExBarCodesProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPscExBarCodesProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPscExBarCodesProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPscExBarCodesProvider SqlPscExBarCodesProvider
		{
			get {return PscExBarCodesProvider as SqlPscExBarCodesProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoCoiThiVhuexProvider"
			
		private SqlThuLaoCoiThiVhuexProvider innerSqlThuLaoCoiThiVhuexProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoCoiThiVhuex"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoCoiThiVhuexProviderBase ThuLaoCoiThiVhuexProvider
		{
			get
			{
				if (innerSqlThuLaoCoiThiVhuexProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoCoiThiVhuexProvider == null)
						{
							this.innerSqlThuLaoCoiThiVhuexProvider = new SqlThuLaoCoiThiVhuexProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoCoiThiVhuexProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoCoiThiVhuexProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoCoiThiVhuexProvider SqlThuLaoCoiThiVhuexProvider
		{
			get {return ThuLaoCoiThiVhuexProvider as SqlThuLaoCoiThiVhuexProvider;}
		}
		
		#endregion
		
		
		#region "PhanBienLuanAnProvider"
			
		private SqlPhanBienLuanAnProvider innerSqlPhanBienLuanAnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PhanBienLuanAn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PhanBienLuanAnProviderBase PhanBienLuanAnProvider
		{
			get
			{
				if (innerSqlPhanBienLuanAnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPhanBienLuanAnProvider == null)
						{
							this.innerSqlPhanBienLuanAnProvider = new SqlPhanBienLuanAnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPhanBienLuanAnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPhanBienLuanAnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPhanBienLuanAnProvider SqlPhanBienLuanAnProvider
		{
			get {return PhanBienLuanAnProvider as SqlPhanBienLuanAnProvider;}
		}
		
		#endregion
		
		
		#region "PhanNhomMonHocProvider"
			
		private SqlPhanNhomMonHocProvider innerSqlPhanNhomMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PhanNhomMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PhanNhomMonHocProviderBase PhanNhomMonHocProvider
		{
			get
			{
				if (innerSqlPhanNhomMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPhanNhomMonHocProvider == null)
						{
							this.innerSqlPhanNhomMonHocProvider = new SqlPhanNhomMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPhanNhomMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPhanNhomMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPhanNhomMonHocProvider SqlPhanNhomMonHocProvider
		{
			get {return PhanNhomMonHocProvider as SqlPhanNhomMonHocProvider;}
		}
		
		#endregion
		
		
		#region "MonTieuLuanProvider"
			
		private SqlMonTieuLuanProvider innerSqlMonTieuLuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonTieuLuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonTieuLuanProviderBase MonTieuLuanProvider
		{
			get
			{
				if (innerSqlMonTieuLuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonTieuLuanProvider == null)
						{
							this.innerSqlMonTieuLuanProvider = new SqlMonTieuLuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonTieuLuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonTieuLuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonTieuLuanProvider SqlMonTieuLuanProvider
		{
			get {return MonTieuLuanProvider as SqlMonTieuLuanProvider;}
		}
		
		#endregion
		
		
		#region "NoiDungCongViecQuanLyProvider"
			
		private SqlNoiDungCongViecQuanLyProvider innerSqlNoiDungCongViecQuanLyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NoiDungCongViecQuanLy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NoiDungCongViecQuanLyProviderBase NoiDungCongViecQuanLyProvider
		{
			get
			{
				if (innerSqlNoiDungCongViecQuanLyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNoiDungCongViecQuanLyProvider == null)
						{
							this.innerSqlNoiDungCongViecQuanLyProvider = new SqlNoiDungCongViecQuanLyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNoiDungCongViecQuanLyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNoiDungCongViecQuanLyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNoiDungCongViecQuanLyProvider SqlNoiDungCongViecQuanLyProvider
		{
			get {return NoiDungCongViecQuanLyProvider as SqlNoiDungCongViecQuanLyProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongGiangDayChiTietProvider"
			
		private SqlKhoiLuongGiangDayChiTietProvider innerSqlKhoiLuongGiangDayChiTietProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongGiangDayChiTiet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongGiangDayChiTietProviderBase KhoiLuongGiangDayChiTietProvider
		{
			get
			{
				if (innerSqlKhoiLuongGiangDayChiTietProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongGiangDayChiTietProvider == null)
						{
							this.innerSqlKhoiLuongGiangDayChiTietProvider = new SqlKhoiLuongGiangDayChiTietProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongGiangDayChiTietProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongGiangDayChiTietProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongGiangDayChiTietProvider SqlKhoiLuongGiangDayChiTietProvider
		{
			get {return KhoiLuongGiangDayChiTietProvider as SqlKhoiLuongGiangDayChiTietProvider;}
		}
		
		#endregion
		
		
		#region "LoaiKhoiLuongProvider"
			
		private SqlLoaiKhoiLuongProvider innerSqlLoaiKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LoaiKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LoaiKhoiLuongProviderBase LoaiKhoiLuongProvider
		{
			get
			{
				if (innerSqlLoaiKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLoaiKhoiLuongProvider == null)
						{
							this.innerSqlLoaiKhoiLuongProvider = new SqlLoaiKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLoaiKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLoaiKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLoaiKhoiLuongProvider SqlLoaiKhoiLuongProvider
		{
			get {return LoaiKhoiLuongProvider as SqlLoaiKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "MonTinhTheoQuyCheMoiProvider"
			
		private SqlMonTinhTheoQuyCheMoiProvider innerSqlMonTinhTheoQuyCheMoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonTinhTheoQuyCheMoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonTinhTheoQuyCheMoiProviderBase MonTinhTheoQuyCheMoiProvider
		{
			get
			{
				if (innerSqlMonTinhTheoQuyCheMoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonTinhTheoQuyCheMoiProvider == null)
						{
							this.innerSqlMonTinhTheoQuyCheMoiProvider = new SqlMonTinhTheoQuyCheMoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonTinhTheoQuyCheMoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonTinhTheoQuyCheMoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonTinhTheoQuyCheMoiProvider SqlMonTinhTheoQuyCheMoiProvider
		{
			get {return MonTinhTheoQuyCheMoiProvider as SqlMonTinhTheoQuyCheMoiProvider;}
		}
		
		#endregion
		
		
		#region "MonGiangMoiProvider"
			
		private SqlMonGiangMoiProvider innerSqlMonGiangMoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonGiangMoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonGiangMoiProviderBase MonGiangMoiProvider
		{
			get
			{
				if (innerSqlMonGiangMoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonGiangMoiProvider == null)
						{
							this.innerSqlMonGiangMoiProvider = new SqlMonGiangMoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonGiangMoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonGiangMoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonGiangMoiProvider SqlMonGiangMoiProvider
		{
			get {return MonGiangMoiProvider as SqlMonGiangMoiProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongHuongDanThucTapProvider"
			
		private SqlKhoiLuongHuongDanThucTapProvider innerSqlKhoiLuongHuongDanThucTapProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongHuongDanThucTap"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongHuongDanThucTapProviderBase KhoiLuongHuongDanThucTapProvider
		{
			get
			{
				if (innerSqlKhoiLuongHuongDanThucTapProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongHuongDanThucTapProvider == null)
						{
							this.innerSqlKhoiLuongHuongDanThucTapProvider = new SqlKhoiLuongHuongDanThucTapProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongHuongDanThucTapProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongHuongDanThucTapProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongHuongDanThucTapProvider SqlKhoiLuongHuongDanThucTapProvider
		{
			get {return KhoiLuongHuongDanThucTapProvider as SqlKhoiLuongHuongDanThucTapProvider;}
		}
		
		#endregion
		
		
		#region "LoaiNghienCuuKhoaHocProvider"
			
		private SqlLoaiNghienCuuKhoaHocProvider innerSqlLoaiNghienCuuKhoaHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LoaiNghienCuuKhoaHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LoaiNghienCuuKhoaHocProviderBase LoaiNghienCuuKhoaHocProvider
		{
			get
			{
				if (innerSqlLoaiNghienCuuKhoaHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLoaiNghienCuuKhoaHocProvider == null)
						{
							this.innerSqlLoaiNghienCuuKhoaHocProvider = new SqlLoaiNghienCuuKhoaHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLoaiNghienCuuKhoaHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLoaiNghienCuuKhoaHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLoaiNghienCuuKhoaHocProvider SqlLoaiNghienCuuKhoaHocProvider
		{
			get {return LoaiNghienCuuKhoaHocProvider as SqlLoaiNghienCuuKhoaHocProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongQuyDoiCaoDangProvider"
			
		private SqlKhoiLuongQuyDoiCaoDangProvider innerSqlKhoiLuongQuyDoiCaoDangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongQuyDoiCaoDang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongQuyDoiCaoDangProviderBase KhoiLuongQuyDoiCaoDangProvider
		{
			get
			{
				if (innerSqlKhoiLuongQuyDoiCaoDangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongQuyDoiCaoDangProvider == null)
						{
							this.innerSqlKhoiLuongQuyDoiCaoDangProvider = new SqlKhoiLuongQuyDoiCaoDangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongQuyDoiCaoDangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongQuyDoiCaoDangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongQuyDoiCaoDangProvider SqlKhoiLuongQuyDoiCaoDangProvider
		{
			get {return KhoiLuongQuyDoiCaoDangProvider as SqlKhoiLuongQuyDoiCaoDangProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongTamUngProvider"
			
		private SqlKhoiLuongTamUngProvider innerSqlKhoiLuongTamUngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongTamUng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongTamUngProviderBase KhoiLuongTamUngProvider
		{
			get
			{
				if (innerSqlKhoiLuongTamUngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongTamUngProvider == null)
						{
							this.innerSqlKhoiLuongTamUngProvider = new SqlKhoiLuongTamUngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongTamUngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongTamUngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongTamUngProvider SqlKhoiLuongTamUngProvider
		{
			get {return KhoiLuongTamUngProvider as SqlKhoiLuongTamUngProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongGiangDayTungTuanProvider"
			
		private SqlKhoiLuongGiangDayTungTuanProvider innerSqlKhoiLuongGiangDayTungTuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongGiangDayTungTuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongGiangDayTungTuanProviderBase KhoiLuongGiangDayTungTuanProvider
		{
			get
			{
				if (innerSqlKhoiLuongGiangDayTungTuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongGiangDayTungTuanProvider == null)
						{
							this.innerSqlKhoiLuongGiangDayTungTuanProvider = new SqlKhoiLuongGiangDayTungTuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongGiangDayTungTuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongGiangDayTungTuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongGiangDayTungTuanProvider SqlKhoiLuongGiangDayTungTuanProvider
		{
			get {return KhoiLuongGiangDayTungTuanProvider as SqlKhoiLuongGiangDayTungTuanProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongQuyDoiProvider"
			
		private SqlKhoiLuongQuyDoiProvider innerSqlKhoiLuongQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongQuyDoiProviderBase KhoiLuongQuyDoiProvider
		{
			get
			{
				if (innerSqlKhoiLuongQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongQuyDoiProvider == null)
						{
							this.innerSqlKhoiLuongQuyDoiProvider = new SqlKhoiLuongQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongQuyDoiProvider SqlKhoiLuongQuyDoiProvider
		{
			get {return KhoiLuongQuyDoiProvider as SqlKhoiLuongQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "LopHocPhanChuyenNganhProvider"
			
		private SqlLopHocPhanChuyenNganhProvider innerSqlLopHocPhanChuyenNganhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LopHocPhanChuyenNganh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LopHocPhanChuyenNganhProviderBase LopHocPhanChuyenNganhProvider
		{
			get
			{
				if (innerSqlLopHocPhanChuyenNganhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLopHocPhanChuyenNganhProvider == null)
						{
							this.innerSqlLopHocPhanChuyenNganhProvider = new SqlLopHocPhanChuyenNganhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLopHocPhanChuyenNganhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLopHocPhanChuyenNganhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLopHocPhanChuyenNganhProvider SqlLopHocPhanChuyenNganhProvider
		{
			get {return LopHocPhanChuyenNganhProvider as SqlLopHocPhanChuyenNganhProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongGiangDayDoAnTotNghiepProvider"
			
		private SqlKhoiLuongGiangDayDoAnTotNghiepProvider innerSqlKhoiLuongGiangDayDoAnTotNghiepProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongGiangDayDoAnTotNghiep"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongGiangDayDoAnTotNghiepProviderBase KhoiLuongGiangDayDoAnTotNghiepProvider
		{
			get
			{
				if (innerSqlKhoiLuongGiangDayDoAnTotNghiepProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongGiangDayDoAnTotNghiepProvider == null)
						{
							this.innerSqlKhoiLuongGiangDayDoAnTotNghiepProvider = new SqlKhoiLuongGiangDayDoAnTotNghiepProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongGiangDayDoAnTotNghiepProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongGiangDayDoAnTotNghiepProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongGiangDayDoAnTotNghiepProvider SqlKhoiLuongGiangDayDoAnTotNghiepProvider
		{
			get {return KhoiLuongGiangDayDoAnTotNghiepProvider as SqlKhoiLuongGiangDayDoAnTotNghiepProvider;}
		}
		
		#endregion
		
		
		#region "ThangHeProvider"
			
		private SqlThangHeProvider innerSqlThangHeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThangHe"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThangHeProviderBase ThangHeProvider
		{
			get
			{
				if (innerSqlThangHeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThangHeProvider == null)
						{
							this.innerSqlThangHeProvider = new SqlThangHeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThangHeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThangHeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThangHeProvider SqlThangHeProvider
		{
			get {return ThangHeProvider as SqlThangHeProvider;}
		}
		
		#endregion
		
		
		#region "KyTinhLuongProvider"
			
		private SqlKyTinhLuongProvider innerSqlKyTinhLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KyTinhLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KyTinhLuongProviderBase KyTinhLuongProvider
		{
			get
			{
				if (innerSqlKyTinhLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKyTinhLuongProvider == null)
						{
							this.innerSqlKyTinhLuongProvider = new SqlKyTinhLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKyTinhLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKyTinhLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKyTinhLuongProvider SqlKyTinhLuongProvider
		{
			get {return KyTinhLuongProvider as SqlKyTinhLuongProvider;}
		}
		
		#endregion
		
		
		#region "KetQuaDanhGiaVuotGioProvider"
			
		private SqlKetQuaDanhGiaVuotGioProvider innerSqlKetQuaDanhGiaVuotGioProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KetQuaDanhGiaVuotGio"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KetQuaDanhGiaVuotGioProviderBase KetQuaDanhGiaVuotGioProvider
		{
			get
			{
				if (innerSqlKetQuaDanhGiaVuotGioProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKetQuaDanhGiaVuotGioProvider == null)
						{
							this.innerSqlKetQuaDanhGiaVuotGioProvider = new SqlKetQuaDanhGiaVuotGioProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKetQuaDanhGiaVuotGioProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKetQuaDanhGiaVuotGioProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKetQuaDanhGiaVuotGioProvider SqlKetQuaDanhGiaVuotGioProvider
		{
			get {return KetQuaDanhGiaVuotGioProvider as SqlKetQuaDanhGiaVuotGioProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongDoAnTotNghiepChiTietProvider"
			
		private SqlKhoiLuongDoAnTotNghiepChiTietProvider innerSqlKhoiLuongDoAnTotNghiepChiTietProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongDoAnTotNghiepChiTiet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongDoAnTotNghiepChiTietProviderBase KhoiLuongDoAnTotNghiepChiTietProvider
		{
			get
			{
				if (innerSqlKhoiLuongDoAnTotNghiepChiTietProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongDoAnTotNghiepChiTietProvider == null)
						{
							this.innerSqlKhoiLuongDoAnTotNghiepChiTietProvider = new SqlKhoiLuongDoAnTotNghiepChiTietProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongDoAnTotNghiepChiTietProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongDoAnTotNghiepChiTietProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongDoAnTotNghiepChiTietProvider SqlKhoiLuongDoAnTotNghiepChiTietProvider
		{
			get {return KhoiLuongDoAnTotNghiepChiTietProvider as SqlKhoiLuongDoAnTotNghiepChiTietProvider;}
		}
		
		#endregion
		
		
		#region "MonPhanCongNhieuGiangVienProvider"
			
		private SqlMonPhanCongNhieuGiangVienProvider innerSqlMonPhanCongNhieuGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="MonPhanCongNhieuGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override MonPhanCongNhieuGiangVienProviderBase MonPhanCongNhieuGiangVienProvider
		{
			get
			{
				if (innerSqlMonPhanCongNhieuGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlMonPhanCongNhieuGiangVienProvider == null)
						{
							this.innerSqlMonPhanCongNhieuGiangVienProvider = new SqlMonPhanCongNhieuGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlMonPhanCongNhieuGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlMonPhanCongNhieuGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlMonPhanCongNhieuGiangVienProvider SqlMonPhanCongNhieuGiangVienProvider
		{
			get {return MonPhanCongNhieuGiangVienProvider as SqlMonPhanCongNhieuGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "KetQuaTinhTheoTuanProvider"
			
		private SqlKetQuaTinhTheoTuanProvider innerSqlKetQuaTinhTheoTuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KetQuaTinhTheoTuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KetQuaTinhTheoTuanProviderBase KetQuaTinhTheoTuanProvider
		{
			get
			{
				if (innerSqlKetQuaTinhTheoTuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKetQuaTinhTheoTuanProvider == null)
						{
							this.innerSqlKetQuaTinhTheoTuanProvider = new SqlKetQuaTinhTheoTuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKetQuaTinhTheoTuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKetQuaTinhTheoTuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKetQuaTinhTheoTuanProvider SqlKetQuaTinhTheoTuanProvider
		{
			get {return KetQuaTinhTheoTuanProvider as SqlKetQuaTinhTheoTuanProvider;}
		}
		
		#endregion
		
		
		#region "LopHocPhanBacDaoTaoProvider"
			
		private SqlLopHocPhanBacDaoTaoProvider innerSqlLopHocPhanBacDaoTaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LopHocPhanBacDaoTao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LopHocPhanBacDaoTaoProviderBase LopHocPhanBacDaoTaoProvider
		{
			get
			{
				if (innerSqlLopHocPhanBacDaoTaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLopHocPhanBacDaoTaoProvider == null)
						{
							this.innerSqlLopHocPhanBacDaoTaoProvider = new SqlLopHocPhanBacDaoTaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLopHocPhanBacDaoTaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLopHocPhanBacDaoTaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLopHocPhanBacDaoTaoProvider SqlLopHocPhanBacDaoTaoProvider
		{
			get {return LopHocPhanBacDaoTaoProvider as SqlLopHocPhanBacDaoTaoProvider;}
		}
		
		#endregion
		
		
		#region "KyThiProvider"
			
		private SqlKyThiProvider innerSqlKyThiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KyThi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KyThiProviderBase KyThiProvider
		{
			get
			{
				if (innerSqlKyThiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKyThiProvider == null)
						{
							this.innerSqlKyThiProvider = new SqlKyThiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKyThiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKyThiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKyThiProvider SqlKyThiProvider
		{
			get {return KyThiProvider as SqlKyThiProvider;}
		}
		
		#endregion
		
		
		#region "LyDoTamNghiProvider"
			
		private SqlLyDoTamNghiProvider innerSqlLyDoTamNghiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LyDoTamNghi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LyDoTamNghiProviderBase LyDoTamNghiProvider
		{
			get
			{
				if (innerSqlLyDoTamNghiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLyDoTamNghiProvider == null)
						{
							this.innerSqlLyDoTamNghiProvider = new SqlLyDoTamNghiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLyDoTamNghiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLyDoTamNghiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLyDoTamNghiProvider SqlLyDoTamNghiProvider
		{
			get {return LyDoTamNghiProvider as SqlLyDoTamNghiProvider;}
		}
		
		#endregion
		
		
		#region "LopHocPhanKhongTinhGioGiangProvider"
			
		private SqlLopHocPhanKhongTinhGioGiangProvider innerSqlLopHocPhanKhongTinhGioGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LopHocPhanKhongTinhGioGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LopHocPhanKhongTinhGioGiangProviderBase LopHocPhanKhongTinhGioGiangProvider
		{
			get
			{
				if (innerSqlLopHocPhanKhongTinhGioGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLopHocPhanKhongTinhGioGiangProvider == null)
						{
							this.innerSqlLopHocPhanKhongTinhGioGiangProvider = new SqlLopHocPhanKhongTinhGioGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLopHocPhanKhongTinhGioGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLopHocPhanKhongTinhGioGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLopHocPhanKhongTinhGioGiangProvider SqlLopHocPhanKhongTinhGioGiangProvider
		{
			get {return LopHocPhanKhongTinhGioGiangProvider as SqlLopHocPhanKhongTinhGioGiangProvider;}
		}
		
		#endregion
		
		
		#region "LopChatLuongCaoProvider"
			
		private SqlLopChatLuongCaoProvider innerSqlLopChatLuongCaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LopChatLuongCao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LopChatLuongCaoProviderBase LopChatLuongCaoProvider
		{
			get
			{
				if (innerSqlLopChatLuongCaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLopChatLuongCaoProvider == null)
						{
							this.innerSqlLopChatLuongCaoProvider = new SqlLopChatLuongCaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLopChatLuongCaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLopChatLuongCaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLopChatLuongCaoProvider SqlLopChatLuongCaoProvider
		{
			get {return LopChatLuongCaoProvider as SqlLopChatLuongCaoProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongGiangDayCaoDangProvider"
			
		private SqlKhoiLuongGiangDayCaoDangProvider innerSqlKhoiLuongGiangDayCaoDangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongGiangDayCaoDang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongGiangDayCaoDangProviderBase KhoiLuongGiangDayCaoDangProvider
		{
			get
			{
				if (innerSqlKhoiLuongGiangDayCaoDangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongGiangDayCaoDangProvider == null)
						{
							this.innerSqlKhoiLuongGiangDayCaoDangProvider = new SqlKhoiLuongGiangDayCaoDangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongGiangDayCaoDangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongGiangDayCaoDangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongGiangDayCaoDangProvider SqlKhoiLuongGiangDayCaoDangProvider
		{
			get {return KhoiLuongGiangDayCaoDangProvider as SqlKhoiLuongGiangDayCaoDangProvider;}
		}
		
		#endregion
		
		
		#region "PhanLoaiHocPhanProvider"
			
		private SqlPhanLoaiHocPhanProvider innerSqlPhanLoaiHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PhanLoaiHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PhanLoaiHocPhanProviderBase PhanLoaiHocPhanProvider
		{
			get
			{
				if (innerSqlPhanLoaiHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPhanLoaiHocPhanProvider == null)
						{
							this.innerSqlPhanLoaiHocPhanProvider = new SqlPhanLoaiHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPhanLoaiHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPhanLoaiHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPhanLoaiHocPhanProvider SqlPhanLoaiHocPhanProvider
		{
			get {return PhanLoaiHocPhanProvider as SqlPhanLoaiHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongGiangDayDoAnProvider"
			
		private SqlKhoiLuongGiangDayDoAnProvider innerSqlKhoiLuongGiangDayDoAnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongGiangDayDoAn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongGiangDayDoAnProviderBase KhoiLuongGiangDayDoAnProvider
		{
			get
			{
				if (innerSqlKhoiLuongGiangDayDoAnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongGiangDayDoAnProvider == null)
						{
							this.innerSqlKhoiLuongGiangDayDoAnProvider = new SqlKhoiLuongGiangDayDoAnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongGiangDayDoAnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongGiangDayDoAnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongGiangDayDoAnProvider SqlKhoiLuongGiangDayDoAnProvider
		{
			get {return KhoiLuongGiangDayDoAnProvider as SqlKhoiLuongGiangDayDoAnProvider;}
		}
		
		#endregion
		
		
		#region "LopHocPhanGiangBangTiengNuocNgoaiProvider"
			
		private SqlLopHocPhanGiangBangTiengNuocNgoaiProvider innerSqlLopHocPhanGiangBangTiengNuocNgoaiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LopHocPhanGiangBangTiengNuocNgoai"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LopHocPhanGiangBangTiengNuocNgoaiProviderBase LopHocPhanGiangBangTiengNuocNgoaiProvider
		{
			get
			{
				if (innerSqlLopHocPhanGiangBangTiengNuocNgoaiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLopHocPhanGiangBangTiengNuocNgoaiProvider == null)
						{
							this.innerSqlLopHocPhanGiangBangTiengNuocNgoaiProvider = new SqlLopHocPhanGiangBangTiengNuocNgoaiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLopHocPhanGiangBangTiengNuocNgoaiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLopHocPhanGiangBangTiengNuocNgoaiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLopHocPhanGiangBangTiengNuocNgoaiProvider SqlLopHocPhanGiangBangTiengNuocNgoaiProvider
		{
			get {return LopHocPhanGiangBangTiengNuocNgoaiProvider as SqlLopHocPhanGiangBangTiengNuocNgoaiProvider;}
		}
		
		#endregion
		
		
		#region "LoaiLopProvider"
			
		private SqlLoaiLopProvider innerSqlLoaiLopProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LoaiLop"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LoaiLopProviderBase LoaiLopProvider
		{
			get
			{
				if (innerSqlLoaiLopProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLoaiLopProvider == null)
						{
							this.innerSqlLoaiLopProvider = new SqlLoaiLopProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLoaiLopProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLoaiLopProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLoaiLopProvider SqlLoaiLopProvider
		{
			get {return LoaiLopProvider as SqlLoaiLopProvider;}
		}
		
		#endregion
		
		
		#region "ReportManagermentsProvider"
			
		private SqlReportManagermentsProvider innerSqlReportManagermentsProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ReportManagerments"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ReportManagermentsProviderBase ReportManagermentsProvider
		{
			get
			{
				if (innerSqlReportManagermentsProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlReportManagermentsProvider == null)
						{
							this.innerSqlReportManagermentsProvider = new SqlReportManagermentsProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlReportManagermentsProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlReportManagermentsProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlReportManagermentsProvider SqlReportManagermentsProvider
		{
			get {return ReportManagermentsProvider as SqlReportManagermentsProvider;}
		}
		
		#endregion
		
		
		#region "LopHocPhanGhepThoiKhoaBieuProvider"
			
		private SqlLopHocPhanGhepThoiKhoaBieuProvider innerSqlLopHocPhanGhepThoiKhoaBieuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LopHocPhanGhepThoiKhoaBieu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LopHocPhanGhepThoiKhoaBieuProviderBase LopHocPhanGhepThoiKhoaBieuProvider
		{
			get
			{
				if (innerSqlLopHocPhanGhepThoiKhoaBieuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLopHocPhanGhepThoiKhoaBieuProvider == null)
						{
							this.innerSqlLopHocPhanGhepThoiKhoaBieuProvider = new SqlLopHocPhanGhepThoiKhoaBieuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLopHocPhanGhepThoiKhoaBieuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLopHocPhanGhepThoiKhoaBieuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLopHocPhanGhepThoiKhoaBieuProvider SqlLopHocPhanGhepThoiKhoaBieuProvider
		{
			get {return LopHocPhanGhepThoiKhoaBieuProvider as SqlLopHocPhanGhepThoiKhoaBieuProvider;}
		}
		
		#endregion
		
		
		#region "LopHocPhanClcAufCjlProvider"
			
		private SqlLopHocPhanClcAufCjlProvider innerSqlLopHocPhanClcAufCjlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LopHocPhanClcAufCjl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LopHocPhanClcAufCjlProviderBase LopHocPhanClcAufCjlProvider
		{
			get
			{
				if (innerSqlLopHocPhanClcAufCjlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLopHocPhanClcAufCjlProvider == null)
						{
							this.innerSqlLopHocPhanClcAufCjlProvider = new SqlLopHocPhanClcAufCjlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLopHocPhanClcAufCjlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLopHocPhanClcAufCjlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLopHocPhanClcAufCjlProvider SqlLopHocPhanClcAufCjlProvider
		{
			get {return LopHocPhanClcAufCjlProvider as SqlLopHocPhanClcAufCjlProvider;}
		}
		
		#endregion
		
		
		#region "QuyUocDatTenLopHocPhanProvider"
			
		private SqlQuyUocDatTenLopHocPhanProvider innerSqlQuyUocDatTenLopHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="QuyUocDatTenLopHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override QuyUocDatTenLopHocPhanProviderBase QuyUocDatTenLopHocPhanProvider
		{
			get
			{
				if (innerSqlQuyUocDatTenLopHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlQuyUocDatTenLopHocPhanProvider == null)
						{
							this.innerSqlQuyUocDatTenLopHocPhanProvider = new SqlQuyUocDatTenLopHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlQuyUocDatTenLopHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlQuyUocDatTenLopHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlQuyUocDatTenLopHocPhanProvider SqlQuyUocDatTenLopHocPhanProvider
		{
			get {return QuyUocDatTenLopHocPhanProvider as SqlQuyUocDatTenLopHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "LoaiNhanVienProvider"
			
		private SqlLoaiNhanVienProvider innerSqlLoaiNhanVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LoaiNhanVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LoaiNhanVienProviderBase LoaiNhanVienProvider
		{
			get
			{
				if (innerSqlLoaiNhanVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLoaiNhanVienProvider == null)
						{
							this.innerSqlLoaiNhanVienProvider = new SqlLoaiNhanVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLoaiNhanVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLoaiNhanVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLoaiNhanVienProvider SqlLoaiNhanVienProvider
		{
			get {return LoaiNhanVienProvider as SqlLoaiNhanVienProvider;}
		}
		
		#endregion
		
		
		#region "LoaiGiangVienProvider"
			
		private SqlLoaiGiangVienProvider innerSqlLoaiGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="LoaiGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override LoaiGiangVienProviderBase LoaiGiangVienProvider
		{
			get
			{
				if (innerSqlLoaiGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlLoaiGiangVienProvider == null)
						{
							this.innerSqlLoaiGiangVienProvider = new SqlLoaiGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlLoaiGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlLoaiGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlLoaiGiangVienProvider SqlLoaiGiangVienProvider
		{
			get {return LoaiGiangVienProvider as SqlLoaiGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "PhanQuyenControlTrenFormProvider"
			
		private SqlPhanQuyenControlTrenFormProvider innerSqlPhanQuyenControlTrenFormProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="PhanQuyenControlTrenForm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override PhanQuyenControlTrenFormProviderBase PhanQuyenControlTrenFormProvider
		{
			get
			{
				if (innerSqlPhanQuyenControlTrenFormProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlPhanQuyenControlTrenFormProvider == null)
						{
							this.innerSqlPhanQuyenControlTrenFormProvider = new SqlPhanQuyenControlTrenFormProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlPhanQuyenControlTrenFormProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlPhanQuyenControlTrenFormProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlPhanQuyenControlTrenFormProvider SqlPhanQuyenControlTrenFormProvider
		{
			get {return PhanQuyenControlTrenFormProvider as SqlPhanQuyenControlTrenFormProvider;}
		}
		
		#endregion
		
		
		#region "QuyDoiGioChuanProvider"
			
		private SqlQuyDoiGioChuanProvider innerSqlQuyDoiGioChuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="QuyDoiGioChuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override QuyDoiGioChuanProviderBase QuyDoiGioChuanProvider
		{
			get
			{
				if (innerSqlQuyDoiGioChuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlQuyDoiGioChuanProvider == null)
						{
							this.innerSqlQuyDoiGioChuanProvider = new SqlQuyDoiGioChuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlQuyDoiGioChuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlQuyDoiGioChuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlQuyDoiGioChuanProvider SqlQuyDoiGioChuanProvider
		{
			get {return QuyDoiGioChuanProvider as SqlQuyDoiGioChuanProvider;}
		}
		
		#endregion
		
		
		#region "UteKhoiLuongGiangDayProvider"
			
		private SqlUteKhoiLuongGiangDayProvider innerSqlUteKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="UteKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override UteKhoiLuongGiangDayProviderBase UteKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlUteKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlUteKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlUteKhoiLuongGiangDayProvider = new SqlUteKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlUteKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlUteKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlUteKhoiLuongGiangDayProvider SqlUteKhoiLuongGiangDayProvider
		{
			get {return UteKhoiLuongGiangDayProvider as SqlUteKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "SoTietCoiThiTieuChuanCuaGiangVienProvider"
			
		private SqlSoTietCoiThiTieuChuanCuaGiangVienProvider innerSqlSoTietCoiThiTieuChuanCuaGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SoTietCoiThiTieuChuanCuaGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SoTietCoiThiTieuChuanCuaGiangVienProviderBase SoTietCoiThiTieuChuanCuaGiangVienProvider
		{
			get
			{
				if (innerSqlSoTietCoiThiTieuChuanCuaGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSoTietCoiThiTieuChuanCuaGiangVienProvider == null)
						{
							this.innerSqlSoTietCoiThiTieuChuanCuaGiangVienProvider = new SqlSoTietCoiThiTieuChuanCuaGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSoTietCoiThiTieuChuanCuaGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSoTietCoiThiTieuChuanCuaGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSoTietCoiThiTieuChuanCuaGiangVienProvider SqlSoTietCoiThiTieuChuanCuaGiangVienProvider
		{
			get {return SoTietCoiThiTieuChuanCuaGiangVienProvider as SqlSoTietCoiThiTieuChuanCuaGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoCoiThiChamBaiImportProvider"
			
		private SqlThuLaoCoiThiChamBaiImportProvider innerSqlThuLaoCoiThiChamBaiImportProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoCoiThiChamBaiImport"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoCoiThiChamBaiImportProviderBase ThuLaoCoiThiChamBaiImportProvider
		{
			get
			{
				if (innerSqlThuLaoCoiThiChamBaiImportProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoCoiThiChamBaiImportProvider == null)
						{
							this.innerSqlThuLaoCoiThiChamBaiImportProvider = new SqlThuLaoCoiThiChamBaiImportProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoCoiThiChamBaiImportProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoCoiThiChamBaiImportProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoCoiThiChamBaiImportProvider SqlThuLaoCoiThiChamBaiImportProvider
		{
			get {return ThuLaoCoiThiChamBaiImportProvider as SqlThuLaoCoiThiChamBaiImportProvider;}
		}
		
		#endregion
		
		
		#region "TrinhDoQuanLyNhaNuocProvider"
			
		private SqlTrinhDoQuanLyNhaNuocProvider innerSqlTrinhDoQuanLyNhaNuocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrinhDoQuanLyNhaNuoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrinhDoQuanLyNhaNuocProviderBase TrinhDoQuanLyNhaNuocProvider
		{
			get
			{
				if (innerSqlTrinhDoQuanLyNhaNuocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrinhDoQuanLyNhaNuocProvider == null)
						{
							this.innerSqlTrinhDoQuanLyNhaNuocProvider = new SqlTrinhDoQuanLyNhaNuocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrinhDoQuanLyNhaNuocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTrinhDoQuanLyNhaNuocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrinhDoQuanLyNhaNuocProvider SqlTrinhDoQuanLyNhaNuocProvider
		{
			get {return TrinhDoQuanLyNhaNuocProvider as SqlTrinhDoQuanLyNhaNuocProvider;}
		}
		
		#endregion
		
		
		#region "QuyDoiKhoiLuongTamUngProvider"
			
		private SqlQuyDoiKhoiLuongTamUngProvider innerSqlQuyDoiKhoiLuongTamUngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="QuyDoiKhoiLuongTamUng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override QuyDoiKhoiLuongTamUngProviderBase QuyDoiKhoiLuongTamUngProvider
		{
			get
			{
				if (innerSqlQuyDoiKhoiLuongTamUngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlQuyDoiKhoiLuongTamUngProvider == null)
						{
							this.innerSqlQuyDoiKhoiLuongTamUngProvider = new SqlQuyDoiKhoiLuongTamUngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlQuyDoiKhoiLuongTamUngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlQuyDoiKhoiLuongTamUngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlQuyDoiKhoiLuongTamUngProvider SqlQuyDoiKhoiLuongTamUngProvider
		{
			get {return QuyDoiKhoiLuongTamUngProvider as SqlQuyDoiKhoiLuongTamUngProvider;}
		}
		
		#endregion
		
		
		#region "TinhTrangProvider"
			
		private SqlTinhTrangProvider innerSqlTinhTrangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TinhTrang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TinhTrangProviderBase TinhTrangProvider
		{
			get
			{
				if (innerSqlTinhTrangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTinhTrangProvider == null)
						{
							this.innerSqlTinhTrangProvider = new SqlTinhTrangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTinhTrangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTinhTrangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTinhTrangProvider SqlTinhTrangProvider
		{
			get {return TinhTrangProvider as SqlTinhTrangProvider;}
		}
		
		#endregion
		
		
		#region "TrinhDoSuPhamProvider"
			
		private SqlTrinhDoSuPhamProvider innerSqlTrinhDoSuPhamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrinhDoSuPham"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrinhDoSuPhamProviderBase TrinhDoSuPhamProvider
		{
			get
			{
				if (innerSqlTrinhDoSuPhamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrinhDoSuPhamProvider == null)
						{
							this.innerSqlTrinhDoSuPhamProvider = new SqlTrinhDoSuPhamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrinhDoSuPhamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTrinhDoSuPhamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrinhDoSuPhamProvider SqlTrinhDoSuPhamProvider
		{
			get {return TrinhDoSuPhamProvider as SqlTrinhDoSuPhamProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoCoiThiProvider"
			
		private SqlThuLaoCoiThiProvider innerSqlThuLaoCoiThiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoCoiThi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoCoiThiProviderBase ThuLaoCoiThiProvider
		{
			get
			{
				if (innerSqlThuLaoCoiThiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoCoiThiProvider == null)
						{
							this.innerSqlThuLaoCoiThiProvider = new SqlThuLaoCoiThiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoCoiThiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoCoiThiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoCoiThiProvider SqlThuLaoCoiThiProvider
		{
			get {return ThuLaoCoiThiProvider as SqlThuLaoCoiThiProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoCoiThiVhuProvider"
			
		private SqlThuLaoCoiThiVhuProvider innerSqlThuLaoCoiThiVhuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoCoiThiVhu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoCoiThiVhuProviderBase ThuLaoCoiThiVhuProvider
		{
			get
			{
				if (innerSqlThuLaoCoiThiVhuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoCoiThiVhuProvider == null)
						{
							this.innerSqlThuLaoCoiThiVhuProvider = new SqlThuLaoCoiThiVhuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoCoiThiVhuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoCoiThiVhuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoCoiThiVhuProvider SqlThuLaoCoiThiVhuProvider
		{
			get {return ThuLaoCoiThiVhuProvider as SqlThuLaoCoiThiVhuProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoImportProvider"
			
		private SqlThuLaoImportProvider innerSqlThuLaoImportProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoImport"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoImportProviderBase ThuLaoImportProvider
		{
			get
			{
				if (innerSqlThuLaoImportProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoImportProvider == null)
						{
							this.innerSqlThuLaoImportProvider = new SqlThuLaoImportProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoImportProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoImportProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoImportProvider SqlThuLaoImportProvider
		{
			get {return ThuLaoImportProvider as SqlThuLaoImportProvider;}
		}
		
		#endregion
		
		
		#region "ThuMoiGiangHopDongThinhGiangProvider"
			
		private SqlThuMoiGiangHopDongThinhGiangProvider innerSqlThuMoiGiangHopDongThinhGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuMoiGiangHopDongThinhGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuMoiGiangHopDongThinhGiangProviderBase ThuMoiGiangHopDongThinhGiangProvider
		{
			get
			{
				if (innerSqlThuMoiGiangHopDongThinhGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuMoiGiangHopDongThinhGiangProvider == null)
						{
							this.innerSqlThuMoiGiangHopDongThinhGiangProvider = new SqlThuMoiGiangHopDongThinhGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuMoiGiangHopDongThinhGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuMoiGiangHopDongThinhGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuMoiGiangHopDongThinhGiangProvider SqlThuMoiGiangHopDongThinhGiangProvider
		{
			get {return ThuMoiGiangHopDongThinhGiangProvider as SqlThuMoiGiangHopDongThinhGiangProvider;}
		}
		
		#endregion
		
		
		#region "TrinhDoTinHocProvider"
			
		private SqlTrinhDoTinHocProvider innerSqlTrinhDoTinHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TrinhDoTinHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TrinhDoTinHocProviderBase TrinhDoTinHocProvider
		{
			get
			{
				if (innerSqlTrinhDoTinHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTrinhDoTinHocProvider == null)
						{
							this.innerSqlTrinhDoTinHocProvider = new SqlTrinhDoTinHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTrinhDoTinHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTrinhDoTinHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTrinhDoTinHocProvider SqlTrinhDoTinHocProvider
		{
			get {return TrinhDoTinHocProvider as SqlTrinhDoTinHocProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoRaDeVhuProvider"
			
		private SqlThuLaoRaDeVhuProvider innerSqlThuLaoRaDeVhuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoRaDeVhu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoRaDeVhuProviderBase ThuLaoRaDeVhuProvider
		{
			get
			{
				if (innerSqlThuLaoRaDeVhuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoRaDeVhuProvider == null)
						{
							this.innerSqlThuLaoRaDeVhuProvider = new SqlThuLaoRaDeVhuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoRaDeVhuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoRaDeVhuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoRaDeVhuProvider SqlThuLaoRaDeVhuProvider
		{
			get {return ThuLaoRaDeVhuProvider as SqlThuLaoRaDeVhuProvider;}
		}
		
		#endregion
		
		
		#region "DonViTinhProvider"
			
		private SqlDonViTinhProvider innerSqlDonViTinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DonViTinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DonViTinhProviderBase DonViTinhProvider
		{
			get
			{
				if (innerSqlDonViTinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDonViTinhProvider == null)
						{
							this.innerSqlDonViTinhProvider = new SqlDonViTinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDonViTinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDonViTinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDonViTinhProvider SqlDonViTinhProvider
		{
			get {return DonViTinhProvider as SqlDonViTinhProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoChamThiVhuexProvider"
			
		private SqlThuLaoChamThiVhuexProvider innerSqlThuLaoChamThiVhuexProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoChamThiVhuex"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoChamThiVhuexProviderBase ThuLaoChamThiVhuexProvider
		{
			get
			{
				if (innerSqlThuLaoChamThiVhuexProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoChamThiVhuexProvider == null)
						{
							this.innerSqlThuLaoChamThiVhuexProvider = new SqlThuLaoChamThiVhuexProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoChamThiVhuexProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoChamThiVhuexProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoChamThiVhuexProvider SqlThuLaoChamThiVhuexProvider
		{
			get {return ThuLaoChamThiVhuexProvider as SqlThuLaoChamThiVhuexProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoHuongDanCuoiKhoaProvider"
			
		private SqlThuLaoHuongDanCuoiKhoaProvider innerSqlThuLaoHuongDanCuoiKhoaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoHuongDanCuoiKhoa"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoHuongDanCuoiKhoaProviderBase ThuLaoHuongDanCuoiKhoaProvider
		{
			get
			{
				if (innerSqlThuLaoHuongDanCuoiKhoaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoHuongDanCuoiKhoaProvider == null)
						{
							this.innerSqlThuLaoHuongDanCuoiKhoaProvider = new SqlThuLaoHuongDanCuoiKhoaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoHuongDanCuoiKhoaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoHuongDanCuoiKhoaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoHuongDanCuoiKhoaProvider SqlThuLaoHuongDanCuoiKhoaProvider
		{
			get {return ThuLaoHuongDanCuoiKhoaProvider as SqlThuLaoHuongDanCuoiKhoaProvider;}
		}
		
		#endregion
		
		
		#region "KetQuaTinhProvider"
			
		private SqlKetQuaTinhProvider innerSqlKetQuaTinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KetQuaTinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KetQuaTinhProviderBase KetQuaTinhProvider
		{
			get
			{
				if (innerSqlKetQuaTinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKetQuaTinhProvider == null)
						{
							this.innerSqlKetQuaTinhProvider = new SqlKetQuaTinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKetQuaTinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKetQuaTinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKetQuaTinhProvider SqlKetQuaTinhProvider
		{
			get {return KetQuaTinhProvider as SqlKetQuaTinhProvider;}
		}
		
		#endregion
		
		
		#region "TienCongTacPhiProvider"
			
		private SqlTienCongTacPhiProvider innerSqlTienCongTacPhiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TienCongTacPhi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TienCongTacPhiProviderBase TienCongTacPhiProvider
		{
			get
			{
				if (innerSqlTienCongTacPhiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTienCongTacPhiProvider == null)
						{
							this.innerSqlTienCongTacPhiProvider = new SqlTienCongTacPhiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTienCongTacPhiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTienCongTacPhiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTienCongTacPhiProvider SqlTienCongTacPhiProvider
		{
			get {return TienCongTacPhiProvider as SqlTienCongTacPhiProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoGiangDayDaiHocLopClcProvider"
			
		private SqlThuLaoGiangDayDaiHocLopClcProvider innerSqlThuLaoGiangDayDaiHocLopClcProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoGiangDayDaiHocLopClc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoGiangDayDaiHocLopClcProviderBase ThuLaoGiangDayDaiHocLopClcProvider
		{
			get
			{
				if (innerSqlThuLaoGiangDayDaiHocLopClcProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoGiangDayDaiHocLopClcProvider == null)
						{
							this.innerSqlThuLaoGiangDayDaiHocLopClcProvider = new SqlThuLaoGiangDayDaiHocLopClcProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoGiangDayDaiHocLopClcProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoGiangDayDaiHocLopClcProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoGiangDayDaiHocLopClcProvider SqlThuLaoGiangDayDaiHocLopClcProvider
		{
			get {return ThuLaoGiangDayDaiHocLopClcProvider as SqlThuLaoGiangDayDaiHocLopClcProvider;}
		}
		
		#endregion
		
		
		#region "VaiTroProvider"
			
		private SqlVaiTroProvider innerSqlVaiTroProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VaiTro"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VaiTroProviderBase VaiTroProvider
		{
			get
			{
				if (innerSqlVaiTroProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVaiTroProvider == null)
						{
							this.innerSqlVaiTroProvider = new SqlVaiTroProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVaiTroProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVaiTroProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVaiTroProvider SqlVaiTroProvider
		{
			get {return VaiTroProvider as SqlVaiTroProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongGiangDayProvider"
			
		private SqlKhoiLuongGiangDayProvider innerSqlKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongGiangDayProviderBase KhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlKhoiLuongGiangDayProvider = new SqlKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongGiangDayProvider SqlKhoiLuongGiangDayProvider
		{
			get {return KhoiLuongGiangDayProvider as SqlKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongKhacProvider"
			
		private SqlKhoiLuongKhacProvider innerSqlKhoiLuongKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongKhacProviderBase KhoiLuongKhacProvider
		{
			get
			{
				if (innerSqlKhoiLuongKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongKhacProvider == null)
						{
							this.innerSqlKhoiLuongKhacProvider = new SqlKhoiLuongKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongKhacProvider SqlKhoiLuongKhacProvider
		{
			get {return KhoiLuongKhacProvider as SqlKhoiLuongKhacProvider;}
		}
		
		#endregion
		
		
		#region "HeSoThuLaoProvider"
			
		private SqlHeSoThuLaoProvider innerSqlHeSoThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoThuLaoProviderBase HeSoThuLaoProvider
		{
			get
			{
				if (innerSqlHeSoThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoThuLaoProvider == null)
						{
							this.innerSqlHeSoThuLaoProvider = new SqlHeSoThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoThuLaoProvider SqlHeSoThuLaoProvider
		{
			get {return HeSoThuLaoProvider as SqlHeSoThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "HeSoTroCapTheoKhoaProvider"
			
		private SqlHeSoTroCapTheoKhoaProvider innerSqlHeSoTroCapTheoKhoaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoTroCapTheoKhoa"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoTroCapTheoKhoaProviderBase HeSoTroCapTheoKhoaProvider
		{
			get
			{
				if (innerSqlHeSoTroCapTheoKhoaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoTroCapTheoKhoaProvider == null)
						{
							this.innerSqlHeSoTroCapTheoKhoaProvider = new SqlHeSoTroCapTheoKhoaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoTroCapTheoKhoaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoTroCapTheoKhoaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoTroCapTheoKhoaProvider SqlHeSoTroCapTheoKhoaProvider
		{
			get {return HeSoTroCapTheoKhoaProvider as SqlHeSoTroCapTheoKhoaProvider;}
		}
		
		#endregion
		
		
		#region "TinhTrangTheoNamHocProvider"
			
		private SqlTinhTrangTheoNamHocProvider innerSqlTinhTrangTheoNamHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TinhTrangTheoNamHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TinhTrangTheoNamHocProviderBase TinhTrangTheoNamHocProvider
		{
			get
			{
				if (innerSqlTinhTrangTheoNamHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTinhTrangTheoNamHocProvider == null)
						{
							this.innerSqlTinhTrangTheoNamHocProvider = new SqlTinhTrangTheoNamHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTinhTrangTheoNamHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTinhTrangTheoNamHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTinhTrangTheoNamHocProvider SqlTinhTrangTheoNamHocProvider
		{
			get {return TinhTrangTheoNamHocProvider as SqlTinhTrangTheoNamHocProvider;}
		}
		
		#endregion
		
		
		#region "UteKhoiLuongQuyDoiProvider"
			
		private SqlUteKhoiLuongQuyDoiProvider innerSqlUteKhoiLuongQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="UteKhoiLuongQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override UteKhoiLuongQuyDoiProviderBase UteKhoiLuongQuyDoiProvider
		{
			get
			{
				if (innerSqlUteKhoiLuongQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlUteKhoiLuongQuyDoiProvider == null)
						{
							this.innerSqlUteKhoiLuongQuyDoiProvider = new SqlUteKhoiLuongQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlUteKhoiLuongQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlUteKhoiLuongQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlUteKhoiLuongQuyDoiProvider SqlUteKhoiLuongQuyDoiProvider
		{
			get {return UteKhoiLuongQuyDoiProvider as SqlUteKhoiLuongQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "KhoanChiKhacProvider"
			
		private SqlKhoanChiKhacProvider innerSqlKhoanChiKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoanChiKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoanChiKhacProviderBase KhoanChiKhacProvider
		{
			get
			{
				if (innerSqlKhoanChiKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoanChiKhacProvider == null)
						{
							this.innerSqlKhoanChiKhacProvider = new SqlKhoanChiKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoanChiKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoanChiKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoanChiKhacProvider SqlKhoanChiKhacProvider
		{
			get {return KhoanChiKhacProvider as SqlKhoanChiKhacProvider;}
		}
		
		#endregion
		
		
		#region "TietNghiaVuProvider"
			
		private SqlTietNghiaVuProvider innerSqlTietNghiaVuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TietNghiaVu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TietNghiaVuProviderBase TietNghiaVuProvider
		{
			get
			{
				if (innerSqlTietNghiaVuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTietNghiaVuProvider == null)
						{
							this.innerSqlTietNghiaVuProvider = new SqlTietNghiaVuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTietNghiaVuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTietNghiaVuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTietNghiaVuProvider SqlTietNghiaVuProvider
		{
			get {return TietNghiaVuProvider as SqlTietNghiaVuProvider;}
		}
		
		#endregion
		
		
		#region "TongTienLuongTrongNamCuaGiangVienProvider"
			
		private SqlTongTienLuongTrongNamCuaGiangVienProvider innerSqlTongTienLuongTrongNamCuaGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TongTienLuongTrongNamCuaGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TongTienLuongTrongNamCuaGiangVienProviderBase TongTienLuongTrongNamCuaGiangVienProvider
		{
			get
			{
				if (innerSqlTongTienLuongTrongNamCuaGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTongTienLuongTrongNamCuaGiangVienProvider == null)
						{
							this.innerSqlTongTienLuongTrongNamCuaGiangVienProvider = new SqlTongTienLuongTrongNamCuaGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTongTienLuongTrongNamCuaGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTongTienLuongTrongNamCuaGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTongTienLuongTrongNamCuaGiangVienProvider SqlTongTienLuongTrongNamCuaGiangVienProvider
		{
			get {return TongTienLuongTrongNamCuaGiangVienProvider as SqlTongTienLuongTrongNamCuaGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "UteKhoiLuongKhacProvider"
			
		private SqlUteKhoiLuongKhacProvider innerSqlUteKhoiLuongKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="UteKhoiLuongKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override UteKhoiLuongKhacProviderBase UteKhoiLuongKhacProvider
		{
			get
			{
				if (innerSqlUteKhoiLuongKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlUteKhoiLuongKhacProvider == null)
						{
							this.innerSqlUteKhoiLuongKhacProvider = new SqlUteKhoiLuongKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlUteKhoiLuongKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlUteKhoiLuongKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlUteKhoiLuongKhacProvider SqlUteKhoiLuongKhacProvider
		{
			get {return UteKhoiLuongKhacProvider as SqlUteKhoiLuongKhacProvider;}
		}
		
		#endregion
		
		
		#region "KhoiLuongCacCongViecKhacProvider"
			
		private SqlKhoiLuongCacCongViecKhacProvider innerSqlKhoiLuongCacCongViecKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoiLuongCacCongViecKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoiLuongCacCongViecKhacProviderBase KhoiLuongCacCongViecKhacProvider
		{
			get
			{
				if (innerSqlKhoiLuongCacCongViecKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoiLuongCacCongViecKhacProvider == null)
						{
							this.innerSqlKhoiLuongCacCongViecKhacProvider = new SqlKhoiLuongCacCongViecKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoiLuongCacCongViecKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoiLuongCacCongViecKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoiLuongCacCongViecKhacProvider SqlKhoiLuongCacCongViecKhacProvider
		{
			get {return KhoiLuongCacCongViecKhacProvider as SqlKhoiLuongCacCongViecKhacProvider;}
		}
		
		#endregion
		
		
		#region "KhoanQuyDoiProvider"
			
		private SqlKhoanQuyDoiProvider innerSqlKhoanQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KhoanQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KhoanQuyDoiProviderBase KhoanQuyDoiProvider
		{
			get
			{
				if (innerSqlKhoanQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKhoanQuyDoiProvider == null)
						{
							this.innerSqlKhoanQuyDoiProvider = new SqlKhoanQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKhoanQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKhoanQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKhoanQuyDoiProvider SqlKhoanQuyDoiProvider
		{
			get {return KhoanQuyDoiProvider as SqlKhoanQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "TietNoKyTruocProvider"
			
		private SqlTietNoKyTruocProvider innerSqlTietNoKyTruocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TietNoKyTruoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TietNoKyTruocProviderBase TietNoKyTruocProvider
		{
			get
			{
				if (innerSqlTietNoKyTruocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTietNoKyTruocProvider == null)
						{
							this.innerSqlTietNoKyTruocProvider = new SqlTietNoKyTruocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTietNoKyTruocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTietNoKyTruocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTietNoKyTruocProvider SqlTietNoKyTruocProvider
		{
			get {return TietNoKyTruocProvider as SqlTietNoKyTruocProvider;}
		}
		
		#endregion
		
		
		#region "QuyDoiHoatDongNgoaiGiangDayProvider"
			
		private SqlQuyDoiHoatDongNgoaiGiangDayProvider innerSqlQuyDoiHoatDongNgoaiGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="QuyDoiHoatDongNgoaiGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override QuyDoiHoatDongNgoaiGiangDayProviderBase QuyDoiHoatDongNgoaiGiangDayProvider
		{
			get
			{
				if (innerSqlQuyDoiHoatDongNgoaiGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlQuyDoiHoatDongNgoaiGiangDayProvider == null)
						{
							this.innerSqlQuyDoiHoatDongNgoaiGiangDayProvider = new SqlQuyDoiHoatDongNgoaiGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlQuyDoiHoatDongNgoaiGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlQuyDoiHoatDongNgoaiGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlQuyDoiHoatDongNgoaiGiangDayProvider SqlQuyDoiHoatDongNgoaiGiangDayProvider
		{
			get {return QuyDoiHoatDongNgoaiGiangDayProvider as SqlQuyDoiHoatDongNgoaiGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoChamBaiProvider"
			
		private SqlThuLaoChamBaiProvider innerSqlThuLaoChamBaiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoChamBai"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoChamBaiProviderBase ThuLaoChamBaiProvider
		{
			get
			{
				if (innerSqlThuLaoChamBaiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoChamBaiProvider == null)
						{
							this.innerSqlThuLaoChamBaiProvider = new SqlThuLaoChamBaiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoChamBaiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoChamBaiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoChamBaiProvider SqlThuLaoChamBaiProvider
		{
			get {return ThuLaoChamBaiProvider as SqlThuLaoChamBaiProvider;}
		}
		
		#endregion
		
		
		#region "ThucGiangMonThucTeTuHocProvider"
			
		private SqlThucGiangMonThucTeTuHocProvider innerSqlThucGiangMonThucTeTuHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThucGiangMonThucTeTuHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThucGiangMonThucTeTuHocProviderBase ThucGiangMonThucTeTuHocProvider
		{
			get
			{
				if (innerSqlThucGiangMonThucTeTuHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThucGiangMonThucTeTuHocProvider == null)
						{
							this.innerSqlThucGiangMonThucTeTuHocProvider = new SqlThucGiangMonThucTeTuHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThucGiangMonThucTeTuHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThucGiangMonThucTeTuHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThucGiangMonThucTeTuHocProvider SqlThucGiangMonThucTeTuHocProvider
		{
			get {return ThucGiangMonThucTeTuHocProvider as SqlThucGiangMonThucTeTuHocProvider;}
		}
		
		#endregion
		
		
		#region "ThueThuNhapCaNhanProvider"
			
		private SqlThueThuNhapCaNhanProvider innerSqlThueThuNhapCaNhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThueThuNhapCaNhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThueThuNhapCaNhanProviderBase ThueThuNhapCaNhanProvider
		{
			get
			{
				if (innerSqlThueThuNhapCaNhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThueThuNhapCaNhanProvider == null)
						{
							this.innerSqlThueThuNhapCaNhanProvider = new SqlThueThuNhapCaNhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThueThuNhapCaNhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThueThuNhapCaNhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThueThuNhapCaNhanProvider SqlThueThuNhapCaNhanProvider
		{
			get {return ThueThuNhapCaNhanProvider as SqlThueThuNhapCaNhanProvider;}
		}
		
		#endregion
		
		
		#region "ThongTinGiangDayGiangVienProvider"
			
		private SqlThongTinGiangDayGiangVienProvider innerSqlThongTinGiangDayGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThongTinGiangDayGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThongTinGiangDayGiangVienProviderBase ThongTinGiangDayGiangVienProvider
		{
			get
			{
				if (innerSqlThongTinGiangDayGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThongTinGiangDayGiangVienProvider == null)
						{
							this.innerSqlThongTinGiangDayGiangVienProvider = new SqlThongTinGiangDayGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThongTinGiangDayGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThongTinGiangDayGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThongTinGiangDayGiangVienProvider SqlThongTinGiangDayGiangVienProvider
		{
			get {return ThongTinGiangDayGiangVienProvider as SqlThongTinGiangDayGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoChamBaiVhuProvider"
			
		private SqlThuLaoChamBaiVhuProvider innerSqlThuLaoChamBaiVhuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoChamBaiVhu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoChamBaiVhuProviderBase ThuLaoChamBaiVhuProvider
		{
			get
			{
				if (innerSqlThuLaoChamBaiVhuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoChamBaiVhuProvider == null)
						{
							this.innerSqlThuLaoChamBaiVhuProvider = new SqlThuLaoChamBaiVhuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoChamBaiVhuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoChamBaiVhuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoChamBaiVhuProvider SqlThuLaoChamBaiVhuProvider
		{
			get {return ThuLaoChamBaiVhuProvider as SqlThuLaoChamBaiVhuProvider;}
		}
		
		#endregion
		
		
		#region "SdhPhanNhomMonHocProvider"
			
		private SqlSdhPhanNhomMonHocProvider innerSqlSdhPhanNhomMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhPhanNhomMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhPhanNhomMonHocProviderBase SdhPhanNhomMonHocProvider
		{
			get
			{
				if (innerSqlSdhPhanNhomMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhPhanNhomMonHocProvider == null)
						{
							this.innerSqlSdhPhanNhomMonHocProvider = new SqlSdhPhanNhomMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhPhanNhomMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhPhanNhomMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhPhanNhomMonHocProvider SqlSdhPhanNhomMonHocProvider
		{
			get {return SdhPhanNhomMonHocProvider as SqlSdhPhanNhomMonHocProvider;}
		}
		
		#endregion
		
		
		#region "SdhNhomMonHocProvider"
			
		private SqlSdhNhomMonHocProvider innerSqlSdhNhomMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhNhomMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhNhomMonHocProviderBase SdhNhomMonHocProvider
		{
			get
			{
				if (innerSqlSdhNhomMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhNhomMonHocProvider == null)
						{
							this.innerSqlSdhNhomMonHocProvider = new SqlSdhNhomMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhNhomMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhNhomMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhNhomMonHocProvider SqlSdhNhomMonHocProvider
		{
			get {return SdhNhomMonHocProvider as SqlSdhNhomMonHocProvider;}
		}
		
		#endregion
		
		
		#region "SdhDonGiaProvider"
			
		private SqlSdhDonGiaProvider innerSqlSdhDonGiaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhDonGia"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhDonGiaProviderBase SdhDonGiaProvider
		{
			get
			{
				if (innerSqlSdhDonGiaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhDonGiaProvider == null)
						{
							this.innerSqlSdhDonGiaProvider = new SqlSdhDonGiaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhDonGiaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhDonGiaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhDonGiaProvider SqlSdhDonGiaProvider
		{
			get {return SdhDonGiaProvider as SqlSdhDonGiaProvider;}
		}
		
		#endregion
		
		
		#region "SdhKetQuaThanhToanThuLaoProvider"
			
		private SqlSdhKetQuaThanhToanThuLaoProvider innerSqlSdhKetQuaThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhKetQuaThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhKetQuaThanhToanThuLaoProviderBase SdhKetQuaThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlSdhKetQuaThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhKetQuaThanhToanThuLaoProvider == null)
						{
							this.innerSqlSdhKetQuaThanhToanThuLaoProvider = new SqlSdhKetQuaThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhKetQuaThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhKetQuaThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhKetQuaThanhToanThuLaoProvider SqlSdhKetQuaThanhToanThuLaoProvider
		{
			get {return SdhKetQuaThanhToanThuLaoProvider as SqlSdhKetQuaThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "SdhPhanLoaiHocPhanProvider"
			
		private SqlSdhPhanLoaiHocPhanProvider innerSqlSdhPhanLoaiHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhPhanLoaiHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhPhanLoaiHocPhanProviderBase SdhPhanLoaiHocPhanProvider
		{
			get
			{
				if (innerSqlSdhPhanLoaiHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhPhanLoaiHocPhanProvider == null)
						{
							this.innerSqlSdhPhanLoaiHocPhanProvider = new SqlSdhPhanLoaiHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhPhanLoaiHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhPhanLoaiHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhPhanLoaiHocPhanProvider SqlSdhPhanLoaiHocPhanProvider
		{
			get {return SdhPhanLoaiHocPhanProvider as SqlSdhPhanLoaiHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "SoTietNckhChuyenSangNamSauProvider"
			
		private SqlSoTietNckhChuyenSangNamSauProvider innerSqlSoTietNckhChuyenSangNamSauProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SoTietNckhChuyenSangNamSau"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SoTietNckhChuyenSangNamSauProviderBase SoTietNckhChuyenSangNamSauProvider
		{
			get
			{
				if (innerSqlSoTietNckhChuyenSangNamSauProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSoTietNckhChuyenSangNamSauProvider == null)
						{
							this.innerSqlSoTietNckhChuyenSangNamSauProvider = new SqlSoTietNckhChuyenSangNamSauProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSoTietNckhChuyenSangNamSauProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSoTietNckhChuyenSangNamSauProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSoTietNckhChuyenSangNamSauProvider SqlSoTietNckhChuyenSangNamSauProvider
		{
			get {return SoTietNckhChuyenSangNamSauProvider as SqlSoTietNckhChuyenSangNamSauProvider;}
		}
		
		#endregion
		
		
		#region "SdhMonHocKhongTinhKhoiLuongProvider"
			
		private SqlSdhMonHocKhongTinhKhoiLuongProvider innerSqlSdhMonHocKhongTinhKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhMonHocKhongTinhKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhMonHocKhongTinhKhoiLuongProviderBase SdhMonHocKhongTinhKhoiLuongProvider
		{
			get
			{
				if (innerSqlSdhMonHocKhongTinhKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhMonHocKhongTinhKhoiLuongProvider == null)
						{
							this.innerSqlSdhMonHocKhongTinhKhoiLuongProvider = new SqlSdhMonHocKhongTinhKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhMonHocKhongTinhKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhMonHocKhongTinhKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhMonHocKhongTinhKhoiLuongProvider SqlSdhMonHocKhongTinhKhoiLuongProvider
		{
			get {return SdhMonHocKhongTinhKhoiLuongProvider as SqlSdhMonHocKhongTinhKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "SdhHeSoDiaDiemProvider"
			
		private SqlSdhHeSoDiaDiemProvider innerSqlSdhHeSoDiaDiemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhHeSoDiaDiem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhHeSoDiaDiemProviderBase SdhHeSoDiaDiemProvider
		{
			get
			{
				if (innerSqlSdhHeSoDiaDiemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhHeSoDiaDiemProvider == null)
						{
							this.innerSqlSdhHeSoDiaDiemProvider = new SqlSdhHeSoDiaDiemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhHeSoDiaDiemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhHeSoDiaDiemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhHeSoDiaDiemProvider SqlSdhHeSoDiaDiemProvider
		{
			get {return SdhHeSoDiaDiemProvider as SqlSdhHeSoDiaDiemProvider;}
		}
		
		#endregion
		
		
		#region "SdhChotKhoiLuongGiangDayProvider"
			
		private SqlSdhChotKhoiLuongGiangDayProvider innerSqlSdhChotKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhChotKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhChotKhoiLuongGiangDayProviderBase SdhChotKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlSdhChotKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhChotKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlSdhChotKhoiLuongGiangDayProvider = new SqlSdhChotKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhChotKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhChotKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhChotKhoiLuongGiangDayProvider SqlSdhChotKhoiLuongGiangDayProvider
		{
			get {return SdhChotKhoiLuongGiangDayProvider as SqlSdhChotKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoGiangDayThucHanhProvider"
			
		private SqlThuLaoGiangDayThucHanhProvider innerSqlThuLaoGiangDayThucHanhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoGiangDayThucHanh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoGiangDayThucHanhProviderBase ThuLaoGiangDayThucHanhProvider
		{
			get
			{
				if (innerSqlThuLaoGiangDayThucHanhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoGiangDayThucHanhProvider == null)
						{
							this.innerSqlThuLaoGiangDayThucHanhProvider = new SqlThuLaoGiangDayThucHanhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoGiangDayThucHanhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoGiangDayThucHanhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoGiangDayThucHanhProvider SqlThuLaoGiangDayThucHanhProvider
		{
			get {return ThuLaoGiangDayThucHanhProvider as SqlThuLaoGiangDayThucHanhProvider;}
		}
		
		#endregion
		
		
		#region "ReportTemplateProvider"
			
		private SqlReportTemplateProvider innerSqlReportTemplateProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ReportTemplate"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ReportTemplateProviderBase ReportTemplateProvider
		{
			get
			{
				if (innerSqlReportTemplateProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlReportTemplateProvider == null)
						{
							this.innerSqlReportTemplateProvider = new SqlReportTemplateProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlReportTemplateProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlReportTemplateProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlReportTemplateProvider SqlReportTemplateProvider
		{
			get {return ReportTemplateProvider as SqlReportTemplateProvider;}
		}
		
		#endregion
		
		
		#region "SdhUteKhoiLuongGiangDayProvider"
			
		private SqlSdhUteKhoiLuongGiangDayProvider innerSqlSdhUteKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhUteKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhUteKhoiLuongGiangDayProviderBase SdhUteKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlSdhUteKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhUteKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlSdhUteKhoiLuongGiangDayProvider = new SqlSdhUteKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhUteKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhUteKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhUteKhoiLuongGiangDayProvider SqlSdhUteKhoiLuongGiangDayProvider
		{
			get {return SdhUteKhoiLuongGiangDayProvider as SqlSdhUteKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "SdhUteKhoiLuongQuyDoiProvider"
			
		private SqlSdhUteKhoiLuongQuyDoiProvider innerSqlSdhUteKhoiLuongQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhUteKhoiLuongQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhUteKhoiLuongQuyDoiProviderBase SdhUteKhoiLuongQuyDoiProvider
		{
			get
			{
				if (innerSqlSdhUteKhoiLuongQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhUteKhoiLuongQuyDoiProvider == null)
						{
							this.innerSqlSdhUteKhoiLuongQuyDoiProvider = new SqlSdhUteKhoiLuongQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhUteKhoiLuongQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhUteKhoiLuongQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhUteKhoiLuongQuyDoiProvider SqlSdhUteKhoiLuongQuyDoiProvider
		{
			get {return SdhUteKhoiLuongQuyDoiProvider as SqlSdhUteKhoiLuongQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "QuyMoKhoaProvider"
			
		private SqlQuyMoKhoaProvider innerSqlQuyMoKhoaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="QuyMoKhoa"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override QuyMoKhoaProviderBase QuyMoKhoaProvider
		{
			get
			{
				if (innerSqlQuyMoKhoaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlQuyMoKhoaProvider == null)
						{
							this.innerSqlQuyMoKhoaProvider = new SqlQuyMoKhoaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlQuyMoKhoaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlQuyMoKhoaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlQuyMoKhoaProvider SqlQuyMoKhoaProvider
		{
			get {return QuyMoKhoaProvider as SqlQuyMoKhoaProvider;}
		}
		
		#endregion
		
		
		#region "SdhMonPhanCongNhieuGiangVienProvider"
			
		private SqlSdhMonPhanCongNhieuGiangVienProvider innerSqlSdhMonPhanCongNhieuGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhMonPhanCongNhieuGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhMonPhanCongNhieuGiangVienProviderBase SdhMonPhanCongNhieuGiangVienProvider
		{
			get
			{
				if (innerSqlSdhMonPhanCongNhieuGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhMonPhanCongNhieuGiangVienProvider == null)
						{
							this.innerSqlSdhMonPhanCongNhieuGiangVienProvider = new SqlSdhMonPhanCongNhieuGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhMonPhanCongNhieuGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhMonPhanCongNhieuGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhMonPhanCongNhieuGiangVienProvider SqlSdhMonPhanCongNhieuGiangVienProvider
		{
			get {return SdhMonPhanCongNhieuGiangVienProvider as SqlSdhMonPhanCongNhieuGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "SdhUteThanhToanThuLaoProvider"
			
		private SqlSdhUteThanhToanThuLaoProvider innerSqlSdhUteThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhUteThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhUteThanhToanThuLaoProviderBase SdhUteThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlSdhUteThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhUteThanhToanThuLaoProvider == null)
						{
							this.innerSqlSdhUteThanhToanThuLaoProvider = new SqlSdhUteThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhUteThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhUteThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhUteThanhToanThuLaoProvider SqlSdhUteThanhToanThuLaoProvider
		{
			get {return SdhUteThanhToanThuLaoProvider as SqlSdhUteThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "ThanhTraGiangDayProvider"
			
		private SqlThanhTraGiangDayProvider innerSqlThanhTraGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThanhTraGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThanhTraGiangDayProviderBase ThanhTraGiangDayProvider
		{
			get
			{
				if (innerSqlThanhTraGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThanhTraGiangDayProvider == null)
						{
							this.innerSqlThanhTraGiangDayProvider = new SqlThanhTraGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThanhTraGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThanhTraGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThanhTraGiangDayProvider SqlThanhTraGiangDayProvider
		{
			get {return ThanhTraGiangDayProvider as SqlThanhTraGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ThoiGianGiangDayProvider"
			
		private SqlThoiGianGiangDayProvider innerSqlThoiGianGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThoiGianGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThoiGianGiangDayProviderBase ThoiGianGiangDayProvider
		{
			get
			{
				if (innerSqlThoiGianGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThoiGianGiangDayProvider == null)
						{
							this.innerSqlThoiGianGiangDayProvider = new SqlThoiGianGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThoiGianGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThoiGianGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThoiGianGiangDayProvider SqlThoiGianGiangDayProvider
		{
			get {return ThoiGianGiangDayProvider as SqlThoiGianGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ThanhTraCoiThiProvider"
			
		private SqlThanhTraCoiThiProvider innerSqlThanhTraCoiThiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThanhTraCoiThi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThanhTraCoiThiProviderBase ThanhTraCoiThiProvider
		{
			get
			{
				if (innerSqlThanhTraCoiThiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThanhTraCoiThiProvider == null)
						{
							this.innerSqlThanhTraCoiThiProvider = new SqlThanhTraCoiThiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThanhTraCoiThiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThanhTraCoiThiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThanhTraCoiThiProvider SqlThanhTraCoiThiProvider
		{
			get {return ThanhTraCoiThiProvider as SqlThanhTraCoiThiProvider;}
		}
		
		#endregion
		
		
		#region "ThanhTraChamGiangTheoKhoaHocProvider"
			
		private SqlThanhTraChamGiangTheoKhoaHocProvider innerSqlThanhTraChamGiangTheoKhoaHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThanhTraChamGiangTheoKhoaHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThanhTraChamGiangTheoKhoaHocProviderBase ThanhTraChamGiangTheoKhoaHocProvider
		{
			get
			{
				if (innerSqlThanhTraChamGiangTheoKhoaHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThanhTraChamGiangTheoKhoaHocProvider == null)
						{
							this.innerSqlThanhTraChamGiangTheoKhoaHocProvider = new SqlThanhTraChamGiangTheoKhoaHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThanhTraChamGiangTheoKhoaHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThanhTraChamGiangTheoKhoaHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThanhTraChamGiangTheoKhoaHocProvider SqlThanhTraChamGiangTheoKhoaHocProvider
		{
			get {return ThanhTraChamGiangTheoKhoaHocProvider as SqlThanhTraChamGiangTheoKhoaHocProvider;}
		}
		
		#endregion
		
		
		#region "SdhHeSoLopDongProvider"
			
		private SqlSdhHeSoLopDongProvider innerSqlSdhHeSoLopDongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhHeSoLopDong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhHeSoLopDongProviderBase SdhHeSoLopDongProvider
		{
			get
			{
				if (innerSqlSdhHeSoLopDongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhHeSoLopDongProvider == null)
						{
							this.innerSqlSdhHeSoLopDongProvider = new SqlSdhHeSoLopDongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhHeSoLopDongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhHeSoLopDongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhHeSoLopDongProvider SqlSdhHeSoLopDongProvider
		{
			get {return SdhHeSoLopDongProvider as SqlSdhHeSoLopDongProvider;}
		}
		
		#endregion
		
		
		#region "TaiKhoanProvider"
			
		private SqlTaiKhoanProvider innerSqlTaiKhoanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="TaiKhoan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override TaiKhoanProviderBase TaiKhoanProvider
		{
			get
			{
				if (innerSqlTaiKhoanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlTaiKhoanProvider == null)
						{
							this.innerSqlTaiKhoanProvider = new SqlTaiKhoanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlTaiKhoanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlTaiKhoanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlTaiKhoanProvider SqlTaiKhoanProvider
		{
			get {return TaiKhoanProvider as SqlTaiKhoanProvider;}
		}
		
		#endregion
		
		
		#region "ThoiGianNghiTamThoiCuaGiangVienProvider"
			
		private SqlThoiGianNghiTamThoiCuaGiangVienProvider innerSqlThoiGianNghiTamThoiCuaGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThoiGianNghiTamThoiCuaGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThoiGianNghiTamThoiCuaGiangVienProviderBase ThoiGianNghiTamThoiCuaGiangVienProvider
		{
			get
			{
				if (innerSqlThoiGianNghiTamThoiCuaGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThoiGianNghiTamThoiCuaGiangVienProvider == null)
						{
							this.innerSqlThoiGianNghiTamThoiCuaGiangVienProvider = new SqlThoiGianNghiTamThoiCuaGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThoiGianNghiTamThoiCuaGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThoiGianNghiTamThoiCuaGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThoiGianNghiTamThoiCuaGiangVienProvider SqlThoiGianNghiTamThoiCuaGiangVienProvider
		{
			get {return ThoiGianNghiTamThoiCuaGiangVienProvider as SqlThoiGianNghiTamThoiCuaGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ThueThanhToanBoSungProvider"
			
		private SqlThueThanhToanBoSungProvider innerSqlThueThanhToanBoSungProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThueThanhToanBoSung"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThueThanhToanBoSungProviderBase ThueThanhToanBoSungProvider
		{
			get
			{
				if (innerSqlThueThanhToanBoSungProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThueThanhToanBoSungProvider == null)
						{
							this.innerSqlThueThanhToanBoSungProvider = new SqlThueThanhToanBoSungProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThueThanhToanBoSungProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThueThanhToanBoSungProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThueThanhToanBoSungProvider SqlThueThanhToanBoSungProvider
		{
			get {return ThueThanhToanBoSungProvider as SqlThueThanhToanBoSungProvider;}
		}
		
		#endregion
		
		
		#region "ThoiGianLamViecCuaNhanVienProvider"
			
		private SqlThoiGianLamViecCuaNhanVienProvider innerSqlThoiGianLamViecCuaNhanVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThoiGianLamViecCuaNhanVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThoiGianLamViecCuaNhanVienProviderBase ThoiGianLamViecCuaNhanVienProvider
		{
			get
			{
				if (innerSqlThoiGianLamViecCuaNhanVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThoiGianLamViecCuaNhanVienProvider == null)
						{
							this.innerSqlThoiGianLamViecCuaNhanVienProvider = new SqlThoiGianLamViecCuaNhanVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThoiGianLamViecCuaNhanVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThoiGianLamViecCuaNhanVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThoiGianLamViecCuaNhanVienProvider SqlThoiGianLamViecCuaNhanVienProvider
		{
			get {return ThoiGianLamViecCuaNhanVienProvider as SqlThoiGianLamViecCuaNhanVienProvider;}
		}
		
		#endregion
		
		
		#region "SiSoLopHocPhanProvider"
			
		private SqlSiSoLopHocPhanProvider innerSqlSiSoLopHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SiSoLopHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SiSoLopHocPhanProviderBase SiSoLopHocPhanProvider
		{
			get
			{
				if (innerSqlSiSoLopHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSiSoLopHocPhanProvider == null)
						{
							this.innerSqlSiSoLopHocPhanProvider = new SqlSiSoLopHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSiSoLopHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSiSoLopHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSiSoLopHocPhanProvider SqlSiSoLopHocPhanProvider
		{
			get {return SiSoLopHocPhanProvider as SqlSiSoLopHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "BangPhuTroiNamHocProvider"
			
		private SqlBangPhuTroiNamHocProvider innerSqlBangPhuTroiNamHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="BangPhuTroiNamHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override BangPhuTroiNamHocProviderBase BangPhuTroiNamHocProvider
		{
			get
			{
				if (innerSqlBangPhuTroiNamHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlBangPhuTroiNamHocProvider == null)
						{
							this.innerSqlBangPhuTroiNamHocProvider = new SqlBangPhuTroiNamHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlBangPhuTroiNamHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlBangPhuTroiNamHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlBangPhuTroiNamHocProvider SqlBangPhuTroiNamHocProvider
		{
			get {return BangPhuTroiNamHocProvider as SqlBangPhuTroiNamHocProvider;}
		}
		
		#endregion
		
		
		#region "SdhLoaiKhoiLuongProvider"
			
		private SqlSdhLoaiKhoiLuongProvider innerSqlSdhLoaiKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="SdhLoaiKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override SdhLoaiKhoiLuongProviderBase SdhLoaiKhoiLuongProvider
		{
			get
			{
				if (innerSqlSdhLoaiKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlSdhLoaiKhoiLuongProvider == null)
						{
							this.innerSqlSdhLoaiKhoiLuongProvider = new SqlSdhLoaiKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlSdhLoaiKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlSdhLoaiKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlSdhLoaiKhoiLuongProvider SqlSdhLoaiKhoiLuongProvider
		{
			get {return SdhLoaiKhoiLuongProvider as SqlSdhLoaiKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "ThanhToanThinhGiangProvider"
			
		private SqlThanhToanThinhGiangProvider innerSqlThanhToanThinhGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThanhToanThinhGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThanhToanThinhGiangProviderBase ThanhToanThinhGiangProvider
		{
			get
			{
				if (innerSqlThanhToanThinhGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThanhToanThinhGiangProvider == null)
						{
							this.innerSqlThanhToanThinhGiangProvider = new SqlThanhToanThinhGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThanhToanThinhGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThanhToanThinhGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThanhToanThinhGiangProvider SqlThanhToanThinhGiangProvider
		{
			get {return ThanhToanThinhGiangProvider as SqlThanhToanThinhGiangProvider;}
		}
		
		#endregion
		
		
		#region "KetQuaCacKhoanChiKhacProvider"
			
		private SqlKetQuaCacKhoanChiKhacProvider innerSqlKetQuaCacKhoanChiKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KetQuaCacKhoanChiKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KetQuaCacKhoanChiKhacProviderBase KetQuaCacKhoanChiKhacProvider
		{
			get
			{
				if (innerSqlKetQuaCacKhoanChiKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKetQuaCacKhoanChiKhacProvider == null)
						{
							this.innerSqlKetQuaCacKhoanChiKhacProvider = new SqlKetQuaCacKhoanChiKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKetQuaCacKhoanChiKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKetQuaCacKhoanChiKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKetQuaCacKhoanChiKhacProvider SqlKetQuaCacKhoanChiKhacProvider
		{
			get {return KetQuaCacKhoanChiKhacProvider as SqlKetQuaCacKhoanChiKhacProvider;}
		}
		
		#endregion
		
		
		#region "ThanhTraTheoThoiKhoaBieuProvider"
			
		private SqlThanhTraTheoThoiKhoaBieuProvider innerSqlThanhTraTheoThoiKhoaBieuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThanhTraTheoThoiKhoaBieu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThanhTraTheoThoiKhoaBieuProviderBase ThanhTraTheoThoiKhoaBieuProvider
		{
			get
			{
				if (innerSqlThanhTraTheoThoiKhoaBieuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThanhTraTheoThoiKhoaBieuProvider == null)
						{
							this.innerSqlThanhTraTheoThoiKhoaBieuProvider = new SqlThanhTraTheoThoiKhoaBieuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThanhTraTheoThoiKhoaBieuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThanhTraTheoThoiKhoaBieuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThanhTraTheoThoiKhoaBieuProvider SqlThanhTraTheoThoiKhoaBieuProvider
		{
			get {return ThanhTraTheoThoiKhoaBieuProvider as SqlThanhTraTheoThoiKhoaBieuProvider;}
		}
		
		#endregion
		
		
		#region "KcqUteKhoiLuongGiangDayProvider"
			
		private SqlKcqUteKhoiLuongGiangDayProvider innerSqlKcqUteKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqUteKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqUteKhoiLuongGiangDayProviderBase KcqUteKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlKcqUteKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqUteKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlKcqUteKhoiLuongGiangDayProvider = new SqlKcqUteKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqUteKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqUteKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqUteKhoiLuongGiangDayProvider SqlKcqUteKhoiLuongGiangDayProvider
		{
			get {return KcqUteKhoiLuongGiangDayProvider as SqlKcqUteKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ThamDinhLuanVanThacSyProvider"
			
		private SqlThamDinhLuanVanThacSyProvider innerSqlThamDinhLuanVanThacSyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThamDinhLuanVanThacSy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThamDinhLuanVanThacSyProviderBase ThamDinhLuanVanThacSyProvider
		{
			get
			{
				if (innerSqlThamDinhLuanVanThacSyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThamDinhLuanVanThacSyProvider == null)
						{
							this.innerSqlThamDinhLuanVanThacSyProvider = new SqlThamDinhLuanVanThacSyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThamDinhLuanVanThacSyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThamDinhLuanVanThacSyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThamDinhLuanVanThacSyProvider SqlThamDinhLuanVanThacSyProvider
		{
			get {return ThamDinhLuanVanThacSyProvider as SqlThamDinhLuanVanThacSyProvider;}
		}
		
		#endregion
		
		
		#region "GiangDaySauDaiHocProvider"
			
		private SqlGiangDaySauDaiHocProvider innerSqlGiangDaySauDaiHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangDaySauDaiHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangDaySauDaiHocProviderBase GiangDaySauDaiHocProvider
		{
			get
			{
				if (innerSqlGiangDaySauDaiHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangDaySauDaiHocProvider == null)
						{
							this.innerSqlGiangDaySauDaiHocProvider = new SqlGiangDaySauDaiHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangDaySauDaiHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangDaySauDaiHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangDaySauDaiHocProvider SqlGiangDaySauDaiHocProvider
		{
			get {return GiangDaySauDaiHocProvider as SqlGiangDaySauDaiHocProvider;}
		}
		
		#endregion
		
		
		#region "KcqUteKhoiLuongKhacProvider"
			
		private SqlKcqUteKhoiLuongKhacProvider innerSqlKcqUteKhoiLuongKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqUteKhoiLuongKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqUteKhoiLuongKhacProviderBase KcqUteKhoiLuongKhacProvider
		{
			get
			{
				if (innerSqlKcqUteKhoiLuongKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqUteKhoiLuongKhacProvider == null)
						{
							this.innerSqlKcqUteKhoiLuongKhacProvider = new SqlKcqUteKhoiLuongKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqUteKhoiLuongKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqUteKhoiLuongKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqUteKhoiLuongKhacProvider SqlKcqUteKhoiLuongKhacProvider
		{
			get {return KcqUteKhoiLuongKhacProvider as SqlKcqUteKhoiLuongKhacProvider;}
		}
		
		#endregion
		
		
		#region "KcqPhanCongDoAnTotNghiepProvider"
			
		private SqlKcqPhanCongDoAnTotNghiepProvider innerSqlKcqPhanCongDoAnTotNghiepProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqPhanCongDoAnTotNghiep"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqPhanCongDoAnTotNghiepProviderBase KcqPhanCongDoAnTotNghiepProvider
		{
			get
			{
				if (innerSqlKcqPhanCongDoAnTotNghiepProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqPhanCongDoAnTotNghiepProvider == null)
						{
							this.innerSqlKcqPhanCongDoAnTotNghiepProvider = new SqlKcqPhanCongDoAnTotNghiepProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqPhanCongDoAnTotNghiepProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqPhanCongDoAnTotNghiepProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqPhanCongDoAnTotNghiepProvider SqlKcqPhanCongDoAnTotNghiepProvider
		{
			get {return KcqPhanCongDoAnTotNghiepProvider as SqlKcqPhanCongDoAnTotNghiepProvider;}
		}
		
		#endregion
		
		
		#region "DuTruGioGiangKhiCoLopHocPhanProvider"
			
		private SqlDuTruGioGiangKhiCoLopHocPhanProvider innerSqlDuTruGioGiangKhiCoLopHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DuTruGioGiangKhiCoLopHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DuTruGioGiangKhiCoLopHocPhanProviderBase DuTruGioGiangKhiCoLopHocPhanProvider
		{
			get
			{
				if (innerSqlDuTruGioGiangKhiCoLopHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDuTruGioGiangKhiCoLopHocPhanProvider == null)
						{
							this.innerSqlDuTruGioGiangKhiCoLopHocPhanProvider = new SqlDuTruGioGiangKhiCoLopHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDuTruGioGiangKhiCoLopHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDuTruGioGiangKhiCoLopHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDuTruGioGiangKhiCoLopHocPhanProvider SqlDuTruGioGiangKhiCoLopHocPhanProvider
		{
			get {return DuTruGioGiangKhiCoLopHocPhanProvider as SqlDuTruGioGiangKhiCoLopHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "DanhMucHoatDongQuanLyProvider"
			
		private SqlDanhMucHoatDongQuanLyProvider innerSqlDanhMucHoatDongQuanLyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DanhMucHoatDongQuanLy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DanhMucHoatDongQuanLyProviderBase DanhMucHoatDongQuanLyProvider
		{
			get
			{
				if (innerSqlDanhMucHoatDongQuanLyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDanhMucHoatDongQuanLyProvider == null)
						{
							this.innerSqlDanhMucHoatDongQuanLyProvider = new SqlDanhMucHoatDongQuanLyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDanhMucHoatDongQuanLyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDanhMucHoatDongQuanLyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDanhMucHoatDongQuanLyProvider SqlDanhMucHoatDongQuanLyProvider
		{
			get {return DanhMucHoatDongQuanLyProvider as SqlDanhMucHoatDongQuanLyProvider;}
		}
		
		#endregion
		
		
		#region "KcqQuyDoiGioChuanProvider"
			
		private SqlKcqQuyDoiGioChuanProvider innerSqlKcqQuyDoiGioChuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqQuyDoiGioChuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqQuyDoiGioChuanProviderBase KcqQuyDoiGioChuanProvider
		{
			get
			{
				if (innerSqlKcqQuyDoiGioChuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqQuyDoiGioChuanProvider == null)
						{
							this.innerSqlKcqQuyDoiGioChuanProvider = new SqlKcqQuyDoiGioChuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqQuyDoiGioChuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqQuyDoiGioChuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqQuyDoiGioChuanProvider SqlKcqQuyDoiGioChuanProvider
		{
			get {return KcqQuyDoiGioChuanProvider as SqlKcqQuyDoiGioChuanProvider;}
		}
		
		#endregion
		
		
		#region "HocHamProvider"
			
		private SqlHocHamProvider innerSqlHocHamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HocHam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HocHamProviderBase HocHamProvider
		{
			get
			{
				if (innerSqlHocHamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHocHamProvider == null)
						{
							this.innerSqlHocHamProvider = new SqlHocHamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHocHamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHocHamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHocHamProvider SqlHocHamProvider
		{
			get {return HocHamProvider as SqlHocHamProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienChuyenMonProvider"
			
		private SqlGiangVienChuyenMonProvider innerSqlGiangVienChuyenMonProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienChuyenMon"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienChuyenMonProviderBase GiangVienChuyenMonProvider
		{
			get
			{
				if (innerSqlGiangVienChuyenMonProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienChuyenMonProvider == null)
						{
							this.innerSqlGiangVienChuyenMonProvider = new SqlGiangVienChuyenMonProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienChuyenMonProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienChuyenMonProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienChuyenMonProvider SqlGiangVienChuyenMonProvider
		{
			get {return GiangVienChuyenMonProvider as SqlGiangVienChuyenMonProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienChucVuProvider"
			
		private SqlGiangVienChucVuProvider innerSqlGiangVienChucVuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienChucVu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienChucVuProviderBase GiangVienChucVuProvider
		{
			get
			{
				if (innerSqlGiangVienChucVuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienChucVuProvider == null)
						{
							this.innerSqlGiangVienChucVuProvider = new SqlGiangVienChucVuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienChucVuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienChucVuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienChucVuProvider SqlGiangVienChucVuProvider
		{
			get {return GiangVienChucVuProvider as SqlGiangVienChucVuProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienThanhToanQuaNganHangProvider"
			
		private SqlGiangVienThanhToanQuaNganHangProvider innerSqlGiangVienThanhToanQuaNganHangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienThanhToanQuaNganHang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienThanhToanQuaNganHangProviderBase GiangVienThanhToanQuaNganHangProvider
		{
			get
			{
				if (innerSqlGiangVienThanhToanQuaNganHangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienThanhToanQuaNganHangProvider == null)
						{
							this.innerSqlGiangVienThanhToanQuaNganHangProvider = new SqlGiangVienThanhToanQuaNganHangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienThanhToanQuaNganHangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienThanhToanQuaNganHangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienThanhToanQuaNganHangProvider SqlGiangVienThanhToanQuaNganHangProvider
		{
			get {return GiangVienThanhToanQuaNganHangProvider as SqlGiangVienThanhToanQuaNganHangProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienMocTangLuongProvider"
			
		private SqlGiangVienMocTangLuongProvider innerSqlGiangVienMocTangLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienMocTangLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienMocTangLuongProviderBase GiangVienMocTangLuongProvider
		{
			get
			{
				if (innerSqlGiangVienMocTangLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienMocTangLuongProvider == null)
						{
							this.innerSqlGiangVienMocTangLuongProvider = new SqlGiangVienMocTangLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienMocTangLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienMocTangLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienMocTangLuongProvider SqlGiangVienMocTangLuongProvider
		{
			get {return GiangVienMocTangLuongProvider as SqlGiangVienMocTangLuongProvider;}
		}
		
		#endregion
		
		
		#region "GiangDayChatLuongCaoProvider"
			
		private SqlGiangDayChatLuongCaoProvider innerSqlGiangDayChatLuongCaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangDayChatLuongCao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangDayChatLuongCaoProviderBase GiangDayChatLuongCaoProvider
		{
			get
			{
				if (innerSqlGiangDayChatLuongCaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangDayChatLuongCaoProvider == null)
						{
							this.innerSqlGiangDayChatLuongCaoProvider = new SqlGiangDayChatLuongCaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangDayChatLuongCaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangDayChatLuongCaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangDayChatLuongCaoProvider SqlGiangDayChatLuongCaoProvider
		{
			get {return GiangDayChatLuongCaoProvider as SqlGiangDayChatLuongCaoProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienKhongTinhGioGiangProvider"
			
		private SqlGiangVienKhongTinhGioGiangProvider innerSqlGiangVienKhongTinhGioGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienKhongTinhGioGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienKhongTinhGioGiangProviderBase GiangVienKhongTinhGioGiangProvider
		{
			get
			{
				if (innerSqlGiangVienKhongTinhGioGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienKhongTinhGioGiangProvider == null)
						{
							this.innerSqlGiangVienKhongTinhGioGiangProvider = new SqlGiangVienKhongTinhGioGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienKhongTinhGioGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienKhongTinhGioGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienKhongTinhGioGiangProvider SqlGiangVienKhongTinhGioGiangProvider
		{
			get {return GiangVienKhongTinhGioGiangProvider as SqlGiangVienKhongTinhGioGiangProvider;}
		}
		
		#endregion
		
		
		#region "GhiChuThanhToanBoSungProvider"
			
		private SqlGhiChuThanhToanBoSungProvider innerSqlGhiChuThanhToanBoSungProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GhiChuThanhToanBoSung"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GhiChuThanhToanBoSungProviderBase GhiChuThanhToanBoSungProvider
		{
			get
			{
				if (innerSqlGhiChuThanhToanBoSungProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGhiChuThanhToanBoSungProvider == null)
						{
							this.innerSqlGhiChuThanhToanBoSungProvider = new SqlGhiChuThanhToanBoSungProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGhiChuThanhToanBoSungProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGhiChuThanhToanBoSungProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGhiChuThanhToanBoSungProvider SqlGhiChuThanhToanBoSungProvider
		{
			get {return GhiChuThanhToanBoSungProvider as SqlGhiChuThanhToanBoSungProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienDinhMucKhauTruProvider"
			
		private SqlGiangVienDinhMucKhauTruProvider innerSqlGiangVienDinhMucKhauTruProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienDinhMucKhauTru"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienDinhMucKhauTruProviderBase GiangVienDinhMucKhauTruProvider
		{
			get
			{
				if (innerSqlGiangVienDinhMucKhauTruProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienDinhMucKhauTruProvider == null)
						{
							this.innerSqlGiangVienDinhMucKhauTruProvider = new SqlGiangVienDinhMucKhauTruProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienDinhMucKhauTruProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienDinhMucKhauTruProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienDinhMucKhauTruProvider SqlGiangVienDinhMucKhauTruProvider
		{
			get {return GiangVienDinhMucKhauTruProvider as SqlGiangVienDinhMucKhauTruProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienHoatDongNgoaiGiangDayProvider"
			
		private SqlGiangVienHoatDongNgoaiGiangDayProvider innerSqlGiangVienHoatDongNgoaiGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienHoatDongNgoaiGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienHoatDongNgoaiGiangDayProviderBase GiangVienHoatDongNgoaiGiangDayProvider
		{
			get
			{
				if (innerSqlGiangVienHoatDongNgoaiGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienHoatDongNgoaiGiangDayProvider == null)
						{
							this.innerSqlGiangVienHoatDongNgoaiGiangDayProvider = new SqlGiangVienHoatDongNgoaiGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienHoatDongNgoaiGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienHoatDongNgoaiGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienHoatDongNgoaiGiangDayProvider SqlGiangVienHoatDongNgoaiGiangDayProvider
		{
			get {return GiangVienHoatDongNgoaiGiangDayProvider as SqlGiangVienHoatDongNgoaiGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "GiamTruDinhMucProvider"
			
		private SqlGiamTruDinhMucProvider innerSqlGiamTruDinhMucProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiamTruDinhMuc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiamTruDinhMucProviderBase GiamTruDinhMucProvider
		{
			get
			{
				if (innerSqlGiamTruDinhMucProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiamTruDinhMucProvider == null)
						{
							this.innerSqlGiamTruDinhMucProvider = new SqlGiamTruDinhMucProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiamTruDinhMucProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiamTruDinhMucProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiamTruDinhMucProvider SqlGiamTruDinhMucProvider
		{
			get {return GiamTruDinhMucProvider as SqlGiamTruDinhMucProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienLopHocPhanProvider"
			
		private SqlGiangVienLopHocPhanProvider innerSqlGiangVienLopHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienLopHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienLopHocPhanProviderBase GiangVienLopHocPhanProvider
		{
			get
			{
				if (innerSqlGiangVienLopHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienLopHocPhanProvider == null)
						{
							this.innerSqlGiangVienLopHocPhanProvider = new SqlGiangVienLopHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienLopHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienLopHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienLopHocPhanProvider SqlGiangVienLopHocPhanProvider
		{
			get {return GiangVienLopHocPhanProvider as SqlGiangVienLopHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienThayDoiHocHamProvider"
			
		private SqlGiangVienThayDoiHocHamProvider innerSqlGiangVienThayDoiHocHamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienThayDoiHocHam"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienThayDoiHocHamProviderBase GiangVienThayDoiHocHamProvider
		{
			get
			{
				if (innerSqlGiangVienThayDoiHocHamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienThayDoiHocHamProvider == null)
						{
							this.innerSqlGiangVienThayDoiHocHamProvider = new SqlGiangVienThayDoiHocHamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienThayDoiHocHamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienThayDoiHocHamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienThayDoiHocHamProvider SqlGiangVienThayDoiHocHamProvider
		{
			get {return GiangVienThayDoiHocHamProvider as SqlGiangVienThayDoiHocHamProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienChoDuyetHoSoProvider"
			
		private SqlGiangVienChoDuyetHoSoProvider innerSqlGiangVienChoDuyetHoSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienChoDuyetHoSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienChoDuyetHoSoProviderBase GiangVienChoDuyetHoSoProvider
		{
			get
			{
				if (innerSqlGiangVienChoDuyetHoSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienChoDuyetHoSoProvider == null)
						{
							this.innerSqlGiangVienChoDuyetHoSoProvider = new SqlGiangVienChoDuyetHoSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienChoDuyetHoSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienChoDuyetHoSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienChoDuyetHoSoProvider SqlGiangVienChoDuyetHoSoProvider
		{
			get {return GiangVienChoDuyetHoSoProvider as SqlGiangVienChoDuyetHoSoProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienBiChanTienProvider"
			
		private SqlGiangVienBiChanTienProvider innerSqlGiangVienBiChanTienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienBiChanTien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienBiChanTienProviderBase GiangVienBiChanTienProvider
		{
			get
			{
				if (innerSqlGiangVienBiChanTienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienBiChanTienProvider == null)
						{
							this.innerSqlGiangVienBiChanTienProvider = new SqlGiangVienBiChanTienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienBiChanTienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienBiChanTienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienBiChanTienProvider SqlGiangVienBiChanTienProvider
		{
			get {return GiangVienBiChanTienProvider as SqlGiangVienBiChanTienProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienTinhGioChuanProvider"
			
		private SqlGiangVienTinhGioChuanProvider innerSqlGiangVienTinhGioChuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienTinhGioChuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienTinhGioChuanProviderBase GiangVienTinhGioChuanProvider
		{
			get
			{
				if (innerSqlGiangVienTinhGioChuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienTinhGioChuanProvider == null)
						{
							this.innerSqlGiangVienTinhGioChuanProvider = new SqlGiangVienTinhGioChuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienTinhGioChuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienTinhGioChuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienTinhGioChuanProvider SqlGiangVienTinhGioChuanProvider
		{
			get {return GiangVienTinhGioChuanProvider as SqlGiangVienTinhGioChuanProvider;}
		}
		
		#endregion
		
		
		#region "NgachCongChucProvider"
			
		private SqlNgachCongChucProvider innerSqlNgachCongChucProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NgachCongChuc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NgachCongChucProviderBase NgachCongChucProvider
		{
			get
			{
				if (innerSqlNgachCongChucProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNgachCongChucProvider == null)
						{
							this.innerSqlNgachCongChucProvider = new SqlNgachCongChucProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNgachCongChucProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNgachCongChucProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNgachCongChucProvider SqlNgachCongChucProvider
		{
			get {return NgachCongChucProvider as SqlNgachCongChucProvider;}
		}
		
		#endregion
		
		
		#region "DinhMucGioChuanProvider"
			
		private SqlDinhMucGioChuanProvider innerSqlDinhMucGioChuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DinhMucGioChuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DinhMucGioChuanProviderBase DinhMucGioChuanProvider
		{
			get
			{
				if (innerSqlDinhMucGioChuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDinhMucGioChuanProvider == null)
						{
							this.innerSqlDinhMucGioChuanProvider = new SqlDinhMucGioChuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDinhMucGioChuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDinhMucGioChuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDinhMucGioChuanProvider SqlDinhMucGioChuanProvider
		{
			get {return DinhMucGioChuanProvider as SqlDinhMucGioChuanProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienTamUngChiTietProvider"
			
		private SqlGiangVienTamUngChiTietProvider innerSqlGiangVienTamUngChiTietProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienTamUngChiTiet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienTamUngChiTietProviderBase GiangVienTamUngChiTietProvider
		{
			get
			{
				if (innerSqlGiangVienTamUngChiTietProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienTamUngChiTietProvider == null)
						{
							this.innerSqlGiangVienTamUngChiTietProvider = new SqlGiangVienTamUngChiTietProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienTamUngChiTietProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienTamUngChiTietProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienTamUngChiTietProvider SqlGiangVienTamUngChiTietProvider
		{
			get {return GiangVienTamUngChiTietProvider as SqlGiangVienTamUngChiTietProvider;}
		}
		
		#endregion
		
		
		#region "HocViProvider"
			
		private SqlHocViProvider innerSqlHocViProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HocVi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HocViProviderBase HocViProvider
		{
			get
			{
				if (innerSqlHocViProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHocViProvider == null)
						{
							this.innerSqlHocViProvider = new SqlHocViProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHocViProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHocViProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHocViProvider SqlHocViProvider
		{
			get {return HocViProvider as SqlHocViProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienThayDoiLoaiGiangVienProvider"
			
		private SqlGiangVienThayDoiLoaiGiangVienProvider innerSqlGiangVienThayDoiLoaiGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienThayDoiLoaiGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienThayDoiLoaiGiangVienProviderBase GiangVienThayDoiLoaiGiangVienProvider
		{
			get
			{
				if (innerSqlGiangVienThayDoiLoaiGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienThayDoiLoaiGiangVienProvider == null)
						{
							this.innerSqlGiangVienThayDoiLoaiGiangVienProvider = new SqlGiangVienThayDoiLoaiGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienThayDoiLoaiGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienThayDoiLoaiGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienThayDoiLoaiGiangVienProvider SqlGiangVienThayDoiLoaiGiangVienProvider
		{
			get {return GiangVienThayDoiLoaiGiangVienProvider as SqlGiangVienThayDoiLoaiGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienGiamTruDinhMucProvider"
			
		private SqlGiangVienGiamTruDinhMucProvider innerSqlGiangVienGiamTruDinhMucProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienGiamTruDinhMuc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienGiamTruDinhMucProviderBase GiangVienGiamTruDinhMucProvider
		{
			get
			{
				if (innerSqlGiangVienGiamTruDinhMucProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienGiamTruDinhMucProvider == null)
						{
							this.innerSqlGiangVienGiamTruDinhMucProvider = new SqlGiangVienGiamTruDinhMucProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienGiamTruDinhMucProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienGiamTruDinhMucProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienGiamTruDinhMucProvider SqlGiangVienGiamTruDinhMucProvider
		{
			get {return GiangVienGiamTruDinhMucProvider as SqlGiangVienGiamTruDinhMucProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienCamKetKhongTruThueProvider"
			
		private SqlGiangVienCamKetKhongTruThueProvider innerSqlGiangVienCamKetKhongTruThueProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienCamKetKhongTruThue"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienCamKetKhongTruThueProviderBase GiangVienCamKetKhongTruThueProvider
		{
			get
			{
				if (innerSqlGiangVienCamKetKhongTruThueProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienCamKetKhongTruThueProvider == null)
						{
							this.innerSqlGiangVienCamKetKhongTruThueProvider = new SqlGiangVienCamKetKhongTruThueProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienCamKetKhongTruThueProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienCamKetKhongTruThueProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienCamKetKhongTruThueProvider SqlGiangVienCamKetKhongTruThueProvider
		{
			get {return GiangVienCamKetKhongTruThueProvider as SqlGiangVienCamKetKhongTruThueProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienPhanHoiProvider"
			
		private SqlGiangVienPhanHoiProvider innerSqlGiangVienPhanHoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienPhanHoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienPhanHoiProviderBase GiangVienPhanHoiProvider
		{
			get
			{
				if (innerSqlGiangVienPhanHoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienPhanHoiProvider == null)
						{
							this.innerSqlGiangVienPhanHoiProvider = new SqlGiangVienPhanHoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienPhanHoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienPhanHoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienPhanHoiProvider SqlGiangVienPhanHoiProvider
		{
			get {return GiangVienPhanHoiProvider as SqlGiangVienPhanHoiProvider;}
		}
		
		#endregion
		
		
		#region "DuTruGioGiangTruocLopHocPhanProvider"
			
		private SqlDuTruGioGiangTruocLopHocPhanProvider innerSqlDuTruGioGiangTruocLopHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DuTruGioGiangTruocLopHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DuTruGioGiangTruocLopHocPhanProviderBase DuTruGioGiangTruocLopHocPhanProvider
		{
			get
			{
				if (innerSqlDuTruGioGiangTruocLopHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDuTruGioGiangTruocLopHocPhanProvider == null)
						{
							this.innerSqlDuTruGioGiangTruocLopHocPhanProvider = new SqlDuTruGioGiangTruocLopHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDuTruGioGiangTruocLopHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDuTruGioGiangTruocLopHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDuTruGioGiangTruocLopHocPhanProvider SqlDuTruGioGiangTruocLopHocPhanProvider
		{
			get {return DuTruGioGiangTruocLopHocPhanProvider as SqlDuTruGioGiangTruocLopHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienTinhLuongThinhGiangProvider"
			
		private SqlGiangVienTinhLuongThinhGiangProvider innerSqlGiangVienTinhLuongThinhGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienTinhLuongThinhGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienTinhLuongThinhGiangProviderBase GiangVienTinhLuongThinhGiangProvider
		{
			get
			{
				if (innerSqlGiangVienTinhLuongThinhGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienTinhLuongThinhGiangProvider == null)
						{
							this.innerSqlGiangVienTinhLuongThinhGiangProvider = new SqlGiangVienTinhLuongThinhGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienTinhLuongThinhGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienTinhLuongThinhGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienTinhLuongThinhGiangProvider SqlGiangVienTinhLuongThinhGiangProvider
		{
			get {return GiangVienTinhLuongThinhGiangProvider as SqlGiangVienTinhLuongThinhGiangProvider;}
		}
		
		#endregion
		
		
		#region "DinhMucNghienCuuKhoaHocProvider"
			
		private SqlDinhMucNghienCuuKhoaHocProvider innerSqlDinhMucNghienCuuKhoaHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DinhMucNghienCuuKhoaHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DinhMucNghienCuuKhoaHocProviderBase DinhMucNghienCuuKhoaHocProvider
		{
			get
			{
				if (innerSqlDinhMucNghienCuuKhoaHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDinhMucNghienCuuKhoaHocProvider == null)
						{
							this.innerSqlDinhMucNghienCuuKhoaHocProvider = new SqlDinhMucNghienCuuKhoaHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDinhMucNghienCuuKhoaHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDinhMucNghienCuuKhoaHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDinhMucNghienCuuKhoaHocProvider SqlDinhMucNghienCuuKhoaHocProvider
		{
			get {return DinhMucNghienCuuKhoaHocProvider as SqlDinhMucNghienCuuKhoaHocProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienNghienCuuKhProvider"
			
		private SqlGiangVienNghienCuuKhProvider innerSqlGiangVienNghienCuuKhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienNghienCuuKh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienNghienCuuKhProviderBase GiangVienNghienCuuKhProvider
		{
			get
			{
				if (innerSqlGiangVienNghienCuuKhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienNghienCuuKhProvider == null)
						{
							this.innerSqlGiangVienNghienCuuKhProvider = new SqlGiangVienNghienCuuKhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienNghienCuuKhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienNghienCuuKhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienNghienCuuKhProvider SqlGiangVienNghienCuuKhProvider
		{
			get {return GiangVienNghienCuuKhProvider as SqlGiangVienNghienCuuKhProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienHoSoProvider"
			
		private SqlGiangVienHoSoProvider innerSqlGiangVienHoSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienHoSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienHoSoProviderBase GiangVienHoSoProvider
		{
			get
			{
				if (innerSqlGiangVienHoSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienHoSoProvider == null)
						{
							this.innerSqlGiangVienHoSoProvider = new SqlGiangVienHoSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienHoSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienHoSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienHoSoProvider SqlGiangVienHoSoProvider
		{
			get {return GiangVienHoSoProvider as SqlGiangVienHoSoProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienThayDoiChucVuProvider"
			
		private SqlGiangVienThayDoiChucVuProvider innerSqlGiangVienThayDoiChucVuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienThayDoiChucVu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienThayDoiChucVuProviderBase GiangVienThayDoiChucVuProvider
		{
			get
			{
				if (innerSqlGiangVienThayDoiChucVuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienThayDoiChucVuProvider == null)
						{
							this.innerSqlGiangVienThayDoiChucVuProvider = new SqlGiangVienThayDoiChucVuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienThayDoiChucVuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienThayDoiChucVuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienThayDoiChucVuProvider SqlGiangVienThayDoiChucVuProvider
		{
			get {return GiangVienThayDoiChucVuProvider as SqlGiangVienThayDoiChucVuProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienHoatDongQuanLyProvider"
			
		private SqlGiangVienHoatDongQuanLyProvider innerSqlGiangVienHoatDongQuanLyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienHoatDongQuanLy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienHoatDongQuanLyProviderBase GiangVienHoatDongQuanLyProvider
		{
			get
			{
				if (innerSqlGiangVienHoatDongQuanLyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienHoatDongQuanLyProvider == null)
						{
							this.innerSqlGiangVienHoatDongQuanLyProvider = new SqlGiangVienHoatDongQuanLyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienHoatDongQuanLyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienHoatDongQuanLyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienHoatDongQuanLyProvider SqlGiangVienHoatDongQuanLyProvider
		{
			get {return GiangVienHoatDongQuanLyProvider as SqlGiangVienHoatDongQuanLyProvider;}
		}
		
		#endregion
		
		
		#region "DinhMucHuongDanKhoaLuanThucTapProvider"
			
		private SqlDinhMucHuongDanKhoaLuanThucTapProvider innerSqlDinhMucHuongDanKhoaLuanThucTapProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DinhMucHuongDanKhoaLuanThucTap"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DinhMucHuongDanKhoaLuanThucTapProviderBase DinhMucHuongDanKhoaLuanThucTapProvider
		{
			get
			{
				if (innerSqlDinhMucHuongDanKhoaLuanThucTapProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDinhMucHuongDanKhoaLuanThucTapProvider == null)
						{
							this.innerSqlDinhMucHuongDanKhoaLuanThucTapProvider = new SqlDinhMucHuongDanKhoaLuanThucTapProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDinhMucHuongDanKhoaLuanThucTapProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDinhMucHuongDanKhoaLuanThucTapProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDinhMucHuongDanKhoaLuanThucTapProvider SqlDinhMucHuongDanKhoaLuanThucTapProvider
		{
			get {return DinhMucHuongDanKhoaLuanThucTapProvider as SqlDinhMucHuongDanKhoaLuanThucTapProvider;}
		}
		
		#endregion
		
		
		#region "GiamTruGioChuanProvider"
			
		private SqlGiamTruGioChuanProvider innerSqlGiamTruGioChuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiamTruGioChuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiamTruGioChuanProviderBase GiamTruGioChuanProvider
		{
			get
			{
				if (innerSqlGiamTruGioChuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiamTruGioChuanProvider == null)
						{
							this.innerSqlGiamTruGioChuanProvider = new SqlGiamTruGioChuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiamTruGioChuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiamTruGioChuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiamTruGioChuanProvider SqlGiamTruGioChuanProvider
		{
			get {return GiamTruGioChuanProvider as SqlGiamTruGioChuanProvider;}
		}
		
		#endregion
		
		
		#region "ChotCoVanHocTapProvider"
			
		private SqlChotCoVanHocTapProvider innerSqlChotCoVanHocTapProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ChotCoVanHocTap"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ChotCoVanHocTapProviderBase ChotCoVanHocTapProvider
		{
			get
			{
				if (innerSqlChotCoVanHocTapProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlChotCoVanHocTapProvider == null)
						{
							this.innerSqlChotCoVanHocTapProvider = new SqlChotCoVanHocTapProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlChotCoVanHocTapProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlChotCoVanHocTapProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlChotCoVanHocTapProvider SqlChotCoVanHocTapProvider
		{
			get {return ChotCoVanHocTapProvider as SqlChotCoVanHocTapProvider;}
		}
		
		#endregion
		
		
		#region "ChotKhoiLuongGiangDayProvider"
			
		private SqlChotKhoiLuongGiangDayProvider innerSqlChotKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ChotKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ChotKhoiLuongGiangDayProviderBase ChotKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlChotKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlChotKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlChotKhoiLuongGiangDayProvider = new SqlChotKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlChotKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlChotKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlChotKhoiLuongGiangDayProvider SqlChotKhoiLuongGiangDayProvider
		{
			get {return ChotKhoiLuongGiangDayProvider as SqlChotKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ChucVuProvider"
			
		private SqlChucVuProvider innerSqlChucVuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ChucVu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ChucVuProviderBase ChucVuProvider
		{
			get
			{
				if (innerSqlChucVuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlChucVuProvider == null)
						{
							this.innerSqlChucVuProvider = new SqlChucVuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlChucVuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlChucVuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlChucVuProvider SqlChucVuProvider
		{
			get {return ChucVuProvider as SqlChucVuProvider;}
		}
		
		#endregion
		
		
		#region "DonGiaProvider"
			
		private SqlDonGiaProvider innerSqlDonGiaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DonGia"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DonGiaProviderBase DonGiaProvider
		{
			get
			{
				if (innerSqlDonGiaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDonGiaProvider == null)
						{
							this.innerSqlDonGiaProvider = new SqlDonGiaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDonGiaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDonGiaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDonGiaProvider SqlDonGiaProvider
		{
			get {return DonGiaProvider as SqlDonGiaProvider;}
		}
		
		#endregion
		
		
		#region "CoVanHocTapProvider"
			
		private SqlCoVanHocTapProvider innerSqlCoVanHocTapProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CoVanHocTap"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CoVanHocTapProviderBase CoVanHocTapProvider
		{
			get
			{
				if (innerSqlCoVanHocTapProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCoVanHocTapProvider == null)
						{
							this.innerSqlCoVanHocTapProvider = new SqlCoVanHocTapProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCoVanHocTapProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCoVanHocTapProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCoVanHocTapProvider SqlCoVanHocTapProvider
		{
			get {return CoVanHocTapProvider as SqlCoVanHocTapProvider;}
		}
		
		#endregion
		
		
		#region "ChiTietKhoiLuongProvider"
			
		private SqlChiTietKhoiLuongProvider innerSqlChiTietKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ChiTietKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ChiTietKhoiLuongProviderBase ChiTietKhoiLuongProvider
		{
			get
			{
				if (innerSqlChiTietKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlChiTietKhoiLuongProvider == null)
						{
							this.innerSqlChiTietKhoiLuongProvider = new SqlChiTietKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlChiTietKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlChiTietKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlChiTietKhoiLuongProvider SqlChiTietKhoiLuongProvider
		{
			get {return ChiTietKhoiLuongProvider as SqlChiTietKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "CauHinhChungProvider"
			
		private SqlCauHinhChungProvider innerSqlCauHinhChungProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CauHinhChung"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CauHinhChungProviderBase CauHinhChungProvider
		{
			get
			{
				if (innerSqlCauHinhChungProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCauHinhChungProvider == null)
						{
							this.innerSqlCauHinhChungProvider = new SqlCauHinhChungProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCauHinhChungProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCauHinhChungProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCauHinhChungProvider SqlCauHinhChungProvider
		{
			get {return CauHinhChungProvider as SqlCauHinhChungProvider;}
		}
		
		#endregion
		
		
		#region "DanhGiaCoVanHocTapProvider"
			
		private SqlDanhGiaCoVanHocTapProvider innerSqlDanhGiaCoVanHocTapProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DanhGiaCoVanHocTap"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DanhGiaCoVanHocTapProviderBase DanhGiaCoVanHocTapProvider
		{
			get
			{
				if (innerSqlDanhGiaCoVanHocTapProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDanhGiaCoVanHocTapProvider == null)
						{
							this.innerSqlDanhGiaCoVanHocTapProvider = new SqlDanhGiaCoVanHocTapProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDanhGiaCoVanHocTapProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDanhGiaCoVanHocTapProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDanhGiaCoVanHocTapProvider SqlDanhGiaCoVanHocTapProvider
		{
			get {return DanhGiaCoVanHocTapProvider as SqlDanhGiaCoVanHocTapProvider;}
		}
		
		#endregion
		
		
		#region "ChucNangProvider"
			
		private SqlChucNangProvider innerSqlChucNangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ChucNang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ChucNangProviderBase ChucNangProvider
		{
			get
			{
				if (innerSqlChucNangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlChucNangProvider == null)
						{
							this.innerSqlChucNangProvider = new SqlChucNangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlChucNangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlChucNangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlChucNangProvider SqlChucNangProvider
		{
			get {return ChucNangProvider as SqlChucNangProvider;}
		}
		
		#endregion
		
		
		#region "NghienCuuKhoaHocTongHopProvider"
			
		private SqlNghienCuuKhoaHocTongHopProvider innerSqlNghienCuuKhoaHocTongHopProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="NghienCuuKhoaHocTongHop"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override NghienCuuKhoaHocTongHopProviderBase NghienCuuKhoaHocTongHopProvider
		{
			get
			{
				if (innerSqlNghienCuuKhoaHocTongHopProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlNghienCuuKhoaHocTongHopProvider == null)
						{
							this.innerSqlNghienCuuKhoaHocTongHopProvider = new SqlNghienCuuKhoaHocTongHopProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlNghienCuuKhoaHocTongHopProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlNghienCuuKhoaHocTongHopProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlNghienCuuKhoaHocTongHopProvider SqlNghienCuuKhoaHocTongHopProvider
		{
			get {return NghienCuuKhoaHocTongHopProvider as SqlNghienCuuKhoaHocTongHopProvider;}
		}
		
		#endregion
		
		
		#region "CauHinhProvider"
			
		private SqlCauHinhProvider innerSqlCauHinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CauHinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CauHinhProviderBase CauHinhProvider
		{
			get
			{
				if (innerSqlCauHinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCauHinhProvider == null)
						{
							this.innerSqlCauHinhProvider = new SqlCauHinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCauHinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCauHinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCauHinhProvider SqlCauHinhProvider
		{
			get {return CauHinhProvider as SqlCauHinhProvider;}
		}
		
		#endregion
		
		
		#region "DonGiaChatLuongCaoProvider"
			
		private SqlDonGiaChatLuongCaoProvider innerSqlDonGiaChatLuongCaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DonGiaChatLuongCao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DonGiaChatLuongCaoProviderBase DonGiaChatLuongCaoProvider
		{
			get
			{
				if (innerSqlDonGiaChatLuongCaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDonGiaChatLuongCaoProvider == null)
						{
							this.innerSqlDonGiaChatLuongCaoProvider = new SqlDonGiaChatLuongCaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDonGiaChatLuongCaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDonGiaChatLuongCaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDonGiaChatLuongCaoProvider SqlDonGiaChatLuongCaoProvider
		{
			get {return DonGiaChatLuongCaoProvider as SqlDonGiaChatLuongCaoProvider;}
		}
		
		#endregion
		
		
		#region "CauHinhChotGioProvider"
			
		private SqlCauHinhChotGioProvider innerSqlCauHinhChotGioProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CauHinhChotGio"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CauHinhChotGioProviderBase CauHinhChotGioProvider
		{
			get
			{
				if (innerSqlCauHinhChotGioProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCauHinhChotGioProvider == null)
						{
							this.innerSqlCauHinhChotGioProvider = new SqlCauHinhChotGioProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCauHinhChotGioProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCauHinhChotGioProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCauHinhChotGioProvider SqlCauHinhChotGioProvider
		{
			get {return CauHinhChotGioProvider as SqlCauHinhChotGioProvider;}
		}
		
		#endregion
		
		
		#region "CauHinhGiangVienPhanHoiProvider"
			
		private SqlCauHinhGiangVienPhanHoiProvider innerSqlCauHinhGiangVienPhanHoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CauHinhGiangVienPhanHoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CauHinhGiangVienPhanHoiProviderBase CauHinhGiangVienPhanHoiProvider
		{
			get
			{
				if (innerSqlCauHinhGiangVienPhanHoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCauHinhGiangVienPhanHoiProvider == null)
						{
							this.innerSqlCauHinhGiangVienPhanHoiProvider = new SqlCauHinhGiangVienPhanHoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCauHinhGiangVienPhanHoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCauHinhGiangVienPhanHoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCauHinhGiangVienPhanHoiProvider SqlCauHinhGiangVienPhanHoiProvider
		{
			get {return CauHinhGiangVienPhanHoiProvider as SqlCauHinhGiangVienPhanHoiProvider;}
		}
		
		#endregion
		
		
		#region "BacLuongProvider"
			
		private SqlBacLuongProvider innerSqlBacLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="BacLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override BacLuongProviderBase BacLuongProvider
		{
			get
			{
				if (innerSqlBacLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlBacLuongProvider == null)
						{
							this.innerSqlBacLuongProvider = new SqlBacLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlBacLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlBacLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlBacLuongProvider SqlBacLuongProvider
		{
			get {return BacLuongProvider as SqlBacLuongProvider;}
		}
		
		#endregion
		
		
		#region "DonGiaChamBaiProvider"
			
		private SqlDonGiaChamBaiProvider innerSqlDonGiaChamBaiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DonGiaChamBai"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DonGiaChamBaiProviderBase DonGiaChamBaiProvider
		{
			get
			{
				if (innerSqlDonGiaChamBaiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDonGiaChamBaiProvider == null)
						{
							this.innerSqlDonGiaChamBaiProvider = new SqlDonGiaChamBaiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDonGiaChamBaiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDonGiaChamBaiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDonGiaChamBaiProvider SqlDonGiaChamBaiProvider
		{
			get {return DonGiaChamBaiProvider as SqlDonGiaChamBaiProvider;}
		}
		
		#endregion
		
		
		#region "DanhMucNghienCuuKhoaHocProvider"
			
		private SqlDanhMucNghienCuuKhoaHocProvider innerSqlDanhMucNghienCuuKhoaHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DanhMucNghienCuuKhoaHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DanhMucNghienCuuKhoaHocProviderBase DanhMucNghienCuuKhoaHocProvider
		{
			get
			{
				if (innerSqlDanhMucNghienCuuKhoaHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDanhMucNghienCuuKhoaHocProvider == null)
						{
							this.innerSqlDanhMucNghienCuuKhoaHocProvider = new SqlDanhMucNghienCuuKhoaHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDanhMucNghienCuuKhoaHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDanhMucNghienCuuKhoaHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDanhMucNghienCuuKhoaHocProvider SqlDanhMucNghienCuuKhoaHocProvider
		{
			get {return DanhMucNghienCuuKhoaHocProvider as SqlDanhMucNghienCuuKhoaHocProvider;}
		}
		
		#endregion
		
		
		#region "DonGiaTcbProvider"
			
		private SqlDonGiaTcbProvider innerSqlDonGiaTcbProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DonGiaTcb"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DonGiaTcbProviderBase DonGiaTcbProvider
		{
			get
			{
				if (innerSqlDonGiaTcbProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDonGiaTcbProvider == null)
						{
							this.innerSqlDonGiaTcbProvider = new SqlDonGiaTcbProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDonGiaTcbProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDonGiaTcbProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDonGiaTcbProvider SqlDonGiaTcbProvider
		{
			get {return DonGiaTcbProvider as SqlDonGiaTcbProvider;}
		}
		
		#endregion
		
		
		#region "DotChiTraProvider"
			
		private SqlDotChiTraProvider innerSqlDotChiTraProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DotChiTra"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DotChiTraProviderBase DotChiTraProvider
		{
			get
			{
				if (innerSqlDotChiTraProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDotChiTraProvider == null)
						{
							this.innerSqlDotChiTraProvider = new SqlDotChiTraProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDotChiTraProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDotChiTraProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDotChiTraProvider SqlDotChiTraProvider
		{
			get {return DotChiTraProvider as SqlDotChiTraProvider;}
		}
		
		#endregion
		
		
		#region "DonGiaMotTietProvider"
			
		private SqlDonGiaMotTietProvider innerSqlDonGiaMotTietProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DonGiaMotTiet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DonGiaMotTietProviderBase DonGiaMotTietProvider
		{
			get
			{
				if (innerSqlDonGiaMotTietProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDonGiaMotTietProvider == null)
						{
							this.innerSqlDonGiaMotTietProvider = new SqlDonGiaMotTietProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDonGiaMotTietProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDonGiaMotTietProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDonGiaMotTietProvider SqlDonGiaMotTietProvider
		{
			get {return DonGiaMotTietProvider as SqlDonGiaMotTietProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienThayDoiHocViProvider"
			
		private SqlGiangVienThayDoiHocViProvider innerSqlGiangVienThayDoiHocViProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienThayDoiHocVi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienThayDoiHocViProviderBase GiangVienThayDoiHocViProvider
		{
			get
			{
				if (innerSqlGiangVienThayDoiHocViProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienThayDoiHocViProvider == null)
						{
							this.innerSqlGiangVienThayDoiHocViProvider = new SqlGiangVienThayDoiHocViProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienThayDoiHocViProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienThayDoiHocViProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienThayDoiHocViProvider SqlGiangVienThayDoiHocViProvider
		{
			get {return GiangVienThayDoiHocViProvider as SqlGiangVienThayDoiHocViProvider;}
		}
		
		#endregion
		
		
		#region "DonGiaNgoaiQuyCheProvider"
			
		private SqlDonGiaNgoaiQuyCheProvider innerSqlDonGiaNgoaiQuyCheProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DonGiaNgoaiQuyChe"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DonGiaNgoaiQuyCheProviderBase DonGiaNgoaiQuyCheProvider
		{
			get
			{
				if (innerSqlDonGiaNgoaiQuyCheProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDonGiaNgoaiQuyCheProvider == null)
						{
							this.innerSqlDonGiaNgoaiQuyCheProvider = new SqlDonGiaNgoaiQuyCheProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDonGiaNgoaiQuyCheProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDonGiaNgoaiQuyCheProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDonGiaNgoaiQuyCheProvider SqlDonGiaNgoaiQuyCheProvider
		{
			get {return DonGiaNgoaiQuyCheProvider as SqlDonGiaNgoaiQuyCheProvider;}
		}
		
		#endregion
		
		
		#region "DanhSachHopDongThinhGiangProvider"
			
		private SqlDanhSachHopDongThinhGiangProvider innerSqlDanhSachHopDongThinhGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DanhSachHopDongThinhGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DanhSachHopDongThinhGiangProviderBase DanhSachHopDongThinhGiangProvider
		{
			get
			{
				if (innerSqlDanhSachHopDongThinhGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDanhSachHopDongThinhGiangProvider == null)
						{
							this.innerSqlDanhSachHopDongThinhGiangProvider = new SqlDanhSachHopDongThinhGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDanhSachHopDongThinhGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDanhSachHopDongThinhGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDanhSachHopDongThinhGiangProvider SqlDanhSachHopDongThinhGiangProvider
		{
			get {return DanhSachHopDongThinhGiangProvider as SqlDanhSachHopDongThinhGiangProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienChuyenDoiGioGiangProvider"
			
		private SqlGiangVienChuyenDoiGioGiangProvider innerSqlGiangVienChuyenDoiGioGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienChuyenDoiGioGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienChuyenDoiGioGiangProviderBase GiangVienChuyenDoiGioGiangProvider
		{
			get
			{
				if (innerSqlGiangVienChuyenDoiGioGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienChuyenDoiGioGiangProvider == null)
						{
							this.innerSqlGiangVienChuyenDoiGioGiangProvider = new SqlGiangVienChuyenDoiGioGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienChuyenDoiGioGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienChuyenDoiGioGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienChuyenDoiGioGiangProvider SqlGiangVienChuyenDoiGioGiangProvider
		{
			get {return GiangVienChuyenDoiGioGiangProvider as SqlGiangVienChuyenDoiGioGiangProvider;}
		}
		
		#endregion
		
		
		#region "DanhMucViPhamProvider"
			
		private SqlDanhMucViPhamProvider innerSqlDanhMucViPhamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DanhMucViPham"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DanhMucViPhamProviderBase DanhMucViPhamProvider
		{
			get
			{
				if (innerSqlDanhMucViPhamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDanhMucViPhamProvider == null)
						{
							this.innerSqlDanhMucViPhamProvider = new SqlDanhMucViPhamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDanhMucViPhamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDanhMucViPhamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDanhMucViPhamProvider SqlDanhMucViPhamProvider
		{
			get {return DanhMucViPhamProvider as SqlDanhMucViPhamProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienTamUngProvider"
			
		private SqlGiangVienTamUngProvider innerSqlGiangVienTamUngProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienTamUng"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienTamUngProviderBase GiangVienTamUngProvider
		{
			get
			{
				if (innerSqlGiangVienTamUngProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienTamUngProvider == null)
						{
							this.innerSqlGiangVienTamUngProvider = new SqlGiangVienTamUngProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienTamUngProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienTamUngProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienTamUngProvider SqlGiangVienTamUngProvider
		{
			get {return GiangVienTamUngProvider as SqlGiangVienTamUngProvider;}
		}
		
		#endregion
		
		
		#region "DonGiaCoiThiProvider"
			
		private SqlDonGiaCoiThiProvider innerSqlDonGiaCoiThiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DonGiaCoiThi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DonGiaCoiThiProviderBase DonGiaCoiThiProvider
		{
			get
			{
				if (innerSqlDonGiaCoiThiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDonGiaCoiThiProvider == null)
						{
							this.innerSqlDonGiaCoiThiProvider = new SqlDonGiaCoiThiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDonGiaCoiThiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDonGiaCoiThiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDonGiaCoiThiProvider SqlDonGiaCoiThiProvider
		{
			get {return DonGiaCoiThiProvider as SqlDonGiaCoiThiProvider;}
		}
		
		#endregion
		
		
		#region "ChietTinhBoiDuongGiangDayProvider"
			
		private SqlChietTinhBoiDuongGiangDayProvider innerSqlChietTinhBoiDuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ChietTinhBoiDuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ChietTinhBoiDuongGiangDayProviderBase ChietTinhBoiDuongGiangDayProvider
		{
			get
			{
				if (innerSqlChietTinhBoiDuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlChietTinhBoiDuongGiangDayProvider == null)
						{
							this.innerSqlChietTinhBoiDuongGiangDayProvider = new SqlChietTinhBoiDuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlChietTinhBoiDuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlChietTinhBoiDuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlChietTinhBoiDuongGiangDayProvider SqlChietTinhBoiDuongGiangDayProvider
		{
			get {return ChietTinhBoiDuongGiangDayProvider as SqlChietTinhBoiDuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ChiTienThuLaoGiangDayProvider"
			
		private SqlChiTienThuLaoGiangDayProvider innerSqlChiTienThuLaoGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ChiTienThuLaoGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ChiTienThuLaoGiangDayProviderBase ChiTienThuLaoGiangDayProvider
		{
			get
			{
				if (innerSqlChiTienThuLaoGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlChiTienThuLaoGiangDayProvider == null)
						{
							this.innerSqlChiTienThuLaoGiangDayProvider = new SqlChiTienThuLaoGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlChiTienThuLaoGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlChiTienThuLaoGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlChiTienThuLaoGiangDayProvider SqlChiTienThuLaoGiangDayProvider
		{
			get {return ChiTienThuLaoGiangDayProvider as SqlChiTienThuLaoGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "CongThucProvider"
			
		private SqlCongThucProvider innerSqlCongThucProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="CongThuc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override CongThucProviderBase CongThucProvider
		{
			get
			{
				if (innerSqlCongThucProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlCongThucProvider == null)
						{
							this.innerSqlCongThucProvider = new SqlCongThucProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlCongThucProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlCongThucProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlCongThucProvider SqlCongThucProvider
		{
			get {return CongThucProvider as SqlCongThucProvider;}
		}
		
		#endregion
		
		
		#region "KcqUteThanhToanThuLaoProvider"
			
		private SqlKcqUteThanhToanThuLaoProvider innerSqlKcqUteThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqUteThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqUteThanhToanThuLaoProviderBase KcqUteThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlKcqUteThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqUteThanhToanThuLaoProvider == null)
						{
							this.innerSqlKcqUteThanhToanThuLaoProvider = new SqlKcqUteThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqUteThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqUteThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqUteThanhToanThuLaoProvider SqlKcqUteThanhToanThuLaoProvider
		{
			get {return KcqUteThanhToanThuLaoProvider as SqlKcqUteThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "DuTruGioGiangTruocThoiKhoaBieuProvider"
			
		private SqlDuTruGioGiangTruocThoiKhoaBieuProvider innerSqlDuTruGioGiangTruocThoiKhoaBieuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DuTruGioGiangTruocThoiKhoaBieu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DuTruGioGiangTruocThoiKhoaBieuProviderBase DuTruGioGiangTruocThoiKhoaBieuProvider
		{
			get
			{
				if (innerSqlDuTruGioGiangTruocThoiKhoaBieuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDuTruGioGiangTruocThoiKhoaBieuProvider == null)
						{
							this.innerSqlDuTruGioGiangTruocThoiKhoaBieuProvider = new SqlDuTruGioGiangTruocThoiKhoaBieuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDuTruGioGiangTruocThoiKhoaBieuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDuTruGioGiangTruocThoiKhoaBieuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDuTruGioGiangTruocThoiKhoaBieuProvider SqlDuTruGioGiangTruocThoiKhoaBieuProvider
		{
			get {return DuTruGioGiangTruocThoiKhoaBieuProvider as SqlDuTruGioGiangTruocThoiKhoaBieuProvider;}
		}
		
		#endregion
		
		
		#region "DanhMucQuyMoProvider"
			
		private SqlDanhMucQuyMoProvider innerSqlDanhMucQuyMoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DanhMucQuyMo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DanhMucQuyMoProviderBase DanhMucQuyMoProvider
		{
			get
			{
				if (innerSqlDanhMucQuyMoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDanhMucQuyMoProvider == null)
						{
							this.innerSqlDanhMucQuyMoProvider = new SqlDanhMucQuyMoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDanhMucQuyMoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDanhMucQuyMoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDanhMucQuyMoProvider SqlDanhMucQuyMoProvider
		{
			get {return DanhMucQuyMoProvider as SqlDanhMucQuyMoProvider;}
		}
		
		#endregion
		
		
		#region "KcqKhoiLuongGiangDayChiTietProvider"
			
		private SqlKcqKhoiLuongGiangDayChiTietProvider innerSqlKcqKhoiLuongGiangDayChiTietProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqKhoiLuongGiangDayChiTiet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqKhoiLuongGiangDayChiTietProviderBase KcqKhoiLuongGiangDayChiTietProvider
		{
			get
			{
				if (innerSqlKcqKhoiLuongGiangDayChiTietProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqKhoiLuongGiangDayChiTietProvider == null)
						{
							this.innerSqlKcqKhoiLuongGiangDayChiTietProvider = new SqlKcqKhoiLuongGiangDayChiTietProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqKhoiLuongGiangDayChiTietProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqKhoiLuongGiangDayChiTietProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqKhoiLuongGiangDayChiTietProvider SqlKcqKhoiLuongGiangDayChiTietProvider
		{
			get {return KcqKhoiLuongGiangDayChiTietProvider as SqlKcqKhoiLuongGiangDayChiTietProvider;}
		}
		
		#endregion
		
		
		#region "HeSoChucDanhChuyenMonProvider"
			
		private SqlHeSoChucDanhChuyenMonProvider innerSqlHeSoChucDanhChuyenMonProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoChucDanhChuyenMon"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoChucDanhChuyenMonProviderBase HeSoChucDanhChuyenMonProvider
		{
			get
			{
				if (innerSqlHeSoChucDanhChuyenMonProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoChucDanhChuyenMonProvider == null)
						{
							this.innerSqlHeSoChucDanhChuyenMonProvider = new SqlHeSoChucDanhChuyenMonProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoChucDanhChuyenMonProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoChucDanhChuyenMonProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoChucDanhChuyenMonProvider SqlHeSoChucDanhChuyenMonProvider
		{
			get {return HeSoChucDanhChuyenMonProvider as SqlHeSoChucDanhChuyenMonProvider;}
		}
		
		#endregion
		
		
		#region "HeSoCongViecProvider"
			
		private SqlHeSoCongViecProvider innerSqlHeSoCongViecProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoCongViec"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoCongViecProviderBase HeSoCongViecProvider
		{
			get
			{
				if (innerSqlHeSoCongViecProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoCongViecProvider == null)
						{
							this.innerSqlHeSoCongViecProvider = new SqlHeSoCongViecProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoCongViecProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoCongViecProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoCongViecProvider SqlHeSoCongViecProvider
		{
			get {return HeSoCongViecProvider as SqlHeSoCongViecProvider;}
		}
		
		#endregion
		
		
		#region "KcqKhoiLuongThucTapCuoiKhoaProvider"
			
		private SqlKcqKhoiLuongThucTapCuoiKhoaProvider innerSqlKcqKhoiLuongThucTapCuoiKhoaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqKhoiLuongThucTapCuoiKhoa"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqKhoiLuongThucTapCuoiKhoaProviderBase KcqKhoiLuongThucTapCuoiKhoaProvider
		{
			get
			{
				if (innerSqlKcqKhoiLuongThucTapCuoiKhoaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqKhoiLuongThucTapCuoiKhoaProvider == null)
						{
							this.innerSqlKcqKhoiLuongThucTapCuoiKhoaProvider = new SqlKcqKhoiLuongThucTapCuoiKhoaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqKhoiLuongThucTapCuoiKhoaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqKhoiLuongThucTapCuoiKhoaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqKhoiLuongThucTapCuoiKhoaProvider SqlKcqKhoiLuongThucTapCuoiKhoaProvider
		{
			get {return KcqKhoiLuongThucTapCuoiKhoaProvider as SqlKcqKhoiLuongThucTapCuoiKhoaProvider;}
		}
		
		#endregion
		
		
		#region "KcqKhoiLuongDoAnTotNghiepChiTietProvider"
			
		private SqlKcqKhoiLuongDoAnTotNghiepChiTietProvider innerSqlKcqKhoiLuongDoAnTotNghiepChiTietProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqKhoiLuongDoAnTotNghiepChiTiet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqKhoiLuongDoAnTotNghiepChiTietProviderBase KcqKhoiLuongDoAnTotNghiepChiTietProvider
		{
			get
			{
				if (innerSqlKcqKhoiLuongDoAnTotNghiepChiTietProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqKhoiLuongDoAnTotNghiepChiTietProvider == null)
						{
							this.innerSqlKcqKhoiLuongDoAnTotNghiepChiTietProvider = new SqlKcqKhoiLuongDoAnTotNghiepChiTietProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqKhoiLuongDoAnTotNghiepChiTietProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqKhoiLuongDoAnTotNghiepChiTietProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqKhoiLuongDoAnTotNghiepChiTietProvider SqlKcqKhoiLuongDoAnTotNghiepChiTietProvider
		{
			get {return KcqKhoiLuongDoAnTotNghiepChiTietProvider as SqlKcqKhoiLuongDoAnTotNghiepChiTietProvider;}
		}
		
		#endregion
		
		
		#region "KcqKhoiLuongGiangDayDoAnTotNghiepProvider"
			
		private SqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider innerSqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqKhoiLuongGiangDayDoAnTotNghiep"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqKhoiLuongGiangDayDoAnTotNghiepProviderBase KcqKhoiLuongGiangDayDoAnTotNghiepProvider
		{
			get
			{
				if (innerSqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider == null)
						{
							this.innerSqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider = new SqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider SqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider
		{
			get {return KcqKhoiLuongGiangDayDoAnTotNghiepProvider as SqlKcqKhoiLuongGiangDayDoAnTotNghiepProvider;}
		}
		
		#endregion
		
		
		#region "DinhMucGioChuanToiThieuTheoChucVuProvider"
			
		private SqlDinhMucGioChuanToiThieuTheoChucVuProvider innerSqlDinhMucGioChuanToiThieuTheoChucVuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="DinhMucGioChuanToiThieuTheoChucVu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override DinhMucGioChuanToiThieuTheoChucVuProviderBase DinhMucGioChuanToiThieuTheoChucVuProvider
		{
			get
			{
				if (innerSqlDinhMucGioChuanToiThieuTheoChucVuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlDinhMucGioChuanToiThieuTheoChucVuProvider == null)
						{
							this.innerSqlDinhMucGioChuanToiThieuTheoChucVuProvider = new SqlDinhMucGioChuanToiThieuTheoChucVuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlDinhMucGioChuanToiThieuTheoChucVuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlDinhMucGioChuanToiThieuTheoChucVuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlDinhMucGioChuanToiThieuTheoChucVuProvider SqlDinhMucGioChuanToiThieuTheoChucVuProvider
		{
			get {return DinhMucGioChuanToiThieuTheoChucVuProvider as SqlDinhMucGioChuanToiThieuTheoChucVuProvider;}
		}
		
		#endregion
		
		
		#region "KcqKhoanQuyDoiProvider"
			
		private SqlKcqKhoanQuyDoiProvider innerSqlKcqKhoanQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqKhoanQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqKhoanQuyDoiProviderBase KcqKhoanQuyDoiProvider
		{
			get
			{
				if (innerSqlKcqKhoanQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqKhoanQuyDoiProvider == null)
						{
							this.innerSqlKcqKhoanQuyDoiProvider = new SqlKcqKhoanQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqKhoanQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqKhoanQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqKhoanQuyDoiProvider SqlKcqKhoanQuyDoiProvider
		{
			get {return KcqKhoanQuyDoiProvider as SqlKcqKhoanQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "KcqHeSoCoSoProvider"
			
		private SqlKcqHeSoCoSoProvider innerSqlKcqHeSoCoSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqHeSoCoSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqHeSoCoSoProviderBase KcqHeSoCoSoProvider
		{
			get
			{
				if (innerSqlKcqHeSoCoSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqHeSoCoSoProvider == null)
						{
							this.innerSqlKcqHeSoCoSoProvider = new SqlKcqHeSoCoSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqHeSoCoSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqHeSoCoSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqHeSoCoSoProvider SqlKcqHeSoCoSoProvider
		{
			get {return KcqHeSoCoSoProvider as SqlKcqHeSoCoSoProvider;}
		}
		
		#endregion
		
		
		#region "KcqMonXepLichChuNhatKhongTinhHeSoProvider"
			
		private SqlKcqMonXepLichChuNhatKhongTinhHeSoProvider innerSqlKcqMonXepLichChuNhatKhongTinhHeSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqMonXepLichChuNhatKhongTinhHeSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqMonXepLichChuNhatKhongTinhHeSoProviderBase KcqMonXepLichChuNhatKhongTinhHeSoProvider
		{
			get
			{
				if (innerSqlKcqMonXepLichChuNhatKhongTinhHeSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqMonXepLichChuNhatKhongTinhHeSoProvider == null)
						{
							this.innerSqlKcqMonXepLichChuNhatKhongTinhHeSoProvider = new SqlKcqMonXepLichChuNhatKhongTinhHeSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqMonXepLichChuNhatKhongTinhHeSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqMonXepLichChuNhatKhongTinhHeSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqMonXepLichChuNhatKhongTinhHeSoProvider SqlKcqMonXepLichChuNhatKhongTinhHeSoProvider
		{
			get {return KcqMonXepLichChuNhatKhongTinhHeSoProvider as SqlKcqMonXepLichChuNhatKhongTinhHeSoProvider;}
		}
		
		#endregion
		
		
		#region "KcqKhoiLuongKhacProvider"
			
		private SqlKcqKhoiLuongKhacProvider innerSqlKcqKhoiLuongKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqKhoiLuongKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqKhoiLuongKhacProviderBase KcqKhoiLuongKhacProvider
		{
			get
			{
				if (innerSqlKcqKhoiLuongKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqKhoiLuongKhacProvider == null)
						{
							this.innerSqlKcqKhoiLuongKhacProvider = new SqlKcqKhoiLuongKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqKhoiLuongKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqKhoiLuongKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqKhoiLuongKhacProvider SqlKcqKhoiLuongKhacProvider
		{
			get {return KcqKhoiLuongKhacProvider as SqlKcqKhoiLuongKhacProvider;}
		}
		
		#endregion
		
		
		#region "KcqHeSoDiaDiemProvider"
			
		private SqlKcqHeSoDiaDiemProvider innerSqlKcqHeSoDiaDiemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqHeSoDiaDiem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqHeSoDiaDiemProviderBase KcqHeSoDiaDiemProvider
		{
			get
			{
				if (innerSqlKcqHeSoDiaDiemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqHeSoDiaDiemProvider == null)
						{
							this.innerSqlKcqHeSoDiaDiemProvider = new SqlKcqHeSoDiaDiemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqHeSoDiaDiemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqHeSoDiaDiemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqHeSoDiaDiemProvider SqlKcqHeSoDiaDiemProvider
		{
			get {return KcqHeSoDiaDiemProvider as SqlKcqHeSoDiaDiemProvider;}
		}
		
		#endregion
		
		
		#region "KcqPhanBienLuanAnProvider"
			
		private SqlKcqPhanBienLuanAnProvider innerSqlKcqPhanBienLuanAnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqPhanBienLuanAn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqPhanBienLuanAnProviderBase KcqPhanBienLuanAnProvider
		{
			get
			{
				if (innerSqlKcqPhanBienLuanAnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqPhanBienLuanAnProvider == null)
						{
							this.innerSqlKcqPhanBienLuanAnProvider = new SqlKcqPhanBienLuanAnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqPhanBienLuanAnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqPhanBienLuanAnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqPhanBienLuanAnProvider SqlKcqPhanBienLuanAnProvider
		{
			get {return KcqPhanBienLuanAnProvider as SqlKcqPhanBienLuanAnProvider;}
		}
		
		#endregion
		
		
		#region "KcqDonGiaNgoaiQuyCheProvider"
			
		private SqlKcqDonGiaNgoaiQuyCheProvider innerSqlKcqDonGiaNgoaiQuyCheProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqDonGiaNgoaiQuyChe"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqDonGiaNgoaiQuyCheProviderBase KcqDonGiaNgoaiQuyCheProvider
		{
			get
			{
				if (innerSqlKcqDonGiaNgoaiQuyCheProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqDonGiaNgoaiQuyCheProvider == null)
						{
							this.innerSqlKcqDonGiaNgoaiQuyCheProvider = new SqlKcqDonGiaNgoaiQuyCheProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqDonGiaNgoaiQuyCheProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqDonGiaNgoaiQuyCheProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqDonGiaNgoaiQuyCheProvider SqlKcqDonGiaNgoaiQuyCheProvider
		{
			get {return KcqDonGiaNgoaiQuyCheProvider as SqlKcqDonGiaNgoaiQuyCheProvider;}
		}
		
		#endregion
		
		
		#region "KcqChotKhoiLuongGiangDayProvider"
			
		private SqlKcqChotKhoiLuongGiangDayProvider innerSqlKcqChotKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqChotKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqChotKhoiLuongGiangDayProviderBase KcqChotKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlKcqChotKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqChotKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlKcqChotKhoiLuongGiangDayProvider = new SqlKcqChotKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqChotKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqChotKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqChotKhoiLuongGiangDayProvider SqlKcqChotKhoiLuongGiangDayProvider
		{
			get {return KcqChotKhoiLuongGiangDayProvider as SqlKcqChotKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "KcqKhoiLuongGiangDayDoAnProvider"
			
		private SqlKcqKhoiLuongGiangDayDoAnProvider innerSqlKcqKhoiLuongGiangDayDoAnProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqKhoiLuongGiangDayDoAn"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqKhoiLuongGiangDayDoAnProviderBase KcqKhoiLuongGiangDayDoAnProvider
		{
			get
			{
				if (innerSqlKcqKhoiLuongGiangDayDoAnProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqKhoiLuongGiangDayDoAnProvider == null)
						{
							this.innerSqlKcqKhoiLuongGiangDayDoAnProvider = new SqlKcqKhoiLuongGiangDayDoAnProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqKhoiLuongGiangDayDoAnProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqKhoiLuongGiangDayDoAnProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqKhoiLuongGiangDayDoAnProvider SqlKcqKhoiLuongGiangDayDoAnProvider
		{
			get {return KcqKhoiLuongGiangDayDoAnProvider as SqlKcqKhoiLuongGiangDayDoAnProvider;}
		}
		
		#endregion
		
		
		#region "KcqKetQuaThanhToanThuLaoProvider"
			
		private SqlKcqKetQuaThanhToanThuLaoProvider innerSqlKcqKetQuaThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqKetQuaThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqKetQuaThanhToanThuLaoProviderBase KcqKetQuaThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlKcqKetQuaThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqKetQuaThanhToanThuLaoProvider == null)
						{
							this.innerSqlKcqKetQuaThanhToanThuLaoProvider = new SqlKcqKetQuaThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqKetQuaThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqKetQuaThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqKetQuaThanhToanThuLaoProvider SqlKcqKetQuaThanhToanThuLaoProvider
		{
			get {return KcqKetQuaThanhToanThuLaoProvider as SqlKcqKetQuaThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "HeSoBacDaoTaoProvider"
			
		private SqlHeSoBacDaoTaoProvider innerSqlHeSoBacDaoTaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoBacDaoTao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoBacDaoTaoProviderBase HeSoBacDaoTaoProvider
		{
			get
			{
				if (innerSqlHeSoBacDaoTaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoBacDaoTaoProvider == null)
						{
							this.innerSqlHeSoBacDaoTaoProvider = new SqlHeSoBacDaoTaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoBacDaoTaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoBacDaoTaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoBacDaoTaoProvider SqlHeSoBacDaoTaoProvider
		{
			get {return HeSoBacDaoTaoProvider as SqlHeSoBacDaoTaoProvider;}
		}
		
		#endregion
		
		
		#region "KcqUteKhoiLuongQuyDoiProvider"
			
		private SqlKcqUteKhoiLuongQuyDoiProvider innerSqlKcqUteKhoiLuongQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqUteKhoiLuongQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqUteKhoiLuongQuyDoiProviderBase KcqUteKhoiLuongQuyDoiProvider
		{
			get
			{
				if (innerSqlKcqUteKhoiLuongQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqUteKhoiLuongQuyDoiProvider == null)
						{
							this.innerSqlKcqUteKhoiLuongQuyDoiProvider = new SqlKcqUteKhoiLuongQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqUteKhoiLuongQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqUteKhoiLuongQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqUteKhoiLuongQuyDoiProvider SqlKcqUteKhoiLuongQuyDoiProvider
		{
			get {return KcqUteKhoiLuongQuyDoiProvider as SqlKcqUteKhoiLuongQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "KcqMonPhanCongNhieuGiangVienProvider"
			
		private SqlKcqMonPhanCongNhieuGiangVienProvider innerSqlKcqMonPhanCongNhieuGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqMonPhanCongNhieuGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqMonPhanCongNhieuGiangVienProviderBase KcqMonPhanCongNhieuGiangVienProvider
		{
			get
			{
				if (innerSqlKcqMonPhanCongNhieuGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqMonPhanCongNhieuGiangVienProvider == null)
						{
							this.innerSqlKcqMonPhanCongNhieuGiangVienProvider = new SqlKcqMonPhanCongNhieuGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqMonPhanCongNhieuGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqMonPhanCongNhieuGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqMonPhanCongNhieuGiangVienProvider SqlKcqMonPhanCongNhieuGiangVienProvider
		{
			get {return KcqMonPhanCongNhieuGiangVienProvider as SqlKcqMonPhanCongNhieuGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "KcqMonTieuLuanProvider"
			
		private SqlKcqMonTieuLuanProvider innerSqlKcqMonTieuLuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqMonTieuLuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqMonTieuLuanProviderBase KcqMonTieuLuanProvider
		{
			get
			{
				if (innerSqlKcqMonTieuLuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqMonTieuLuanProvider == null)
						{
							this.innerSqlKcqMonTieuLuanProvider = new SqlKcqMonTieuLuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqMonTieuLuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqMonTieuLuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqMonTieuLuanProvider SqlKcqMonTieuLuanProvider
		{
			get {return KcqMonTieuLuanProvider as SqlKcqMonTieuLuanProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienProvider"
			
		private SqlGiangVienProvider innerSqlGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienProviderBase GiangVienProvider
		{
			get
			{
				if (innerSqlGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienProvider == null)
						{
							this.innerSqlGiangVienProvider = new SqlGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienProvider SqlGiangVienProvider
		{
			get {return GiangVienProvider as SqlGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "KcqPhuCapHanhChinhProvider"
			
		private SqlKcqPhuCapHanhChinhProvider innerSqlKcqPhuCapHanhChinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqPhuCapHanhChinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqPhuCapHanhChinhProviderBase KcqPhuCapHanhChinhProvider
		{
			get
			{
				if (innerSqlKcqPhuCapHanhChinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqPhuCapHanhChinhProvider == null)
						{
							this.innerSqlKcqPhuCapHanhChinhProvider = new SqlKcqPhuCapHanhChinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqPhuCapHanhChinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqPhuCapHanhChinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqPhuCapHanhChinhProvider SqlKcqPhuCapHanhChinhProvider
		{
			get {return KcqPhuCapHanhChinhProvider as SqlKcqPhuCapHanhChinhProvider;}
		}
		
		#endregion
		
		
		#region "GiangVienGiangDayGdtcQpProvider"
			
		private SqlGiangVienGiangDayGdtcQpProvider innerSqlGiangVienGiangDayGdtcQpProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="GiangVienGiangDayGdtcQp"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override GiangVienGiangDayGdtcQpProviderBase GiangVienGiangDayGdtcQpProvider
		{
			get
			{
				if (innerSqlGiangVienGiangDayGdtcQpProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlGiangVienGiangDayGdtcQpProvider == null)
						{
							this.innerSqlGiangVienGiangDayGdtcQpProvider = new SqlGiangVienGiangDayGdtcQpProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlGiangVienGiangDayGdtcQpProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlGiangVienGiangDayGdtcQpProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlGiangVienGiangDayGdtcQpProvider SqlGiangVienGiangDayGdtcQpProvider
		{
			get {return GiangVienGiangDayGdtcQpProvider as SqlGiangVienGiangDayGdtcQpProvider;}
		}
		
		#endregion
		
		
		#region "KcqHeSoHocKyProvider"
			
		private SqlKcqHeSoHocKyProvider innerSqlKcqHeSoHocKyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqHeSoHocKy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqHeSoHocKyProviderBase KcqHeSoHocKyProvider
		{
			get
			{
				if (innerSqlKcqHeSoHocKyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqHeSoHocKyProvider == null)
						{
							this.innerSqlKcqHeSoHocKyProvider = new SqlKcqHeSoHocKyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqHeSoHocKyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqHeSoHocKyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqHeSoHocKyProvider SqlKcqHeSoHocKyProvider
		{
			get {return KcqHeSoHocKyProvider as SqlKcqHeSoHocKyProvider;}
		}
		
		#endregion
		
		
		#region "KcqPhanNhomMonHocProvider"
			
		private SqlKcqPhanNhomMonHocProvider innerSqlKcqPhanNhomMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqPhanNhomMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqPhanNhomMonHocProviderBase KcqPhanNhomMonHocProvider
		{
			get
			{
				if (innerSqlKcqPhanNhomMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqPhanNhomMonHocProvider == null)
						{
							this.innerSqlKcqPhanNhomMonHocProvider = new SqlKcqPhanNhomMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqPhanNhomMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqPhanNhomMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqPhanNhomMonHocProvider SqlKcqPhanNhomMonHocProvider
		{
			get {return KcqPhanNhomMonHocProvider as SqlKcqPhanNhomMonHocProvider;}
		}
		
		#endregion
		
		
		#region "KetQuaThanhToanThuLaoProvider"
			
		private SqlKetQuaThanhToanThuLaoProvider innerSqlKetQuaThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KetQuaThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KetQuaThanhToanThuLaoProviderBase KetQuaThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlKetQuaThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKetQuaThanhToanThuLaoProvider == null)
						{
							this.innerSqlKetQuaThanhToanThuLaoProvider = new SqlKetQuaThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKetQuaThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKetQuaThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKetQuaThanhToanThuLaoProvider SqlKetQuaThanhToanThuLaoProvider
		{
			get {return KetQuaThanhToanThuLaoProvider as SqlKetQuaThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "KcqNhomMonHocProvider"
			
		private SqlKcqNhomMonHocProvider innerSqlKcqNhomMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqNhomMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqNhomMonHocProviderBase KcqNhomMonHocProvider
		{
			get
			{
				if (innerSqlKcqNhomMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqNhomMonHocProvider == null)
						{
							this.innerSqlKcqNhomMonHocProvider = new SqlKcqNhomMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqNhomMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqNhomMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqNhomMonHocProvider SqlKcqNhomMonHocProvider
		{
			get {return KcqNhomMonHocProvider as SqlKcqNhomMonHocProvider;}
		}
		
		#endregion
		
		
		#region "KcqMonTinhTheoQuyCheMoiProvider"
			
		private SqlKcqMonTinhTheoQuyCheMoiProvider innerSqlKcqMonTinhTheoQuyCheMoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqMonTinhTheoQuyCheMoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqMonTinhTheoQuyCheMoiProviderBase KcqMonTinhTheoQuyCheMoiProvider
		{
			get
			{
				if (innerSqlKcqMonTinhTheoQuyCheMoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqMonTinhTheoQuyCheMoiProvider == null)
						{
							this.innerSqlKcqMonTinhTheoQuyCheMoiProvider = new SqlKcqMonTinhTheoQuyCheMoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqMonTinhTheoQuyCheMoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqMonTinhTheoQuyCheMoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqMonTinhTheoQuyCheMoiProvider SqlKcqMonTinhTheoQuyCheMoiProvider
		{
			get {return KcqMonTinhTheoQuyCheMoiProvider as SqlKcqMonTinhTheoQuyCheMoiProvider;}
		}
		
		#endregion
		
		
		#region "KcqCauHinhChotGioProvider"
			
		private SqlKcqCauHinhChotGioProvider innerSqlKcqCauHinhChotGioProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqCauHinhChotGio"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqCauHinhChotGioProviderBase KcqCauHinhChotGioProvider
		{
			get
			{
				if (innerSqlKcqCauHinhChotGioProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqCauHinhChotGioProvider == null)
						{
							this.innerSqlKcqCauHinhChotGioProvider = new SqlKcqCauHinhChotGioProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqCauHinhChotGioProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqCauHinhChotGioProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqCauHinhChotGioProvider SqlKcqCauHinhChotGioProvider
		{
			get {return KcqCauHinhChotGioProvider as SqlKcqCauHinhChotGioProvider;}
		}
		
		#endregion
		
		
		#region "KcqPhanLoaiHocPhanProvider"
			
		private SqlKcqPhanLoaiHocPhanProvider innerSqlKcqPhanLoaiHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqPhanLoaiHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqPhanLoaiHocPhanProviderBase KcqPhanLoaiHocPhanProvider
		{
			get
			{
				if (innerSqlKcqPhanLoaiHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqPhanLoaiHocPhanProvider == null)
						{
							this.innerSqlKcqPhanLoaiHocPhanProvider = new SqlKcqPhanLoaiHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqPhanLoaiHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqPhanLoaiHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqPhanLoaiHocPhanProvider SqlKcqPhanLoaiHocPhanProvider
		{
			get {return KcqPhanLoaiHocPhanProvider as SqlKcqPhanLoaiHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "KcqMonThucTapTotNghiepProvider"
			
		private SqlKcqMonThucTapTotNghiepProvider innerSqlKcqMonThucTapTotNghiepProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqMonThucTapTotNghiep"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqMonThucTapTotNghiepProviderBase KcqMonThucTapTotNghiepProvider
		{
			get
			{
				if (innerSqlKcqMonThucTapTotNghiepProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqMonThucTapTotNghiepProvider == null)
						{
							this.innerSqlKcqMonThucTapTotNghiepProvider = new SqlKcqMonThucTapTotNghiepProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqMonThucTapTotNghiepProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqMonThucTapTotNghiepProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqMonThucTapTotNghiepProvider SqlKcqMonThucTapTotNghiepProvider
		{
			get {return KcqMonThucTapTotNghiepProvider as SqlKcqMonThucTapTotNghiepProvider;}
		}
		
		#endregion
		
		
		#region "KcqMonHocKhongTinhKhoiLuongProvider"
			
		private SqlKcqMonHocKhongTinhKhoiLuongProvider innerSqlKcqMonHocKhongTinhKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqMonHocKhongTinhKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqMonHocKhongTinhKhoiLuongProviderBase KcqMonHocKhongTinhKhoiLuongProvider
		{
			get
			{
				if (innerSqlKcqMonHocKhongTinhKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqMonHocKhongTinhKhoiLuongProvider == null)
						{
							this.innerSqlKcqMonHocKhongTinhKhoiLuongProvider = new SqlKcqMonHocKhongTinhKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqMonHocKhongTinhKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqMonHocKhongTinhKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqMonHocKhongTinhKhoiLuongProvider SqlKcqMonHocKhongTinhKhoiLuongProvider
		{
			get {return KcqMonHocKhongTinhKhoiLuongProvider as SqlKcqMonHocKhongTinhKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "KcqHeSoQuyDoiTinChiProvider"
			
		private SqlKcqHeSoQuyDoiTinChiProvider innerSqlKcqHeSoQuyDoiTinChiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqHeSoQuyDoiTinChi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqHeSoQuyDoiTinChiProviderBase KcqHeSoQuyDoiTinChiProvider
		{
			get
			{
				if (innerSqlKcqHeSoQuyDoiTinChiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqHeSoQuyDoiTinChiProvider == null)
						{
							this.innerSqlKcqHeSoQuyDoiTinChiProvider = new SqlKcqHeSoQuyDoiTinChiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqHeSoQuyDoiTinChiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqHeSoQuyDoiTinChiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqHeSoQuyDoiTinChiProvider SqlKcqHeSoQuyDoiTinChiProvider
		{
			get {return KcqHeSoQuyDoiTinChiProvider as SqlKcqHeSoQuyDoiTinChiProvider;}
		}
		
		#endregion
		
		
		#region "KcqDonGiaProvider"
			
		private SqlKcqDonGiaProvider innerSqlKcqDonGiaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqDonGia"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqDonGiaProviderBase KcqDonGiaProvider
		{
			get
			{
				if (innerSqlKcqDonGiaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqDonGiaProvider == null)
						{
							this.innerSqlKcqDonGiaProvider = new SqlKcqDonGiaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqDonGiaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqDonGiaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqDonGiaProvider SqlKcqDonGiaProvider
		{
			get {return KcqDonGiaProvider as SqlKcqDonGiaProvider;}
		}
		
		#endregion
		
		
		#region "KcqLoaiKhoiLuongProvider"
			
		private SqlKcqLoaiKhoiLuongProvider innerSqlKcqLoaiKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqLoaiKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqLoaiKhoiLuongProviderBase KcqLoaiKhoiLuongProvider
		{
			get
			{
				if (innerSqlKcqLoaiKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqLoaiKhoiLuongProvider == null)
						{
							this.innerSqlKcqLoaiKhoiLuongProvider = new SqlKcqLoaiKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqLoaiKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqLoaiKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqLoaiKhoiLuongProvider SqlKcqLoaiKhoiLuongProvider
		{
			get {return KcqLoaiKhoiLuongProvider as SqlKcqLoaiKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "HeSoNhomMonProvider"
			
		private SqlHeSoNhomMonProvider innerSqlHeSoNhomMonProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoNhomMon"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoNhomMonProviderBase HeSoNhomMonProvider
		{
			get
			{
				if (innerSqlHeSoNhomMonProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoNhomMonProvider == null)
						{
							this.innerSqlHeSoNhomMonProvider = new SqlHeSoNhomMonProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoNhomMonProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoNhomMonProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoNhomMonProvider SqlHeSoNhomMonProvider
		{
			get {return HeSoNhomMonProvider as SqlHeSoNhomMonProvider;}
		}
		
		#endregion
		
		
		#region "HoatDongNgoaiGiangDayClcProvider"
			
		private SqlHoatDongNgoaiGiangDayClcProvider innerSqlHoatDongNgoaiGiangDayClcProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HoatDongNgoaiGiangDayClc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HoatDongNgoaiGiangDayClcProviderBase HoatDongNgoaiGiangDayClcProvider
		{
			get
			{
				if (innerSqlHoatDongNgoaiGiangDayClcProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHoatDongNgoaiGiangDayClcProvider == null)
						{
							this.innerSqlHoatDongNgoaiGiangDayClcProvider = new SqlHoatDongNgoaiGiangDayClcProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHoatDongNgoaiGiangDayClcProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHoatDongNgoaiGiangDayClcProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHoatDongNgoaiGiangDayClcProvider SqlHoatDongNgoaiGiangDayClcProvider
		{
			get {return HoatDongNgoaiGiangDayClcProvider as SqlHoatDongNgoaiGiangDayClcProvider;}
		}
		
		#endregion
		
		
		#region "HeThongProvider"
			
		private SqlHeThongProvider innerSqlHeThongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeThong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeThongProviderBase HeThongProvider
		{
			get
			{
				if (innerSqlHeThongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeThongProvider == null)
						{
							this.innerSqlHeThongProvider = new SqlHeThongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeThongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeThongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeThongProvider SqlHeThongProvider
		{
			get {return HeThongProvider as SqlHeThongProvider;}
		}
		
		#endregion
		
		
		#region "HeSoCoSoProvider"
			
		private SqlHeSoCoSoProvider innerSqlHeSoCoSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoCoSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoCoSoProviderBase HeSoCoSoProvider
		{
			get
			{
				if (innerSqlHeSoCoSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoCoSoProvider == null)
						{
							this.innerSqlHeSoCoSoProvider = new SqlHeSoCoSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoCoSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoCoSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoCoSoProvider SqlHeSoCoSoProvider
		{
			get {return HeSoCoSoProvider as SqlHeSoCoSoProvider;}
		}
		
		#endregion
		
		
		#region "HeSoNgayProvider"
			
		private SqlHeSoNgayProvider innerSqlHeSoNgayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoNgay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoNgayProviderBase HeSoNgayProvider
		{
			get
			{
				if (innerSqlHeSoNgayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoNgayProvider == null)
						{
							this.innerSqlHeSoNgayProvider = new SqlHeSoNgayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoNgayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoNgayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoNgayProvider SqlHeSoNgayProvider
		{
			get {return HeSoNgayProvider as SqlHeSoNgayProvider;}
		}
		
		#endregion
		
		
		#region "HeSoKhoiLuongCongThemProvider"
			
		private SqlHeSoKhoiLuongCongThemProvider innerSqlHeSoKhoiLuongCongThemProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoKhoiLuongCongThem"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoKhoiLuongCongThemProviderBase HeSoKhoiLuongCongThemProvider
		{
			get
			{
				if (innerSqlHeSoKhoiLuongCongThemProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoKhoiLuongCongThemProvider == null)
						{
							this.innerSqlHeSoKhoiLuongCongThemProvider = new SqlHeSoKhoiLuongCongThemProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoKhoiLuongCongThemProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoKhoiLuongCongThemProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoKhoiLuongCongThemProvider SqlHeSoKhoiLuongCongThemProvider
		{
			get {return HeSoKhoiLuongCongThemProvider as SqlHeSoKhoiLuongCongThemProvider;}
		}
		
		#endregion
		
		
		#region "HoatDongNgoaiGiangDayProvider"
			
		private SqlHoatDongNgoaiGiangDayProvider innerSqlHoatDongNgoaiGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HoatDongNgoaiGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HoatDongNgoaiGiangDayProviderBase HoatDongNgoaiGiangDayProvider
		{
			get
			{
				if (innerSqlHoatDongNgoaiGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHoatDongNgoaiGiangDayProvider == null)
						{
							this.innerSqlHoatDongNgoaiGiangDayProvider = new SqlHoatDongNgoaiGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHoatDongNgoaiGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHoatDongNgoaiGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHoatDongNgoaiGiangDayProvider SqlHoatDongNgoaiGiangDayProvider
		{
			get {return HoatDongNgoaiGiangDayProvider as SqlHoatDongNgoaiGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "HeSoLuongProvider"
			
		private SqlHeSoLuongProvider innerSqlHeSoLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoLuongProviderBase HeSoLuongProvider
		{
			get
			{
				if (innerSqlHeSoLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoLuongProvider == null)
						{
							this.innerSqlHeSoLuongProvider = new SqlHeSoLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoLuongProvider SqlHeSoLuongProvider
		{
			get {return HeSoLuongProvider as SqlHeSoLuongProvider;}
		}
		
		#endregion
		
		
		#region "HeSoCoVanHocTapProvider"
			
		private SqlHeSoCoVanHocTapProvider innerSqlHeSoCoVanHocTapProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoCoVanHocTap"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoCoVanHocTapProviderBase HeSoCoVanHocTapProvider
		{
			get
			{
				if (innerSqlHeSoCoVanHocTapProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoCoVanHocTapProvider == null)
						{
							this.innerSqlHeSoCoVanHocTapProvider = new SqlHeSoCoVanHocTapProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoCoVanHocTapProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoCoVanHocTapProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoCoVanHocTapProvider SqlHeSoCoVanHocTapProvider
		{
			get {return HeSoCoVanHocTapProvider as SqlHeSoCoVanHocTapProvider;}
		}
		
		#endregion
		
		
		#region "HeSoHocKyProvider"
			
		private SqlHeSoHocKyProvider innerSqlHeSoHocKyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoHocKy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoHocKyProviderBase HeSoHocKyProvider
		{
			get
			{
				if (innerSqlHeSoHocKyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoHocKyProvider == null)
						{
							this.innerSqlHeSoHocKyProvider = new SqlHeSoHocKyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoHocKyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoHocKyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoHocKyProvider SqlHeSoHocKyProvider
		{
			get {return HeSoHocKyProvider as SqlHeSoHocKyProvider;}
		}
		
		#endregion
		
		
		#region "HeSoNgoaiGioProvider"
			
		private SqlHeSoNgoaiGioProvider innerSqlHeSoNgoaiGioProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoNgoaiGio"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoNgoaiGioProviderBase HeSoNgoaiGioProvider
		{
			get
			{
				if (innerSqlHeSoNgoaiGioProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoNgoaiGioProvider == null)
						{
							this.innerSqlHeSoNgoaiGioProvider = new SqlHeSoNgoaiGioProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoNgoaiGioProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoNgoaiGioProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoNgoaiGioProvider SqlHeSoNgoaiGioProvider
		{
			get {return HeSoNgoaiGioProvider as SqlHeSoNgoaiGioProvider;}
		}
		
		#endregion
		
		
		#region "HeSoNhomThucHanhProvider"
			
		private SqlHeSoNhomThucHanhProvider innerSqlHeSoNhomThucHanhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoNhomThucHanh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoNhomThucHanhProviderBase HeSoNhomThucHanhProvider
		{
			get
			{
				if (innerSqlHeSoNhomThucHanhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoNhomThucHanhProvider == null)
						{
							this.innerSqlHeSoNhomThucHanhProvider = new SqlHeSoNhomThucHanhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoNhomThucHanhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoNhomThucHanhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoNhomThucHanhProvider SqlHeSoNhomThucHanhProvider
		{
			get {return HeSoNhomThucHanhProvider as SqlHeSoNhomThucHanhProvider;}
		}
		
		#endregion
		
		
		#region "KcqNhomKhoiLuongProvider"
			
		private SqlKcqNhomKhoiLuongProvider innerSqlKcqNhomKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqNhomKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqNhomKhoiLuongProviderBase KcqNhomKhoiLuongProvider
		{
			get
			{
				if (innerSqlKcqNhomKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqNhomKhoiLuongProvider == null)
						{
							this.innerSqlKcqNhomKhoiLuongProvider = new SqlKcqNhomKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqNhomKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqNhomKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqNhomKhoiLuongProvider SqlKcqNhomKhoiLuongProvider
		{
			get {return KcqNhomKhoiLuongProvider as SqlKcqNhomKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "HeSoChucDanhKhoiLuongKhacProvider"
			
		private SqlHeSoChucDanhKhoiLuongKhacProvider innerSqlHeSoChucDanhKhoiLuongKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoChucDanhKhoiLuongKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoChucDanhKhoiLuongKhacProviderBase HeSoChucDanhKhoiLuongKhacProvider
		{
			get
			{
				if (innerSqlHeSoChucDanhKhoiLuongKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoChucDanhKhoiLuongKhacProvider == null)
						{
							this.innerSqlHeSoChucDanhKhoiLuongKhacProvider = new SqlHeSoChucDanhKhoiLuongKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoChucDanhKhoiLuongKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoChucDanhKhoiLuongKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoChucDanhKhoiLuongKhacProvider SqlHeSoChucDanhKhoiLuongKhacProvider
		{
			get {return HeSoChucDanhKhoiLuongKhacProvider as SqlHeSoChucDanhKhoiLuongKhacProvider;}
		}
		
		#endregion
		
		
		#region "HeSoChucDanhTietNghiaVuProvider"
			
		private SqlHeSoChucDanhTietNghiaVuProvider innerSqlHeSoChucDanhTietNghiaVuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoChucDanhTietNghiaVu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoChucDanhTietNghiaVuProviderBase HeSoChucDanhTietNghiaVuProvider
		{
			get
			{
				if (innerSqlHeSoChucDanhTietNghiaVuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoChucDanhTietNghiaVuProvider == null)
						{
							this.innerSqlHeSoChucDanhTietNghiaVuProvider = new SqlHeSoChucDanhTietNghiaVuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoChucDanhTietNghiaVuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoChucDanhTietNghiaVuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoChucDanhTietNghiaVuProvider SqlHeSoChucDanhTietNghiaVuProvider
		{
			get {return HeSoChucDanhTietNghiaVuProvider as SqlHeSoChucDanhTietNghiaVuProvider;}
		}
		
		#endregion
		
		
		#region "HeSoKhoiNganhProvider"
			
		private SqlHeSoKhoiNganhProvider innerSqlHeSoKhoiNganhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoKhoiNganh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoKhoiNganhProviderBase HeSoKhoiNganhProvider
		{
			get
			{
				if (innerSqlHeSoKhoiNganhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoKhoiNganhProvider == null)
						{
							this.innerSqlHeSoKhoiNganhProvider = new SqlHeSoKhoiNganhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoKhoiNganhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoKhoiNganhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoKhoiNganhProvider SqlHeSoKhoiNganhProvider
		{
			get {return HeSoKhoiNganhProvider as SqlHeSoKhoiNganhProvider;}
		}
		
		#endregion
		
		
		#region "HeSoNgonNguProvider"
			
		private SqlHeSoNgonNguProvider innerSqlHeSoNgonNguProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoNgonNgu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoNgonNguProviderBase HeSoNgonNguProvider
		{
			get
			{
				if (innerSqlHeSoNgonNguProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoNgonNguProvider == null)
						{
							this.innerSqlHeSoNgonNguProvider = new SqlHeSoNgonNguProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoNgonNguProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoNgonNguProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoNgonNguProvider SqlHeSoNgonNguProvider
		{
			get {return HeSoNgonNguProvider as SqlHeSoNgonNguProvider;}
		}
		
		#endregion
		
		
		#region "HoSoProvider"
			
		private SqlHoSoProvider innerSqlHoSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HoSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HoSoProviderBase HoSoProvider
		{
			get
			{
				if (innerSqlHoSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHoSoProvider == null)
						{
							this.innerSqlHoSoProvider = new SqlHoSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHoSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHoSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHoSoProvider SqlHoSoProvider
		{
			get {return HoSoProvider as SqlHoSoProvider;}
		}
		
		#endregion
		
		
		#region "HopDongThinhGiangProvider"
			
		private SqlHopDongThinhGiangProvider innerSqlHopDongThinhGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HopDongThinhGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HopDongThinhGiangProviderBase HopDongThinhGiangProvider
		{
			get
			{
				if (innerSqlHopDongThinhGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHopDongThinhGiangProvider == null)
						{
							this.innerSqlHopDongThinhGiangProvider = new SqlHopDongThinhGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHopDongThinhGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHopDongThinhGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHopDongThinhGiangProvider SqlHopDongThinhGiangProvider
		{
			get {return HopDongThinhGiangProvider as SqlHopDongThinhGiangProvider;}
		}
		
		#endregion
		
		
		#region "HeSoThamNienProvider"
			
		private SqlHeSoThamNienProvider innerSqlHeSoThamNienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoThamNien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoThamNienProviderBase HeSoThamNienProvider
		{
			get
			{
				if (innerSqlHeSoThamNienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoThamNienProvider == null)
						{
							this.innerSqlHeSoThamNienProvider = new SqlHeSoThamNienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoThamNienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoThamNienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoThamNienProvider SqlHeSoThamNienProvider
		{
			get {return HeSoThamNienProvider as SqlHeSoThamNienProvider;}
		}
		
		#endregion
		
		
		#region "HeSoThoiGianGiangDayProvider"
			
		private SqlHeSoThoiGianGiangDayProvider innerSqlHeSoThoiGianGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoThoiGianGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoThoiGianGiangDayProviderBase HeSoThoiGianGiangDayProvider
		{
			get
			{
				if (innerSqlHeSoThoiGianGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoThoiGianGiangDayProvider == null)
						{
							this.innerSqlHeSoThoiGianGiangDayProvider = new SqlHeSoThoiGianGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoThoiGianGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoThoiGianGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoThoiGianGiangDayProvider SqlHeSoThoiGianGiangDayProvider
		{
			get {return HeSoThoiGianGiangDayProvider as SqlHeSoThoiGianGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "HuongDanKhoaLuanThucTapProvider"
			
		private SqlHuongDanKhoaLuanThucTapProvider innerSqlHuongDanKhoaLuanThucTapProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HuongDanKhoaLuanThucTap"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HuongDanKhoaLuanThucTapProviderBase HuongDanKhoaLuanThucTapProvider
		{
			get
			{
				if (innerSqlHuongDanKhoaLuanThucTapProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHuongDanKhoaLuanThucTapProvider == null)
						{
							this.innerSqlHuongDanKhoaLuanThucTapProvider = new SqlHuongDanKhoaLuanThucTapProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHuongDanKhoaLuanThucTapProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHuongDanKhoaLuanThucTapProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHuongDanKhoaLuanThucTapProvider SqlHuongDanKhoaLuanThucTapProvider
		{
			get {return HuongDanKhoaLuanThucTapProvider as SqlHuongDanKhoaLuanThucTapProvider;}
		}
		
		#endregion
		
		
		#region "HoatDongChuyenMonKhacProvider"
			
		private SqlHoatDongChuyenMonKhacProvider innerSqlHoatDongChuyenMonKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HoatDongChuyenMonKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HoatDongChuyenMonKhacProviderBase HoatDongChuyenMonKhacProvider
		{
			get
			{
				if (innerSqlHoatDongChuyenMonKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHoatDongChuyenMonKhacProvider == null)
						{
							this.innerSqlHoatDongChuyenMonKhacProvider = new SqlHoatDongChuyenMonKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHoatDongChuyenMonKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHoatDongChuyenMonKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHoatDongChuyenMonKhacProvider SqlHoatDongChuyenMonKhacProvider
		{
			get {return HoatDongChuyenMonKhacProvider as SqlHoatDongChuyenMonKhacProvider;}
		}
		
		#endregion
		
		
		#region "HeSoLopDongProvider"
			
		private SqlHeSoLopDongProvider innerSqlHeSoLopDongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoLopDong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoLopDongProviderBase HeSoLopDongProvider
		{
			get
			{
				if (innerSqlHeSoLopDongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoLopDongProvider == null)
						{
							this.innerSqlHeSoLopDongProvider = new SqlHeSoLopDongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoLopDongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoLopDongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoLopDongProvider SqlHeSoLopDongProvider
		{
			get {return HeSoLopDongProvider as SqlHeSoLopDongProvider;}
		}
		
		#endregion
		
		
		#region "HeSoQuyDoiGioChuanProvider"
			
		private SqlHeSoQuyDoiGioChuanProvider innerSqlHeSoQuyDoiGioChuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoQuyDoiGioChuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoQuyDoiGioChuanProviderBase HeSoQuyDoiGioChuanProvider
		{
			get
			{
				if (innerSqlHeSoQuyDoiGioChuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoQuyDoiGioChuanProvider == null)
						{
							this.innerSqlHeSoQuyDoiGioChuanProvider = new SqlHeSoQuyDoiGioChuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoQuyDoiGioChuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoQuyDoiGioChuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoQuyDoiGioChuanProvider SqlHeSoQuyDoiGioChuanProvider
		{
			get {return HeSoQuyDoiGioChuanProvider as SqlHeSoQuyDoiGioChuanProvider;}
		}
		
		#endregion
		
		
		#region "HistoryProvider"
			
		private SqlHistoryProvider innerSqlHistoryProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="History"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HistoryProviderBase HistoryProvider
		{
			get
			{
				if (innerSqlHistoryProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHistoryProvider == null)
						{
							this.innerSqlHistoryProvider = new SqlHistoryProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHistoryProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHistoryProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHistoryProvider SqlHistoryProvider
		{
			get {return HistoryProvider as SqlHistoryProvider;}
		}
		
		#endregion
		
		
		#region "KcqHopDongThinhGiangProvider"
			
		private SqlKcqHopDongThinhGiangProvider innerSqlKcqHopDongThinhGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="KcqHopDongThinhGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override KcqHopDongThinhGiangProviderBase KcqHopDongThinhGiangProvider
		{
			get
			{
				if (innerSqlKcqHopDongThinhGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlKcqHopDongThinhGiangProvider == null)
						{
							this.innerSqlKcqHopDongThinhGiangProvider = new SqlKcqHopDongThinhGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlKcqHopDongThinhGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlKcqHopDongThinhGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlKcqHopDongThinhGiangProvider SqlKcqHopDongThinhGiangProvider
		{
			get {return KcqHopDongThinhGiangProvider as SqlKcqHopDongThinhGiangProvider;}
		}
		
		#endregion
		
		
		#region "HeSoTinChiProvider"
			
		private SqlHeSoTinChiProvider innerSqlHeSoTinChiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoTinChi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoTinChiProviderBase HeSoTinChiProvider
		{
			get
			{
				if (innerSqlHeSoTinChiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoTinChiProvider == null)
						{
							this.innerSqlHeSoTinChiProvider = new SqlHeSoTinChiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoTinChiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoTinChiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoTinChiProvider SqlHeSoTinChiProvider
		{
			get {return HeSoTinChiProvider as SqlHeSoTinChiProvider;}
		}
		
		#endregion
		
		
		#region "HeSoThucTapProvider"
			
		private SqlHeSoThucTapProvider innerSqlHeSoThucTapProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoThucTap"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoThucTapProviderBase HeSoThucTapProvider
		{
			get
			{
				if (innerSqlHeSoThucTapProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoThucTapProvider == null)
						{
							this.innerSqlHeSoThucTapProvider = new SqlHeSoThucTapProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoThucTapProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoThucTapProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoThucTapProvider SqlHeSoThucTapProvider
		{
			get {return HeSoThucTapProvider as SqlHeSoThucTapProvider;}
		}
		
		#endregion
		
		
		#region "XetDuyetDeCuongLuanVanCaoHocProvider"
			
		private SqlXetDuyetDeCuongLuanVanCaoHocProvider innerSqlXetDuyetDeCuongLuanVanCaoHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="XetDuyetDeCuongLuanVanCaoHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override XetDuyetDeCuongLuanVanCaoHocProviderBase XetDuyetDeCuongLuanVanCaoHocProvider
		{
			get
			{
				if (innerSqlXetDuyetDeCuongLuanVanCaoHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlXetDuyetDeCuongLuanVanCaoHocProvider == null)
						{
							this.innerSqlXetDuyetDeCuongLuanVanCaoHocProvider = new SqlXetDuyetDeCuongLuanVanCaoHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlXetDuyetDeCuongLuanVanCaoHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlXetDuyetDeCuongLuanVanCaoHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlXetDuyetDeCuongLuanVanCaoHocProvider SqlXetDuyetDeCuongLuanVanCaoHocProvider
		{
			get {return XetDuyetDeCuongLuanVanCaoHocProvider as SqlXetDuyetDeCuongLuanVanCaoHocProvider;}
		}
		
		#endregion
		
		
		#region "HinhThucDaoTaoProvider"
			
		private SqlHinhThucDaoTaoProvider innerSqlHinhThucDaoTaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HinhThucDaoTao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HinhThucDaoTaoProviderBase HinhThucDaoTaoProvider
		{
			get
			{
				if (innerSqlHinhThucDaoTaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHinhThucDaoTaoProvider == null)
						{
							this.innerSqlHinhThucDaoTaoProvider = new SqlHinhThucDaoTaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHinhThucDaoTaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHinhThucDaoTaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHinhThucDaoTaoProvider SqlHinhThucDaoTaoProvider
		{
			get {return HinhThucDaoTaoProvider as SqlHinhThucDaoTaoProvider;}
		}
		
		#endregion
		
		
		#region "HeSoThanhToanGioChuanVuotMucProvider"
			
		private SqlHeSoThanhToanGioChuanVuotMucProvider innerSqlHeSoThanhToanGioChuanVuotMucProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoThanhToanGioChuanVuotMuc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoThanhToanGioChuanVuotMucProviderBase HeSoThanhToanGioChuanVuotMucProvider
		{
			get
			{
				if (innerSqlHeSoThanhToanGioChuanVuotMucProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoThanhToanGioChuanVuotMucProvider == null)
						{
							this.innerSqlHeSoThanhToanGioChuanVuotMucProvider = new SqlHeSoThanhToanGioChuanVuotMucProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoThanhToanGioChuanVuotMucProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoThanhToanGioChuanVuotMucProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoThanhToanGioChuanVuotMucProvider SqlHeSoThanhToanGioChuanVuotMucProvider
		{
			get {return HeSoThanhToanGioChuanVuotMucProvider as SqlHeSoThanhToanGioChuanVuotMucProvider;}
		}
		
		#endregion
		
		
		#region "HeSoQuyDoiTinChiProvider"
			
		private SqlHeSoQuyDoiTinChiProvider innerSqlHeSoQuyDoiTinChiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoQuyDoiTinChi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoQuyDoiTinChiProviderBase HeSoQuyDoiTinChiProvider
		{
			get
			{
				if (innerSqlHeSoQuyDoiTinChiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoQuyDoiTinChiProvider == null)
						{
							this.innerSqlHeSoQuyDoiTinChiProvider = new SqlHeSoQuyDoiTinChiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoQuyDoiTinChiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoQuyDoiTinChiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoQuyDoiTinChiProvider SqlHeSoQuyDoiTinChiProvider
		{
			get {return HeSoQuyDoiTinChiProvider as SqlHeSoQuyDoiTinChiProvider;}
		}
		
		#endregion
		
		
		#region "ThuLaoThoaThuanProvider"
			
		private SqlThuLaoThoaThuanProvider innerSqlThuLaoThoaThuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ThuLaoThoaThuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ThuLaoThoaThuanProviderBase ThuLaoThoaThuanProvider
		{
			get
			{
				if (innerSqlThuLaoThoaThuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlThuLaoThoaThuanProvider == null)
						{
							this.innerSqlThuLaoThoaThuanProvider = new SqlThuLaoThoaThuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlThuLaoThoaThuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlThuLaoThoaThuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlThuLaoThoaThuanProvider SqlThuLaoThoaThuanProvider
		{
			get {return ThuLaoThoaThuanProvider as SqlThuLaoThoaThuanProvider;}
		}
		
		#endregion
		
		
		#region "UteThanhToanThuLaoProvider"
			
		private SqlUteThanhToanThuLaoProvider innerSqlUteThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="UteThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override UteThanhToanThuLaoProviderBase UteThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlUteThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlUteThanhToanThuLaoProvider == null)
						{
							this.innerSqlUteThanhToanThuLaoProvider = new SqlUteThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlUteThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlUteThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlUteThanhToanThuLaoProvider SqlUteThanhToanThuLaoProvider
		{
			get {return UteThanhToanThuLaoProvider as SqlUteThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "HeSoQuyDoiGioTroiProvider"
			
		private SqlHeSoQuyDoiGioTroiProvider innerSqlHeSoQuyDoiGioTroiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="HeSoQuyDoiGioTroi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override HeSoQuyDoiGioTroiProviderBase HeSoQuyDoiGioTroiProvider
		{
			get
			{
				if (innerSqlHeSoQuyDoiGioTroiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlHeSoQuyDoiGioTroiProvider == null)
						{
							this.innerSqlHeSoQuyDoiGioTroiProvider = new SqlHeSoQuyDoiGioTroiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlHeSoQuyDoiGioTroiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlHeSoQuyDoiGioTroiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlHeSoQuyDoiGioTroiProvider SqlHeSoQuyDoiGioTroiProvider
		{
			get {return HeSoQuyDoiGioTroiProvider as SqlHeSoQuyDoiGioTroiProvider;}
		}
		
		#endregion
		
		
		
		#region "VChiTietKhoiLuongProvider"
		
		private SqlVChiTietKhoiLuongProvider innerSqlVChiTietKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VChiTietKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VChiTietKhoiLuongProviderBase VChiTietKhoiLuongProvider
		{
			get
			{
				if (innerSqlVChiTietKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVChiTietKhoiLuongProvider == null)
						{
							this.innerSqlVChiTietKhoiLuongProvider = new SqlVChiTietKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVChiTietKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVChiTietKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVChiTietKhoiLuongProvider SqlVChiTietKhoiLuongProvider
		{
			get {return VChiTietKhoiLuongProvider as SqlVChiTietKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "VChiTietKhoiLuongThucDayProvider"
		
		private SqlVChiTietKhoiLuongThucDayProvider innerSqlVChiTietKhoiLuongThucDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VChiTietKhoiLuongThucDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VChiTietKhoiLuongThucDayProviderBase VChiTietKhoiLuongThucDayProvider
		{
			get
			{
				if (innerSqlVChiTietKhoiLuongThucDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVChiTietKhoiLuongThucDayProvider == null)
						{
							this.innerSqlVChiTietKhoiLuongThucDayProvider = new SqlVChiTietKhoiLuongThucDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVChiTietKhoiLuongThucDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVChiTietKhoiLuongThucDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVChiTietKhoiLuongThucDayProvider SqlVChiTietKhoiLuongThucDayProvider
		{
			get {return VChiTietKhoiLuongThucDayProvider as SqlVChiTietKhoiLuongThucDayProvider;}
		}
		
		#endregion
		
		
		#region "VChiTietQuyDoiProvider"
		
		private SqlVChiTietQuyDoiProvider innerSqlVChiTietQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VChiTietQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VChiTietQuyDoiProviderBase VChiTietQuyDoiProvider
		{
			get
			{
				if (innerSqlVChiTietQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVChiTietQuyDoiProvider == null)
						{
							this.innerSqlVChiTietQuyDoiProvider = new SqlVChiTietQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVChiTietQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVChiTietQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVChiTietQuyDoiProvider SqlVChiTietQuyDoiProvider
		{
			get {return VChiTietQuyDoiProvider as SqlVChiTietQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "VGiangVienChucVuProvider"
		
		private SqlVGiangVienChucVuProvider innerSqlVGiangVienChucVuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VGiangVienChucVu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VGiangVienChucVuProviderBase VGiangVienChucVuProvider
		{
			get
			{
				if (innerSqlVGiangVienChucVuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVGiangVienChucVuProvider == null)
						{
							this.innerSqlVGiangVienChucVuProvider = new SqlVGiangVienChucVuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVGiangVienChucVuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVGiangVienChucVuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVGiangVienChucVuProvider SqlVGiangVienChucVuProvider
		{
			get {return VGiangVienChucVuProvider as SqlVGiangVienChucVuProvider;}
		}
		
		#endregion
		
		
		#region "VKhoiLuongThucDayProvider"
		
		private SqlVKhoiLuongThucDayProvider innerSqlVKhoiLuongThucDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VKhoiLuongThucDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VKhoiLuongThucDayProviderBase VKhoiLuongThucDayProvider
		{
			get
			{
				if (innerSqlVKhoiLuongThucDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVKhoiLuongThucDayProvider == null)
						{
							this.innerSqlVKhoiLuongThucDayProvider = new SqlVKhoiLuongThucDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVKhoiLuongThucDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVKhoiLuongThucDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVKhoiLuongThucDayProvider SqlVKhoiLuongThucDayProvider
		{
			get {return VKhoiLuongThucDayProvider as SqlVKhoiLuongThucDayProvider;}
		}
		
		#endregion
		
		
		#region "VLopHocPhanKhongPhanCongProvider"
		
		private SqlVLopHocPhanKhongPhanCongProvider innerSqlVLopHocPhanKhongPhanCongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VLopHocPhanKhongPhanCong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VLopHocPhanKhongPhanCongProviderBase VLopHocPhanKhongPhanCongProvider
		{
			get
			{
				if (innerSqlVLopHocPhanKhongPhanCongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVLopHocPhanKhongPhanCongProvider == null)
						{
							this.innerSqlVLopHocPhanKhongPhanCongProvider = new SqlVLopHocPhanKhongPhanCongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVLopHocPhanKhongPhanCongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVLopHocPhanKhongPhanCongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVLopHocPhanKhongPhanCongProvider SqlVLopHocPhanKhongPhanCongProvider
		{
			get {return VLopHocPhanKhongPhanCongProvider as SqlVLopHocPhanKhongPhanCongProvider;}
		}
		
		#endregion
		
		
		#region "VMonHocTinChiProvider"
		
		private SqlVMonHocTinChiProvider innerSqlVMonHocTinChiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VMonHocTinChi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VMonHocTinChiProviderBase VMonHocTinChiProvider
		{
			get
			{
				if (innerSqlVMonHocTinChiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVMonHocTinChiProvider == null)
						{
							this.innerSqlVMonHocTinChiProvider = new SqlVMonHocTinChiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVMonHocTinChiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVMonHocTinChiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVMonHocTinChiProvider SqlVMonHocTinChiProvider
		{
			get {return VMonHocTinChiProvider as SqlVMonHocTinChiProvider;}
		}
		
		#endregion
		
		
		#region "VThanhToanThuLaoProvider"
		
		private SqlVThanhToanThuLaoProvider innerSqlVThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VThanhToanThuLaoProviderBase VThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlVThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVThanhToanThuLaoProvider == null)
						{
							this.innerSqlVThanhToanThuLaoProvider = new SqlVThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVThanhToanThuLaoProvider SqlVThanhToanThuLaoProvider
		{
			get {return VThanhToanThuLaoProvider as SqlVThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "VTongHopKhoiLuongProvider"
		
		private SqlVTongHopKhoiLuongProvider innerSqlVTongHopKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VTongHopKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VTongHopKhoiLuongProviderBase VTongHopKhoiLuongProvider
		{
			get
			{
				if (innerSqlVTongHopKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVTongHopKhoiLuongProvider == null)
						{
							this.innerSqlVTongHopKhoiLuongProvider = new SqlVTongHopKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVTongHopKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVTongHopKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVTongHopKhoiLuongProvider SqlVTongHopKhoiLuongProvider
		{
			get {return VTongHopKhoiLuongProvider as SqlVTongHopKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "VTongHopQuyDoiProvider"
		
		private SqlVTongHopQuyDoiProvider innerSqlVTongHopQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VTongHopQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VTongHopQuyDoiProviderBase VTongHopQuyDoiProvider
		{
			get
			{
				if (innerSqlVTongHopQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVTongHopQuyDoiProvider == null)
						{
							this.innerSqlVTongHopQuyDoiProvider = new SqlVTongHopQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVTongHopQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVTongHopQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVTongHopQuyDoiProvider SqlVTongHopQuyDoiProvider
		{
			get {return VTongHopQuyDoiProvider as SqlVTongHopQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "VTongHopThuLaoProvider"
		
		private SqlVTongHopThuLaoProvider innerSqlVTongHopThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="VTongHopThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override VTongHopThuLaoProviderBase VTongHopThuLaoProvider
		{
			get
			{
				if (innerSqlVTongHopThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlVTongHopThuLaoProvider == null)
						{
							this.innerSqlVTongHopThuLaoProvider = new SqlVTongHopThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlVTongHopThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlVTongHopThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlVTongHopThuLaoProvider SqlVTongHopThuLaoProvider
		{
			get {return VTongHopThuLaoProvider as SqlVTongHopThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewBacDaoTaoProvider"
		
		private SqlViewBacDaoTaoProvider innerSqlViewBacDaoTaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewBacDaoTao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewBacDaoTaoProviderBase ViewBacDaoTaoProvider
		{
			get
			{
				if (innerSqlViewBacDaoTaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewBacDaoTaoProvider == null)
						{
							this.innerSqlViewBacDaoTaoProvider = new SqlViewBacDaoTaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewBacDaoTaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewBacDaoTaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewBacDaoTaoProvider SqlViewBacDaoTaoProvider
		{
			get {return ViewBacDaoTaoProvider as SqlViewBacDaoTaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewBacDaoTaoLoaiHinhProvider"
		
		private SqlViewBacDaoTaoLoaiHinhProvider innerSqlViewBacDaoTaoLoaiHinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewBacDaoTaoLoaiHinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewBacDaoTaoLoaiHinhProviderBase ViewBacDaoTaoLoaiHinhProvider
		{
			get
			{
				if (innerSqlViewBacDaoTaoLoaiHinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewBacDaoTaoLoaiHinhProvider == null)
						{
							this.innerSqlViewBacDaoTaoLoaiHinhProvider = new SqlViewBacDaoTaoLoaiHinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewBacDaoTaoLoaiHinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewBacDaoTaoLoaiHinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewBacDaoTaoLoaiHinhProvider SqlViewBacDaoTaoLoaiHinhProvider
		{
			get {return ViewBacDaoTaoLoaiHinhProvider as SqlViewBacDaoTaoLoaiHinhProvider;}
		}
		
		#endregion
		
		
		#region "ViewBangPhuTroiGioDayGiangVienProvider"
		
		private SqlViewBangPhuTroiGioDayGiangVienProvider innerSqlViewBangPhuTroiGioDayGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewBangPhuTroiGioDayGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewBangPhuTroiGioDayGiangVienProviderBase ViewBangPhuTroiGioDayGiangVienProvider
		{
			get
			{
				if (innerSqlViewBangPhuTroiGioDayGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewBangPhuTroiGioDayGiangVienProvider == null)
						{
							this.innerSqlViewBangPhuTroiGioDayGiangVienProvider = new SqlViewBangPhuTroiGioDayGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewBangPhuTroiGioDayGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewBangPhuTroiGioDayGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewBangPhuTroiGioDayGiangVienProvider SqlViewBangPhuTroiGioDayGiangVienProvider
		{
			get {return ViewBangPhuTroiGioDayGiangVienProvider as SqlViewBangPhuTroiGioDayGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ViewBuoiProvider"
		
		private SqlViewBuoiProvider innerSqlViewBuoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewBuoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewBuoiProviderBase ViewBuoiProvider
		{
			get
			{
				if (innerSqlViewBuoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewBuoiProvider == null)
						{
							this.innerSqlViewBuoiProvider = new SqlViewBuoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewBuoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewBuoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewBuoiProvider SqlViewBuoiProvider
		{
			get {return ViewBuoiProvider as SqlViewBuoiProvider;}
		}
		
		#endregion
		
		
		#region "ViewCauHinhProvider"
		
		private SqlViewCauHinhProvider innerSqlViewCauHinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewCauHinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewCauHinhProviderBase ViewCauHinhProvider
		{
			get
			{
				if (innerSqlViewCauHinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewCauHinhProvider == null)
						{
							this.innerSqlViewCauHinhProvider = new SqlViewCauHinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewCauHinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewCauHinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewCauHinhProvider SqlViewCauHinhProvider
		{
			get {return ViewCauHinhProvider as SqlViewCauHinhProvider;}
		}
		
		#endregion
		
		
		#region "ViewChiTienCoVanProvider"
		
		private SqlViewChiTienCoVanProvider innerSqlViewChiTienCoVanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewChiTienCoVan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewChiTienCoVanProviderBase ViewChiTienCoVanProvider
		{
			get
			{
				if (innerSqlViewChiTienCoVanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewChiTienCoVanProvider == null)
						{
							this.innerSqlViewChiTienCoVanProvider = new SqlViewChiTienCoVanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewChiTienCoVanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewChiTienCoVanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewChiTienCoVanProvider SqlViewChiTienCoVanProvider
		{
			get {return ViewChiTienCoVanProvider as SqlViewChiTienCoVanProvider;}
		}
		
		#endregion
		
		
		#region "ViewChiTietGiangDayProvider"
		
		private SqlViewChiTietGiangDayProvider innerSqlViewChiTietGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewChiTietGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewChiTietGiangDayProviderBase ViewChiTietGiangDayProvider
		{
			get
			{
				if (innerSqlViewChiTietGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewChiTietGiangDayProvider == null)
						{
							this.innerSqlViewChiTietGiangDayProvider = new SqlViewChiTietGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewChiTietGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewChiTietGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewChiTietGiangDayProvider SqlViewChiTietGiangDayProvider
		{
			get {return ViewChiTietGiangDayProvider as SqlViewChiTietGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewChiTietHocPhanProvider"
		
		private SqlViewChiTietHocPhanProvider innerSqlViewChiTietHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewChiTietHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewChiTietHocPhanProviderBase ViewChiTietHocPhanProvider
		{
			get
			{
				if (innerSqlViewChiTietHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewChiTietHocPhanProvider == null)
						{
							this.innerSqlViewChiTietHocPhanProvider = new SqlViewChiTietHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewChiTietHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewChiTietHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewChiTietHocPhanProvider SqlViewChiTietHocPhanProvider
		{
			get {return ViewChiTietHocPhanProvider as SqlViewChiTietHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "ViewChiTietKhoiLuongProvider"
		
		private SqlViewChiTietKhoiLuongProvider innerSqlViewChiTietKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewChiTietKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewChiTietKhoiLuongProviderBase ViewChiTietKhoiLuongProvider
		{
			get
			{
				if (innerSqlViewChiTietKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewChiTietKhoiLuongProvider == null)
						{
							this.innerSqlViewChiTietKhoiLuongProvider = new SqlViewChiTietKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewChiTietKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewChiTietKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewChiTietKhoiLuongProvider SqlViewChiTietKhoiLuongProvider
		{
			get {return ViewChiTietKhoiLuongProvider as SqlViewChiTietKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "ViewChiTietKhoiLuongGiangDayProvider"
		
		private SqlViewChiTietKhoiLuongGiangDayProvider innerSqlViewChiTietKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewChiTietKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewChiTietKhoiLuongGiangDayProviderBase ViewChiTietKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlViewChiTietKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewChiTietKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlViewChiTietKhoiLuongGiangDayProvider = new SqlViewChiTietKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewChiTietKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewChiTietKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewChiTietKhoiLuongGiangDayProvider SqlViewChiTietKhoiLuongGiangDayProvider
		{
			get {return ViewChiTietKhoiLuongGiangDayProvider as SqlViewChiTietKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewChiTietKhoiLuongThucDayProvider"
		
		private SqlViewChiTietKhoiLuongThucDayProvider innerSqlViewChiTietKhoiLuongThucDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewChiTietKhoiLuongThucDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewChiTietKhoiLuongThucDayProviderBase ViewChiTietKhoiLuongThucDayProvider
		{
			get
			{
				if (innerSqlViewChiTietKhoiLuongThucDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewChiTietKhoiLuongThucDayProvider == null)
						{
							this.innerSqlViewChiTietKhoiLuongThucDayProvider = new SqlViewChiTietKhoiLuongThucDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewChiTietKhoiLuongThucDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewChiTietKhoiLuongThucDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewChiTietKhoiLuongThucDayProvider SqlViewChiTietKhoiLuongThucDayProvider
		{
			get {return ViewChiTietKhoiLuongThucDayProvider as SqlViewChiTietKhoiLuongThucDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewChiTietPhanCongGiangDayProvider"
		
		private SqlViewChiTietPhanCongGiangDayProvider innerSqlViewChiTietPhanCongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewChiTietPhanCongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewChiTietPhanCongGiangDayProviderBase ViewChiTietPhanCongGiangDayProvider
		{
			get
			{
				if (innerSqlViewChiTietPhanCongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewChiTietPhanCongGiangDayProvider == null)
						{
							this.innerSqlViewChiTietPhanCongGiangDayProvider = new SqlViewChiTietPhanCongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewChiTietPhanCongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewChiTietPhanCongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewChiTietPhanCongGiangDayProvider SqlViewChiTietPhanCongGiangDayProvider
		{
			get {return ViewChiTietPhanCongGiangDayProvider as SqlViewChiTietPhanCongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewChiTietQuyDoiProvider"
		
		private SqlViewChiTietQuyDoiProvider innerSqlViewChiTietQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewChiTietQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewChiTietQuyDoiProviderBase ViewChiTietQuyDoiProvider
		{
			get
			{
				if (innerSqlViewChiTietQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewChiTietQuyDoiProvider == null)
						{
							this.innerSqlViewChiTietQuyDoiProvider = new SqlViewChiTietQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewChiTietQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewChiTietQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewChiTietQuyDoiProvider SqlViewChiTietQuyDoiProvider
		{
			get {return ViewChiTietQuyDoiProvider as SqlViewChiTietQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "ViewCoSoProvider"
		
		private SqlViewCoSoProvider innerSqlViewCoSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewCoSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewCoSoProviderBase ViewCoSoProvider
		{
			get
			{
				if (innerSqlViewCoSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewCoSoProvider == null)
						{
							this.innerSqlViewCoSoProvider = new SqlViewCoSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewCoSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewCoSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewCoSoProvider SqlViewCoSoProvider
		{
			get {return ViewCoSoProvider as SqlViewCoSoProvider;}
		}
		
		#endregion
		
		
		#region "ViewCoVanHocTapProvider"
		
		private SqlViewCoVanHocTapProvider innerSqlViewCoVanHocTapProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewCoVanHocTap"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewCoVanHocTapProviderBase ViewCoVanHocTapProvider
		{
			get
			{
				if (innerSqlViewCoVanHocTapProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewCoVanHocTapProvider == null)
						{
							this.innerSqlViewCoVanHocTapProvider = new SqlViewCoVanHocTapProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewCoVanHocTapProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewCoVanHocTapProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewCoVanHocTapProvider SqlViewCoVanHocTapProvider
		{
			get {return ViewCoVanHocTapProvider as SqlViewCoVanHocTapProvider;}
		}
		
		#endregion
		
		
		#region "ViewDanhSachHopDongThinhGiangProvider"
		
		private SqlViewDanhSachHopDongThinhGiangProvider innerSqlViewDanhSachHopDongThinhGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewDanhSachHopDongThinhGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewDanhSachHopDongThinhGiangProviderBase ViewDanhSachHopDongThinhGiangProvider
		{
			get
			{
				if (innerSqlViewDanhSachHopDongThinhGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewDanhSachHopDongThinhGiangProvider == null)
						{
							this.innerSqlViewDanhSachHopDongThinhGiangProvider = new SqlViewDanhSachHopDongThinhGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewDanhSachHopDongThinhGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewDanhSachHopDongThinhGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewDanhSachHopDongThinhGiangProvider SqlViewDanhSachHopDongThinhGiangProvider
		{
			get {return ViewDanhSachHopDongThinhGiangProvider as SqlViewDanhSachHopDongThinhGiangProvider;}
		}
		
		#endregion
		
		
		#region "ViewDanhSachLopPhanCongGiangDayProvider"
		
		private SqlViewDanhSachLopPhanCongGiangDayProvider innerSqlViewDanhSachLopPhanCongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewDanhSachLopPhanCongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewDanhSachLopPhanCongGiangDayProviderBase ViewDanhSachLopPhanCongGiangDayProvider
		{
			get
			{
				if (innerSqlViewDanhSachLopPhanCongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewDanhSachLopPhanCongGiangDayProvider == null)
						{
							this.innerSqlViewDanhSachLopPhanCongGiangDayProvider = new SqlViewDanhSachLopPhanCongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewDanhSachLopPhanCongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewDanhSachLopPhanCongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewDanhSachLopPhanCongGiangDayProvider SqlViewDanhSachLopPhanCongGiangDayProvider
		{
			get {return ViewDanhSachLopPhanCongGiangDayProvider as SqlViewDanhSachLopPhanCongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewDanTocProvider"
		
		private SqlViewDanTocProvider innerSqlViewDanTocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewDanToc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewDanTocProviderBase ViewDanTocProvider
		{
			get
			{
				if (innerSqlViewDanTocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewDanTocProvider == null)
						{
							this.innerSqlViewDanTocProvider = new SqlViewDanTocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewDanTocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewDanTocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewDanTocProvider SqlViewDanTocProvider
		{
			get {return ViewDanTocProvider as SqlViewDanTocProvider;}
		}
		
		#endregion
		
		
		#region "ViewDoiTuongDonGiaProvider"
		
		private SqlViewDoiTuongDonGiaProvider innerSqlViewDoiTuongDonGiaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewDoiTuongDonGia"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewDoiTuongDonGiaProviderBase ViewDoiTuongDonGiaProvider
		{
			get
			{
				if (innerSqlViewDoiTuongDonGiaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewDoiTuongDonGiaProvider == null)
						{
							this.innerSqlViewDoiTuongDonGiaProvider = new SqlViewDoiTuongDonGiaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewDoiTuongDonGiaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewDoiTuongDonGiaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewDoiTuongDonGiaProvider SqlViewDoiTuongDonGiaProvider
		{
			get {return ViewDoiTuongDonGiaProvider as SqlViewDoiTuongDonGiaProvider;}
		}
		
		#endregion
		
		
		#region "ViewDonGiaNgoaiQuyCheProvider"
		
		private SqlViewDonGiaNgoaiQuyCheProvider innerSqlViewDonGiaNgoaiQuyCheProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewDonGiaNgoaiQuyChe"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewDonGiaNgoaiQuyCheProviderBase ViewDonGiaNgoaiQuyCheProvider
		{
			get
			{
				if (innerSqlViewDonGiaNgoaiQuyCheProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewDonGiaNgoaiQuyCheProvider == null)
						{
							this.innerSqlViewDonGiaNgoaiQuyCheProvider = new SqlViewDonGiaNgoaiQuyCheProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewDonGiaNgoaiQuyCheProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewDonGiaNgoaiQuyCheProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewDonGiaNgoaiQuyCheProvider SqlViewDonGiaNgoaiQuyCheProvider
		{
			get {return ViewDonGiaNgoaiQuyCheProvider as SqlViewDonGiaNgoaiQuyCheProvider;}
		}
		
		#endregion
		
		
		#region "ViewDonViProvider"
		
		private SqlViewDonViProvider innerSqlViewDonViProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewDonVi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewDonViProviderBase ViewDonViProvider
		{
			get
			{
				if (innerSqlViewDonViProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewDonViProvider == null)
						{
							this.innerSqlViewDonViProvider = new SqlViewDonViProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewDonViProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewDonViProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewDonViProvider SqlViewDonViProvider
		{
			get {return ViewDonViProvider as SqlViewDonViProvider;}
		}
		
		#endregion
		
		
		#region "ViewGiamTruGioChuanProvider"
		
		private SqlViewGiamTruGioChuanProvider innerSqlViewGiamTruGioChuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewGiamTruGioChuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewGiamTruGioChuanProviderBase ViewGiamTruGioChuanProvider
		{
			get
			{
				if (innerSqlViewGiamTruGioChuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewGiamTruGioChuanProvider == null)
						{
							this.innerSqlViewGiamTruGioChuanProvider = new SqlViewGiamTruGioChuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewGiamTruGioChuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewGiamTruGioChuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewGiamTruGioChuanProvider SqlViewGiamTruGioChuanProvider
		{
			get {return ViewGiamTruGioChuanProvider as SqlViewGiamTruGioChuanProvider;}
		}
		
		#endregion
		
		
		#region "ViewGiangVienProvider"
		
		private SqlViewGiangVienProvider innerSqlViewGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewGiangVienProviderBase ViewGiangVienProvider
		{
			get
			{
				if (innerSqlViewGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewGiangVienProvider == null)
						{
							this.innerSqlViewGiangVienProvider = new SqlViewGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewGiangVienProvider SqlViewGiangVienProvider
		{
			get {return ViewGiangVienProvider as SqlViewGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ViewGiangVienKhoaProvider"
		
		private SqlViewGiangVienKhoaProvider innerSqlViewGiangVienKhoaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewGiangVienKhoa"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewGiangVienKhoaProviderBase ViewGiangVienKhoaProvider
		{
			get
			{
				if (innerSqlViewGiangVienKhoaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewGiangVienKhoaProvider == null)
						{
							this.innerSqlViewGiangVienKhoaProvider = new SqlViewGiangVienKhoaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewGiangVienKhoaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewGiangVienKhoaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewGiangVienKhoaProvider SqlViewGiangVienKhoaProvider
		{
			get {return ViewGiangVienKhoaProvider as SqlViewGiangVienKhoaProvider;}
		}
		
		#endregion
		
		
		#region "ViewGiangVienLopHocPhanProvider"
		
		private SqlViewGiangVienLopHocPhanProvider innerSqlViewGiangVienLopHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewGiangVienLopHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewGiangVienLopHocPhanProviderBase ViewGiangVienLopHocPhanProvider
		{
			get
			{
				if (innerSqlViewGiangVienLopHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewGiangVienLopHocPhanProvider == null)
						{
							this.innerSqlViewGiangVienLopHocPhanProvider = new SqlViewGiangVienLopHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewGiangVienLopHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewGiangVienLopHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewGiangVienLopHocPhanProvider SqlViewGiangVienLopHocPhanProvider
		{
			get {return ViewGiangVienLopHocPhanProvider as SqlViewGiangVienLopHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "ViewGiangVienNckhProvider"
		
		private SqlViewGiangVienNckhProvider innerSqlViewGiangVienNckhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewGiangVienNckh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewGiangVienNckhProviderBase ViewGiangVienNckhProvider
		{
			get
			{
				if (innerSqlViewGiangVienNckhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewGiangVienNckhProvider == null)
						{
							this.innerSqlViewGiangVienNckhProvider = new SqlViewGiangVienNckhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewGiangVienNckhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewGiangVienNckhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewGiangVienNckhProvider SqlViewGiangVienNckhProvider
		{
			get {return ViewGiangVienNckhProvider as SqlViewGiangVienNckhProvider;}
		}
		
		#endregion
		
		
		#region "ViewGiangVienNghienCuuKhoaHocProvider"
		
		private SqlViewGiangVienNghienCuuKhoaHocProvider innerSqlViewGiangVienNghienCuuKhoaHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewGiangVienNghienCuuKhoaHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewGiangVienNghienCuuKhoaHocProviderBase ViewGiangVienNghienCuuKhoaHocProvider
		{
			get
			{
				if (innerSqlViewGiangVienNghienCuuKhoaHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewGiangVienNghienCuuKhoaHocProvider == null)
						{
							this.innerSqlViewGiangVienNghienCuuKhoaHocProvider = new SqlViewGiangVienNghienCuuKhoaHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewGiangVienNghienCuuKhoaHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewGiangVienNghienCuuKhoaHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewGiangVienNghienCuuKhoaHocProvider SqlViewGiangVienNghienCuuKhoaHocProvider
		{
			get {return ViewGiangVienNghienCuuKhoaHocProvider as SqlViewGiangVienNghienCuuKhoaHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewHeDaoTaoProvider"
		
		private SqlViewHeDaoTaoProvider innerSqlViewHeDaoTaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHeDaoTao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHeDaoTaoProviderBase ViewHeDaoTaoProvider
		{
			get
			{
				if (innerSqlViewHeDaoTaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHeDaoTaoProvider == null)
						{
							this.innerSqlViewHeDaoTaoProvider = new SqlViewHeDaoTaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHeDaoTaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHeDaoTaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHeDaoTaoProvider SqlViewHeDaoTaoProvider
		{
			get {return ViewHeDaoTaoProvider as SqlViewHeDaoTaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewHeSoLopDongHbuProvider"
		
		private SqlViewHeSoLopDongHbuProvider innerSqlViewHeSoLopDongHbuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHeSoLopDongHbu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHeSoLopDongHbuProviderBase ViewHeSoLopDongHbuProvider
		{
			get
			{
				if (innerSqlViewHeSoLopDongHbuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHeSoLopDongHbuProvider == null)
						{
							this.innerSqlViewHeSoLopDongHbuProvider = new SqlViewHeSoLopDongHbuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHeSoLopDongHbuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHeSoLopDongHbuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHeSoLopDongHbuProvider SqlViewHeSoLopDongHbuProvider
		{
			get {return ViewHeSoLopDongHbuProvider as SqlViewHeSoLopDongHbuProvider;}
		}
		
		#endregion
		
		
		#region "ViewHeSoLuongHocHamHocViProvider"
		
		private SqlViewHeSoLuongHocHamHocViProvider innerSqlViewHeSoLuongHocHamHocViProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHeSoLuongHocHamHocVi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHeSoLuongHocHamHocViProviderBase ViewHeSoLuongHocHamHocViProvider
		{
			get
			{
				if (innerSqlViewHeSoLuongHocHamHocViProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHeSoLuongHocHamHocViProvider == null)
						{
							this.innerSqlViewHeSoLuongHocHamHocViProvider = new SqlViewHeSoLuongHocHamHocViProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHeSoLuongHocHamHocViProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHeSoLuongHocHamHocViProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHeSoLuongHocHamHocViProvider SqlViewHeSoLuongHocHamHocViProvider
		{
			get {return ViewHeSoLuongHocHamHocViProvider as SqlViewHeSoLuongHocHamHocViProvider;}
		}
		
		#endregion
		
		
		#region "ViewHesoThuLaoProvider"
		
		private SqlViewHesoThuLaoProvider innerSqlViewHesoThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHesoThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHesoThuLaoProviderBase ViewHesoThuLaoProvider
		{
			get
			{
				if (innerSqlViewHesoThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHesoThuLaoProvider == null)
						{
							this.innerSqlViewHesoThuLaoProvider = new SqlViewHesoThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHesoThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHesoThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHesoThuLaoProvider SqlViewHesoThuLaoProvider
		{
			get {return ViewHesoThuLaoProvider as SqlViewHesoThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewHeSoTinChiProvider"
		
		private SqlViewHeSoTinChiProvider innerSqlViewHeSoTinChiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHeSoTinChi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHeSoTinChiProviderBase ViewHeSoTinChiProvider
		{
			get
			{
				if (innerSqlViewHeSoTinChiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHeSoTinChiProvider == null)
						{
							this.innerSqlViewHeSoTinChiProvider = new SqlViewHeSoTinChiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHeSoTinChiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHeSoTinChiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHeSoTinChiProvider SqlViewHeSoTinChiProvider
		{
			get {return ViewHeSoTinChiProvider as SqlViewHeSoTinChiProvider;}
		}
		
		#endregion
		
		
		#region "ViewHinhThucThiProvider"
		
		private SqlViewHinhThucThiProvider innerSqlViewHinhThucThiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHinhThucThi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHinhThucThiProviderBase ViewHinhThucThiProvider
		{
			get
			{
				if (innerSqlViewHinhThucThiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHinhThucThiProvider == null)
						{
							this.innerSqlViewHinhThucThiProvider = new SqlViewHinhThucThiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHinhThucThiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHinhThucThiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHinhThucThiProvider SqlViewHinhThucThiProvider
		{
			get {return ViewHinhThucThiProvider as SqlViewHinhThucThiProvider;}
		}
		
		#endregion
		
		
		#region "ViewHinhThucViPhamProvider"
		
		private SqlViewHinhThucViPhamProvider innerSqlViewHinhThucViPhamProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHinhThucViPham"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHinhThucViPhamProviderBase ViewHinhThucViPhamProvider
		{
			get
			{
				if (innerSqlViewHinhThucViPhamProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHinhThucViPhamProvider == null)
						{
							this.innerSqlViewHinhThucViPhamProvider = new SqlViewHinhThucViPhamProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHinhThucViPhamProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHinhThucViPhamProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHinhThucViPhamProvider SqlViewHinhThucViPhamProvider
		{
			get {return ViewHinhThucViPhamProvider as SqlViewHinhThucViPhamProvider;}
		}
		
		#endregion
		
		
		#region "ViewHocKyProvider"
		
		private SqlViewHocKyProvider innerSqlViewHocKyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHocKy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHocKyProviderBase ViewHocKyProvider
		{
			get
			{
				if (innerSqlViewHocKyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHocKyProvider == null)
						{
							this.innerSqlViewHocKyProvider = new SqlViewHocKyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHocKyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHocKyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHocKyProvider SqlViewHocKyProvider
		{
			get {return ViewHocKyProvider as SqlViewHocKyProvider;}
		}
		
		#endregion
		
		
		#region "ViewHocPhanMonHocProvider"
		
		private SqlViewHocPhanMonHocProvider innerSqlViewHocPhanMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHocPhanMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHocPhanMonHocProviderBase ViewHocPhanMonHocProvider
		{
			get
			{
				if (innerSqlViewHocPhanMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHocPhanMonHocProvider == null)
						{
							this.innerSqlViewHocPhanMonHocProvider = new SqlViewHocPhanMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHocPhanMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHocPhanMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHocPhanMonHocProvider SqlViewHocPhanMonHocProvider
		{
			get {return ViewHocPhanMonHocProvider as SqlViewHocPhanMonHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewHopDongThinhGiangProvider"
		
		private SqlViewHopDongThinhGiangProvider innerSqlViewHopDongThinhGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewHopDongThinhGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewHopDongThinhGiangProviderBase ViewHopDongThinhGiangProvider
		{
			get
			{
				if (innerSqlViewHopDongThinhGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewHopDongThinhGiangProvider == null)
						{
							this.innerSqlViewHopDongThinhGiangProvider = new SqlViewHopDongThinhGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewHopDongThinhGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewHopDongThinhGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewHopDongThinhGiangProvider SqlViewHopDongThinhGiangProvider
		{
			get {return ViewHopDongThinhGiangProvider as SqlViewHopDongThinhGiangProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqDonGiaNgoaiQuyCheProvider"
		
		private SqlViewKcqDonGiaNgoaiQuyCheProvider innerSqlViewKcqDonGiaNgoaiQuyCheProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqDonGiaNgoaiQuyChe"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqDonGiaNgoaiQuyCheProviderBase ViewKcqDonGiaNgoaiQuyCheProvider
		{
			get
			{
				if (innerSqlViewKcqDonGiaNgoaiQuyCheProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqDonGiaNgoaiQuyCheProvider == null)
						{
							this.innerSqlViewKcqDonGiaNgoaiQuyCheProvider = new SqlViewKcqDonGiaNgoaiQuyCheProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqDonGiaNgoaiQuyCheProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqDonGiaNgoaiQuyCheProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqDonGiaNgoaiQuyCheProvider SqlViewKcqDonGiaNgoaiQuyCheProvider
		{
			get {return ViewKcqDonGiaNgoaiQuyCheProvider as SqlViewKcqDonGiaNgoaiQuyCheProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqHopDongThinhGiangProvider"
		
		private SqlViewKcqHopDongThinhGiangProvider innerSqlViewKcqHopDongThinhGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqHopDongThinhGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqHopDongThinhGiangProviderBase ViewKcqHopDongThinhGiangProvider
		{
			get
			{
				if (innerSqlViewKcqHopDongThinhGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqHopDongThinhGiangProvider == null)
						{
							this.innerSqlViewKcqHopDongThinhGiangProvider = new SqlViewKcqHopDongThinhGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqHopDongThinhGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqHopDongThinhGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqHopDongThinhGiangProvider SqlViewKcqHopDongThinhGiangProvider
		{
			get {return ViewKcqHopDongThinhGiangProvider as SqlViewKcqHopDongThinhGiangProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqKetQuaThanhToanThuLaoProvider"
		
		private SqlViewKcqKetQuaThanhToanThuLaoProvider innerSqlViewKcqKetQuaThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqKetQuaThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqKetQuaThanhToanThuLaoProviderBase ViewKcqKetQuaThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlViewKcqKetQuaThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqKetQuaThanhToanThuLaoProvider == null)
						{
							this.innerSqlViewKcqKetQuaThanhToanThuLaoProvider = new SqlViewKcqKetQuaThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqKetQuaThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqKetQuaThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqKetQuaThanhToanThuLaoProvider SqlViewKcqKetQuaThanhToanThuLaoProvider
		{
			get {return ViewKcqKetQuaThanhToanThuLaoProvider as SqlViewKcqKetQuaThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider"
		
		private SqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider innerSqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqLietKeKhoiLuongGiangDayChiTiet2"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqLietKeKhoiLuongGiangDayChiTiet2ProviderBase ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider
		{
			get
			{
				if (innerSqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider == null)
						{
							this.innerSqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider = new SqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider SqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider
		{
			get {return ViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider as SqlViewKcqLietKeKhoiLuongGiangDayChiTiet2Provider;}
		}
		
		#endregion
		
		
		#region "ViewKcqMonThucTapTotNghiepProvider"
		
		private SqlViewKcqMonThucTapTotNghiepProvider innerSqlViewKcqMonThucTapTotNghiepProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqMonThucTapTotNghiep"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqMonThucTapTotNghiepProviderBase ViewKcqMonThucTapTotNghiepProvider
		{
			get
			{
				if (innerSqlViewKcqMonThucTapTotNghiepProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqMonThucTapTotNghiepProvider == null)
						{
							this.innerSqlViewKcqMonThucTapTotNghiepProvider = new SqlViewKcqMonThucTapTotNghiepProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqMonThucTapTotNghiepProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqMonThucTapTotNghiepProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqMonThucTapTotNghiepProvider SqlViewKcqMonThucTapTotNghiepProvider
		{
			get {return ViewKcqMonThucTapTotNghiepProvider as SqlViewKcqMonThucTapTotNghiepProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqMonTinhTheoQuyCheMoiProvider"
		
		private SqlViewKcqMonTinhTheoQuyCheMoiProvider innerSqlViewKcqMonTinhTheoQuyCheMoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqMonTinhTheoQuyCheMoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqMonTinhTheoQuyCheMoiProviderBase ViewKcqMonTinhTheoQuyCheMoiProvider
		{
			get
			{
				if (innerSqlViewKcqMonTinhTheoQuyCheMoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqMonTinhTheoQuyCheMoiProvider == null)
						{
							this.innerSqlViewKcqMonTinhTheoQuyCheMoiProvider = new SqlViewKcqMonTinhTheoQuyCheMoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqMonTinhTheoQuyCheMoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqMonTinhTheoQuyCheMoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqMonTinhTheoQuyCheMoiProvider SqlViewKcqMonTinhTheoQuyCheMoiProvider
		{
			get {return ViewKcqMonTinhTheoQuyCheMoiProvider as SqlViewKcqMonTinhTheoQuyCheMoiProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqMonXepLichChuNhatKhongTinhHeSoProvider"
		
		private SqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider innerSqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqMonXepLichChuNhatKhongTinhHeSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqMonXepLichChuNhatKhongTinhHeSoProviderBase ViewKcqMonXepLichChuNhatKhongTinhHeSoProvider
		{
			get
			{
				if (innerSqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider == null)
						{
							this.innerSqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider = new SqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider SqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider
		{
			get {return ViewKcqMonXepLichChuNhatKhongTinhHeSoProvider as SqlViewKcqMonXepLichChuNhatKhongTinhHeSoProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqPhanNhomMonHocProvider"
		
		private SqlViewKcqPhanNhomMonHocProvider innerSqlViewKcqPhanNhomMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqPhanNhomMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqPhanNhomMonHocProviderBase ViewKcqPhanNhomMonHocProvider
		{
			get
			{
				if (innerSqlViewKcqPhanNhomMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqPhanNhomMonHocProvider == null)
						{
							this.innerSqlViewKcqPhanNhomMonHocProvider = new SqlViewKcqPhanNhomMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqPhanNhomMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqPhanNhomMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqPhanNhomMonHocProvider SqlViewKcqPhanNhomMonHocProvider
		{
			get {return ViewKcqPhanNhomMonHocProvider as SqlViewKcqPhanNhomMonHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqPhanNhomMonHocActProvider"
		
		private SqlViewKcqPhanNhomMonHocActProvider innerSqlViewKcqPhanNhomMonHocActProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqPhanNhomMonHocAct"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqPhanNhomMonHocActProviderBase ViewKcqPhanNhomMonHocActProvider
		{
			get
			{
				if (innerSqlViewKcqPhanNhomMonHocActProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqPhanNhomMonHocActProvider == null)
						{
							this.innerSqlViewKcqPhanNhomMonHocActProvider = new SqlViewKcqPhanNhomMonHocActProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqPhanNhomMonHocActProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqPhanNhomMonHocActProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqPhanNhomMonHocActProvider SqlViewKcqPhanNhomMonHocActProvider
		{
			get {return ViewKcqPhanNhomMonHocActProvider as SqlViewKcqPhanNhomMonHocActProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqPhuCapHanhChinhProvider"
		
		private SqlViewKcqPhuCapHanhChinhProvider innerSqlViewKcqPhuCapHanhChinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqPhuCapHanhChinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqPhuCapHanhChinhProviderBase ViewKcqPhuCapHanhChinhProvider
		{
			get
			{
				if (innerSqlViewKcqPhuCapHanhChinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqPhuCapHanhChinhProvider == null)
						{
							this.innerSqlViewKcqPhuCapHanhChinhProvider = new SqlViewKcqPhuCapHanhChinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqPhuCapHanhChinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqPhuCapHanhChinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqPhuCapHanhChinhProvider SqlViewKcqPhuCapHanhChinhProvider
		{
			get {return ViewKcqPhuCapHanhChinhProvider as SqlViewKcqPhuCapHanhChinhProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqUteKhoiLuongGiangDayProvider"
		
		private SqlViewKcqUteKhoiLuongGiangDayProvider innerSqlViewKcqUteKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqUteKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqUteKhoiLuongGiangDayProviderBase ViewKcqUteKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlViewKcqUteKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqUteKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlViewKcqUteKhoiLuongGiangDayProvider = new SqlViewKcqUteKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqUteKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqUteKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqUteKhoiLuongGiangDayProvider SqlViewKcqUteKhoiLuongGiangDayProvider
		{
			get {return ViewKcqUteKhoiLuongGiangDayProvider as SqlViewKcqUteKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewKcqUteKhoiLuongQuyDoi2Provider"
		
		private SqlViewKcqUteKhoiLuongQuyDoi2Provider innerSqlViewKcqUteKhoiLuongQuyDoi2Provider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKcqUteKhoiLuongQuyDoi2"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKcqUteKhoiLuongQuyDoi2ProviderBase ViewKcqUteKhoiLuongQuyDoi2Provider
		{
			get
			{
				if (innerSqlViewKcqUteKhoiLuongQuyDoi2Provider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKcqUteKhoiLuongQuyDoi2Provider == null)
						{
							this.innerSqlViewKcqUteKhoiLuongQuyDoi2Provider = new SqlViewKcqUteKhoiLuongQuyDoi2Provider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKcqUteKhoiLuongQuyDoi2Provider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKcqUteKhoiLuongQuyDoi2Provider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKcqUteKhoiLuongQuyDoi2Provider SqlViewKcqUteKhoiLuongQuyDoi2Provider
		{
			get {return ViewKcqUteKhoiLuongQuyDoi2Provider as SqlViewKcqUteKhoiLuongQuyDoi2Provider;}
		}
		
		#endregion
		
		
		#region "ViewKetQuaCacKhoanChiKhacProvider"
		
		private SqlViewKetQuaCacKhoanChiKhacProvider innerSqlViewKetQuaCacKhoanChiKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKetQuaCacKhoanChiKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKetQuaCacKhoanChiKhacProviderBase ViewKetQuaCacKhoanChiKhacProvider
		{
			get
			{
				if (innerSqlViewKetQuaCacKhoanChiKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKetQuaCacKhoanChiKhacProvider == null)
						{
							this.innerSqlViewKetQuaCacKhoanChiKhacProvider = new SqlViewKetQuaCacKhoanChiKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKetQuaCacKhoanChiKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKetQuaCacKhoanChiKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKetQuaCacKhoanChiKhacProvider SqlViewKetQuaCacKhoanChiKhacProvider
		{
			get {return ViewKetQuaCacKhoanChiKhacProvider as SqlViewKetQuaCacKhoanChiKhacProvider;}
		}
		
		#endregion
		
		
		#region "ViewKetQuaThanhToanThuLaoProvider"
		
		private SqlViewKetQuaThanhToanThuLaoProvider innerSqlViewKetQuaThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKetQuaThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKetQuaThanhToanThuLaoProviderBase ViewKetQuaThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlViewKetQuaThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKetQuaThanhToanThuLaoProvider == null)
						{
							this.innerSqlViewKetQuaThanhToanThuLaoProvider = new SqlViewKetQuaThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKetQuaThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKetQuaThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKetQuaThanhToanThuLaoProvider SqlViewKetQuaThanhToanThuLaoProvider
		{
			get {return ViewKetQuaThanhToanThuLaoProvider as SqlViewKetQuaThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewKetQuaTinhProvider"
		
		private SqlViewKetQuaTinhProvider innerSqlViewKetQuaTinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKetQuaTinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKetQuaTinhProviderBase ViewKetQuaTinhProvider
		{
			get
			{
				if (innerSqlViewKetQuaTinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKetQuaTinhProvider == null)
						{
							this.innerSqlViewKetQuaTinhProvider = new SqlViewKetQuaTinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKetQuaTinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKetQuaTinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKetQuaTinhProvider SqlViewKetQuaTinhProvider
		{
			get {return ViewKetQuaTinhProvider as SqlViewKetQuaTinhProvider;}
		}
		
		#endregion
		
		
		#region "ViewKhoaProvider"
		
		private SqlViewKhoaProvider innerSqlViewKhoaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKhoa"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKhoaProviderBase ViewKhoaProvider
		{
			get
			{
				if (innerSqlViewKhoaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKhoaProvider == null)
						{
							this.innerSqlViewKhoaProvider = new SqlViewKhoaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKhoaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKhoaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKhoaProvider SqlViewKhoaProvider
		{
			get {return ViewKhoaProvider as SqlViewKhoaProvider;}
		}
		
		#endregion
		
		
		#region "ViewKhoaBoMonProvider"
		
		private SqlViewKhoaBoMonProvider innerSqlViewKhoaBoMonProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKhoaBoMon"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKhoaBoMonProviderBase ViewKhoaBoMonProvider
		{
			get
			{
				if (innerSqlViewKhoaBoMonProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKhoaBoMonProvider == null)
						{
							this.innerSqlViewKhoaBoMonProvider = new SqlViewKhoaBoMonProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKhoaBoMonProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKhoaBoMonProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKhoaBoMonProvider SqlViewKhoaBoMonProvider
		{
			get {return ViewKhoaBoMonProvider as SqlViewKhoaBoMonProvider;}
		}
		
		#endregion
		
		
		#region "ViewKhoaHocProvider"
		
		private SqlViewKhoaHocProvider innerSqlViewKhoaHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKhoaHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKhoaHocProviderBase ViewKhoaHocProvider
		{
			get
			{
				if (innerSqlViewKhoaHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKhoaHocProvider == null)
						{
							this.innerSqlViewKhoaHocProvider = new SqlViewKhoaHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKhoaHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKhoaHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKhoaHocProvider SqlViewKhoaHocProvider
		{
			get {return ViewKhoaHocProvider as SqlViewKhoaHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewKhoaHocBacHeProvider"
		
		private SqlViewKhoaHocBacHeProvider innerSqlViewKhoaHocBacHeProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKhoaHocBacHe"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKhoaHocBacHeProviderBase ViewKhoaHocBacHeProvider
		{
			get
			{
				if (innerSqlViewKhoaHocBacHeProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKhoaHocBacHeProvider == null)
						{
							this.innerSqlViewKhoaHocBacHeProvider = new SqlViewKhoaHocBacHeProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKhoaHocBacHeProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKhoaHocBacHeProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKhoaHocBacHeProvider SqlViewKhoaHocBacHeProvider
		{
			get {return ViewKhoaHocBacHeProvider as SqlViewKhoaHocBacHeProvider;}
		}
		
		#endregion
		
		
		#region "ViewKhoiLuongGiangDayProvider"
		
		private SqlViewKhoiLuongGiangDayProvider innerSqlViewKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKhoiLuongGiangDayProviderBase ViewKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlViewKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlViewKhoiLuongGiangDayProvider = new SqlViewKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKhoiLuongGiangDayProvider SqlViewKhoiLuongGiangDayProvider
		{
			get {return ViewKhoiLuongGiangDayProvider as SqlViewKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewKhoiLuongGiangDayCanBoProvider"
		
		private SqlViewKhoiLuongGiangDayCanBoProvider innerSqlViewKhoiLuongGiangDayCanBoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKhoiLuongGiangDayCanBo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKhoiLuongGiangDayCanBoProviderBase ViewKhoiLuongGiangDayCanBoProvider
		{
			get
			{
				if (innerSqlViewKhoiLuongGiangDayCanBoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKhoiLuongGiangDayCanBoProvider == null)
						{
							this.innerSqlViewKhoiLuongGiangDayCanBoProvider = new SqlViewKhoiLuongGiangDayCanBoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKhoiLuongGiangDayCanBoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKhoiLuongGiangDayCanBoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKhoiLuongGiangDayCanBoProvider SqlViewKhoiLuongGiangDayCanBoProvider
		{
			get {return ViewKhoiLuongGiangDayCanBoProvider as SqlViewKhoiLuongGiangDayCanBoProvider;}
		}
		
		#endregion
		
		
		#region "ViewKhoiLuongThucDayProvider"
		
		private SqlViewKhoiLuongThucDayProvider innerSqlViewKhoiLuongThucDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKhoiLuongThucDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKhoiLuongThucDayProviderBase ViewKhoiLuongThucDayProvider
		{
			get
			{
				if (innerSqlViewKhoiLuongThucDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKhoiLuongThucDayProvider == null)
						{
							this.innerSqlViewKhoiLuongThucDayProvider = new SqlViewKhoiLuongThucDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKhoiLuongThucDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKhoiLuongThucDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKhoiLuongThucDayProvider SqlViewKhoiLuongThucDayProvider
		{
			get {return ViewKhoiLuongThucDayProvider as SqlViewKhoiLuongThucDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewKhoiLuongCacCongViecKhacProvider"
		
		private SqlViewKhoiLuongCacCongViecKhacProvider innerSqlViewKhoiLuongCacCongViecKhacProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKhoiLuongCacCongViecKhac"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKhoiLuongCacCongViecKhacProviderBase ViewKhoiLuongCacCongViecKhacProvider
		{
			get
			{
				if (innerSqlViewKhoiLuongCacCongViecKhacProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKhoiLuongCacCongViecKhacProvider == null)
						{
							this.innerSqlViewKhoiLuongCacCongViecKhacProvider = new SqlViewKhoiLuongCacCongViecKhacProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKhoiLuongCacCongViecKhacProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKhoiLuongCacCongViecKhacProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKhoiLuongCacCongViecKhacProvider SqlViewKhoiLuongCacCongViecKhacProvider
		{
			get {return ViewKhoiLuongCacCongViecKhacProvider as SqlViewKhoiLuongCacCongViecKhacProvider;}
		}
		
		#endregion
		
		
		#region "ViewKyThiProvider"
		
		private SqlViewKyThiProvider innerSqlViewKyThiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewKyThi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewKyThiProviderBase ViewKyThiProvider
		{
			get
			{
				if (innerSqlViewKyThiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewKyThiProvider == null)
						{
							this.innerSqlViewKyThiProvider = new SqlViewKyThiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewKyThiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewKyThiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewKyThiProvider SqlViewKyThiProvider
		{
			get {return ViewKyThiProvider as SqlViewKyThiProvider;}
		}
		
		#endregion
		
		
		#region "ViewLietKeKhoiLuongGiangDayChiTietProvider"
		
		private SqlViewLietKeKhoiLuongGiangDayChiTietProvider innerSqlViewLietKeKhoiLuongGiangDayChiTietProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLietKeKhoiLuongGiangDayChiTiet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLietKeKhoiLuongGiangDayChiTietProviderBase ViewLietKeKhoiLuongGiangDayChiTietProvider
		{
			get
			{
				if (innerSqlViewLietKeKhoiLuongGiangDayChiTietProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLietKeKhoiLuongGiangDayChiTietProvider == null)
						{
							this.innerSqlViewLietKeKhoiLuongGiangDayChiTietProvider = new SqlViewLietKeKhoiLuongGiangDayChiTietProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLietKeKhoiLuongGiangDayChiTietProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLietKeKhoiLuongGiangDayChiTietProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLietKeKhoiLuongGiangDayChiTietProvider SqlViewLietKeKhoiLuongGiangDayChiTietProvider
		{
			get {return ViewLietKeKhoiLuongGiangDayChiTietProvider as SqlViewLietKeKhoiLuongGiangDayChiTietProvider;}
		}
		
		#endregion
		
		
		#region "ViewLietKeKhoiLuongGiangDayChiTietUsshProvider"
		
		private SqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLietKeKhoiLuongGiangDayChiTietUssh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLietKeKhoiLuongGiangDayChiTietUsshProviderBase ViewLietKeKhoiLuongGiangDayChiTietUsshProvider
		{
			get
			{
				if (innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider == null)
						{
							this.innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider = new SqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider SqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider
		{
			get {return ViewLietKeKhoiLuongGiangDayChiTietUsshProvider as SqlViewLietKeKhoiLuongGiangDayChiTietUsshProvider;}
		}
		
		#endregion
		
		
		#region "ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider"
		
		private SqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvt"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProviderBase ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider
		{
			get
			{
				if (innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider == null)
						{
							this.innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider = new SqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider SqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider
		{
			get {return ViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider as SqlViewLietKeKhoiLuongGiangDayChiTietUsshCdgtvtProvider;}
		}
		
		#endregion
		
		
		#region "ViewLietKeKhoiLuongGiangDayChiTiet2Provider"
		
		private SqlViewLietKeKhoiLuongGiangDayChiTiet2Provider innerSqlViewLietKeKhoiLuongGiangDayChiTiet2Provider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLietKeKhoiLuongGiangDayChiTiet2"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLietKeKhoiLuongGiangDayChiTiet2ProviderBase ViewLietKeKhoiLuongGiangDayChiTiet2Provider
		{
			get
			{
				if (innerSqlViewLietKeKhoiLuongGiangDayChiTiet2Provider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLietKeKhoiLuongGiangDayChiTiet2Provider == null)
						{
							this.innerSqlViewLietKeKhoiLuongGiangDayChiTiet2Provider = new SqlViewLietKeKhoiLuongGiangDayChiTiet2Provider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLietKeKhoiLuongGiangDayChiTiet2Provider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLietKeKhoiLuongGiangDayChiTiet2Provider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLietKeKhoiLuongGiangDayChiTiet2Provider SqlViewLietKeKhoiLuongGiangDayChiTiet2Provider
		{
			get {return ViewLietKeKhoiLuongGiangDayChiTiet2Provider as SqlViewLietKeKhoiLuongGiangDayChiTiet2Provider;}
		}
		
		#endregion
		
		
		#region "ViewLoaiHinhDaoTaoProvider"
		
		private SqlViewLoaiHinhDaoTaoProvider innerSqlViewLoaiHinhDaoTaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLoaiHinhDaoTao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLoaiHinhDaoTaoProviderBase ViewLoaiHinhDaoTaoProvider
		{
			get
			{
				if (innerSqlViewLoaiHinhDaoTaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLoaiHinhDaoTaoProvider == null)
						{
							this.innerSqlViewLoaiHinhDaoTaoProvider = new SqlViewLoaiHinhDaoTaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLoaiHinhDaoTaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLoaiHinhDaoTaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLoaiHinhDaoTaoProvider SqlViewLoaiHinhDaoTaoProvider
		{
			get {return ViewLoaiHinhDaoTaoProvider as SqlViewLoaiHinhDaoTaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewLoaiHocPhanProvider"
		
		private SqlViewLoaiHocPhanProvider innerSqlViewLoaiHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLoaiHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLoaiHocPhanProviderBase ViewLoaiHocPhanProvider
		{
			get
			{
				if (innerSqlViewLoaiHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLoaiHocPhanProvider == null)
						{
							this.innerSqlViewLoaiHocPhanProvider = new SqlViewLoaiHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLoaiHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLoaiHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLoaiHocPhanProvider SqlViewLoaiHocPhanProvider
		{
			get {return ViewLoaiHocPhanProvider as SqlViewLoaiHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "ViewLopProvider"
		
		private SqlViewLopProvider innerSqlViewLopProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLop"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLopProviderBase ViewLopProvider
		{
			get
			{
				if (innerSqlViewLopProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLopProvider == null)
						{
							this.innerSqlViewLopProvider = new SqlViewLopProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLopProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLopProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLopProvider SqlViewLopProvider
		{
			get {return ViewLopProvider as SqlViewLopProvider;}
		}
		
		#endregion
		
		
		#region "ViewLopChatLuongCaoProvider"
		
		private SqlViewLopChatLuongCaoProvider innerSqlViewLopChatLuongCaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLopChatLuongCao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLopChatLuongCaoProviderBase ViewLopChatLuongCaoProvider
		{
			get
			{
				if (innerSqlViewLopChatLuongCaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLopChatLuongCaoProvider == null)
						{
							this.innerSqlViewLopChatLuongCaoProvider = new SqlViewLopChatLuongCaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLopChatLuongCaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLopChatLuongCaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLopChatLuongCaoProvider SqlViewLopChatLuongCaoProvider
		{
			get {return ViewLopChatLuongCaoProvider as SqlViewLopChatLuongCaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewLopHocPhanProvider"
		
		private SqlViewLopHocPhanProvider innerSqlViewLopHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLopHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLopHocPhanProviderBase ViewLopHocPhanProvider
		{
			get
			{
				if (innerSqlViewLopHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLopHocPhanProvider == null)
						{
							this.innerSqlViewLopHocPhanProvider = new SqlViewLopHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLopHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLopHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLopHocPhanProvider SqlViewLopHocPhanProvider
		{
			get {return ViewLopHocPhanProvider as SqlViewLopHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "ViewLopHocPhanClcAufCjlProvider"
		
		private SqlViewLopHocPhanClcAufCjlProvider innerSqlViewLopHocPhanClcAufCjlProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLopHocPhanClcAufCjl"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLopHocPhanClcAufCjlProviderBase ViewLopHocPhanClcAufCjlProvider
		{
			get
			{
				if (innerSqlViewLopHocPhanClcAufCjlProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLopHocPhanClcAufCjlProvider == null)
						{
							this.innerSqlViewLopHocPhanClcAufCjlProvider = new SqlViewLopHocPhanClcAufCjlProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLopHocPhanClcAufCjlProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLopHocPhanClcAufCjlProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLopHocPhanClcAufCjlProvider SqlViewLopHocPhanClcAufCjlProvider
		{
			get {return ViewLopHocPhanClcAufCjlProvider as SqlViewLopHocPhanClcAufCjlProvider;}
		}
		
		#endregion
		
		
		#region "ViewLopHocPhanChuyenNganhProvider"
		
		private SqlViewLopHocPhanChuyenNganhProvider innerSqlViewLopHocPhanChuyenNganhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLopHocPhanChuyenNganh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLopHocPhanChuyenNganhProviderBase ViewLopHocPhanChuyenNganhProvider
		{
			get
			{
				if (innerSqlViewLopHocPhanChuyenNganhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLopHocPhanChuyenNganhProvider == null)
						{
							this.innerSqlViewLopHocPhanChuyenNganhProvider = new SqlViewLopHocPhanChuyenNganhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLopHocPhanChuyenNganhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLopHocPhanChuyenNganhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLopHocPhanChuyenNganhProvider SqlViewLopHocPhanChuyenNganhProvider
		{
			get {return ViewLopHocPhanChuyenNganhProvider as SqlViewLopHocPhanChuyenNganhProvider;}
		}
		
		#endregion
		
		
		#region "ViewLopHocPhanGiangBangTiengNuocNgoaiProvider"
		
		private SqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLopHocPhanGiangBangTiengNuocNgoai"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLopHocPhanGiangBangTiengNuocNgoaiProviderBase ViewLopHocPhanGiangBangTiengNuocNgoaiProvider
		{
			get
			{
				if (innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider == null)
						{
							this.innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider = new SqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider SqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider
		{
			get {return ViewLopHocPhanGiangBangTiengNuocNgoaiProvider as SqlViewLopHocPhanGiangBangTiengNuocNgoaiProvider;}
		}
		
		#endregion
		
		
		#region "ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider"
		
		private SqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewLopHocPhanGiangBangTiengNuocNgoaiBuh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProviderBase ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider
		{
			get
			{
				if (innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider == null)
						{
							this.innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider = new SqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider SqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider
		{
			get {return ViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider as SqlViewLopHocPhanGiangBangTiengNuocNgoaiBuhProvider;}
		}
		
		#endregion
		
		
		#region "ViewMonGiangMoiProvider"
		
		private SqlViewMonGiangMoiProvider innerSqlViewMonGiangMoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewMonGiangMoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewMonGiangMoiProviderBase ViewMonGiangMoiProvider
		{
			get
			{
				if (innerSqlViewMonGiangMoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewMonGiangMoiProvider == null)
						{
							this.innerSqlViewMonGiangMoiProvider = new SqlViewMonGiangMoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewMonGiangMoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewMonGiangMoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewMonGiangMoiProvider SqlViewMonGiangMoiProvider
		{
			get {return ViewMonGiangMoiProvider as SqlViewMonGiangMoiProvider;}
		}
		
		#endregion
		
		
		#region "ViewMonHocProvider"
		
		private SqlViewMonHocProvider innerSqlViewMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewMonHocProviderBase ViewMonHocProvider
		{
			get
			{
				if (innerSqlViewMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewMonHocProvider == null)
						{
							this.innerSqlViewMonHocProvider = new SqlViewMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewMonHocProvider SqlViewMonHocProvider
		{
			get {return ViewMonHocProvider as SqlViewMonHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewMonHocKhoaProvider"
		
		private SqlViewMonHocKhoaProvider innerSqlViewMonHocKhoaProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewMonHocKhoa"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewMonHocKhoaProviderBase ViewMonHocKhoaProvider
		{
			get
			{
				if (innerSqlViewMonHocKhoaProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewMonHocKhoaProvider == null)
						{
							this.innerSqlViewMonHocKhoaProvider = new SqlViewMonHocKhoaProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewMonHocKhoaProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewMonHocKhoaProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewMonHocKhoaProvider SqlViewMonHocKhoaProvider
		{
			get {return ViewMonHocKhoaProvider as SqlViewMonHocKhoaProvider;}
		}
		
		#endregion
		
		
		#region "ViewMonThucTapTotNghiepProvider"
		
		private SqlViewMonThucTapTotNghiepProvider innerSqlViewMonThucTapTotNghiepProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewMonThucTapTotNghiep"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewMonThucTapTotNghiepProviderBase ViewMonThucTapTotNghiepProvider
		{
			get
			{
				if (innerSqlViewMonThucTapTotNghiepProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewMonThucTapTotNghiepProvider == null)
						{
							this.innerSqlViewMonThucTapTotNghiepProvider = new SqlViewMonThucTapTotNghiepProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewMonThucTapTotNghiepProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewMonThucTapTotNghiepProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewMonThucTapTotNghiepProvider SqlViewMonThucTapTotNghiepProvider
		{
			get {return ViewMonThucTapTotNghiepProvider as SqlViewMonThucTapTotNghiepProvider;}
		}
		
		#endregion
		
		
		#region "ViewMonTinhTheoQuyCheMoiProvider"
		
		private SqlViewMonTinhTheoQuyCheMoiProvider innerSqlViewMonTinhTheoQuyCheMoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewMonTinhTheoQuyCheMoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewMonTinhTheoQuyCheMoiProviderBase ViewMonTinhTheoQuyCheMoiProvider
		{
			get
			{
				if (innerSqlViewMonTinhTheoQuyCheMoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewMonTinhTheoQuyCheMoiProvider == null)
						{
							this.innerSqlViewMonTinhTheoQuyCheMoiProvider = new SqlViewMonTinhTheoQuyCheMoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewMonTinhTheoQuyCheMoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewMonTinhTheoQuyCheMoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewMonTinhTheoQuyCheMoiProvider SqlViewMonTinhTheoQuyCheMoiProvider
		{
			get {return ViewMonTinhTheoQuyCheMoiProvider as SqlViewMonTinhTheoQuyCheMoiProvider;}
		}
		
		#endregion
		
		
		#region "ViewMonXepLichChuNhatKhongTinhHeSoProvider"
		
		private SqlViewMonXepLichChuNhatKhongTinhHeSoProvider innerSqlViewMonXepLichChuNhatKhongTinhHeSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewMonXepLichChuNhatKhongTinhHeSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewMonXepLichChuNhatKhongTinhHeSoProviderBase ViewMonXepLichChuNhatKhongTinhHeSoProvider
		{
			get
			{
				if (innerSqlViewMonXepLichChuNhatKhongTinhHeSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewMonXepLichChuNhatKhongTinhHeSoProvider == null)
						{
							this.innerSqlViewMonXepLichChuNhatKhongTinhHeSoProvider = new SqlViewMonXepLichChuNhatKhongTinhHeSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewMonXepLichChuNhatKhongTinhHeSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewMonXepLichChuNhatKhongTinhHeSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewMonXepLichChuNhatKhongTinhHeSoProvider SqlViewMonXepLichChuNhatKhongTinhHeSoProvider
		{
			get {return ViewMonXepLichChuNhatKhongTinhHeSoProvider as SqlViewMonXepLichChuNhatKhongTinhHeSoProvider;}
		}
		
		#endregion
		
		
		#region "ViewNamHocProvider"
		
		private SqlViewNamHocProvider innerSqlViewNamHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewNamHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewNamHocProviderBase ViewNamHocProvider
		{
			get
			{
				if (innerSqlViewNamHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewNamHocProvider == null)
						{
							this.innerSqlViewNamHocProvider = new SqlViewNamHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewNamHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewNamHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewNamHocProvider SqlViewNamHocProvider
		{
			get {return ViewNamHocProvider as SqlViewNamHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewNgachLuongHrmProvider"
		
		private SqlViewNgachLuongHrmProvider innerSqlViewNgachLuongHrmProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewNgachLuongHrm"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewNgachLuongHrmProviderBase ViewNgachLuongHrmProvider
		{
			get
			{
				if (innerSqlViewNgachLuongHrmProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewNgachLuongHrmProvider == null)
						{
							this.innerSqlViewNgachLuongHrmProvider = new SqlViewNgachLuongHrmProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewNgachLuongHrmProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewNgachLuongHrmProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewNgachLuongHrmProvider SqlViewNgachLuongHrmProvider
		{
			get {return ViewNgachLuongHrmProvider as SqlViewNgachLuongHrmProvider;}
		}
		
		#endregion
		
		
		#region "ViewNgayTrongTuanProvider"
		
		private SqlViewNgayTrongTuanProvider innerSqlViewNgayTrongTuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewNgayTrongTuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewNgayTrongTuanProviderBase ViewNgayTrongTuanProvider
		{
			get
			{
				if (innerSqlViewNgayTrongTuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewNgayTrongTuanProvider == null)
						{
							this.innerSqlViewNgayTrongTuanProvider = new SqlViewNgayTrongTuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewNgayTrongTuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewNgayTrongTuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewNgayTrongTuanProvider SqlViewNgayTrongTuanProvider
		{
			get {return ViewNgayTrongTuanProvider as SqlViewNgayTrongTuanProvider;}
		}
		
		#endregion
		
		
		#region "ViewNhomMonHocProvider"
		
		private SqlViewNhomMonHocProvider innerSqlViewNhomMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewNhomMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewNhomMonHocProviderBase ViewNhomMonHocProvider
		{
			get
			{
				if (innerSqlViewNhomMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewNhomMonHocProvider == null)
						{
							this.innerSqlViewNhomMonHocProvider = new SqlViewNhomMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewNhomMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewNhomMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewNhomMonHocProvider SqlViewNhomMonHocProvider
		{
			get {return ViewNhomMonHocProvider as SqlViewNhomMonHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewPhanCongChuyenMonProvider"
		
		private SqlViewPhanCongChuyenMonProvider innerSqlViewPhanCongChuyenMonProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewPhanCongChuyenMon"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewPhanCongChuyenMonProviderBase ViewPhanCongChuyenMonProvider
		{
			get
			{
				if (innerSqlViewPhanCongChuyenMonProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewPhanCongChuyenMonProvider == null)
						{
							this.innerSqlViewPhanCongChuyenMonProvider = new SqlViewPhanCongChuyenMonProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewPhanCongChuyenMonProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewPhanCongChuyenMonProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewPhanCongChuyenMonProvider SqlViewPhanCongChuyenMonProvider
		{
			get {return ViewPhanCongChuyenMonProvider as SqlViewPhanCongChuyenMonProvider;}
		}
		
		#endregion
		
		
		#region "ViewPhanCongCoVanProvider"
		
		private SqlViewPhanCongCoVanProvider innerSqlViewPhanCongCoVanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewPhanCongCoVan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewPhanCongCoVanProviderBase ViewPhanCongCoVanProvider
		{
			get
			{
				if (innerSqlViewPhanCongCoVanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewPhanCongCoVanProvider == null)
						{
							this.innerSqlViewPhanCongCoVanProvider = new SqlViewPhanCongCoVanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewPhanCongCoVanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewPhanCongCoVanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewPhanCongCoVanProvider SqlViewPhanCongCoVanProvider
		{
			get {return ViewPhanCongCoVanProvider as SqlViewPhanCongCoVanProvider;}
		}
		
		#endregion
		
		
		#region "ViewPhanCongGiangDayProvider"
		
		private SqlViewPhanCongGiangDayProvider innerSqlViewPhanCongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewPhanCongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewPhanCongGiangDayProviderBase ViewPhanCongGiangDayProvider
		{
			get
			{
				if (innerSqlViewPhanCongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewPhanCongGiangDayProvider == null)
						{
							this.innerSqlViewPhanCongGiangDayProvider = new SqlViewPhanCongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewPhanCongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewPhanCongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewPhanCongGiangDayProvider SqlViewPhanCongGiangDayProvider
		{
			get {return ViewPhanCongGiangDayProvider as SqlViewPhanCongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewPhanLoaiGiangVienProvider"
		
		private SqlViewPhanLoaiGiangVienProvider innerSqlViewPhanLoaiGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewPhanLoaiGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewPhanLoaiGiangVienProviderBase ViewPhanLoaiGiangVienProvider
		{
			get
			{
				if (innerSqlViewPhanLoaiGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewPhanLoaiGiangVienProvider == null)
						{
							this.innerSqlViewPhanLoaiGiangVienProvider = new SqlViewPhanLoaiGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewPhanLoaiGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewPhanLoaiGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewPhanLoaiGiangVienProvider SqlViewPhanLoaiGiangVienProvider
		{
			get {return ViewPhanLoaiGiangVienProvider as SqlViewPhanLoaiGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ViewPhanNhomMonHocProvider"
		
		private SqlViewPhanNhomMonHocProvider innerSqlViewPhanNhomMonHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewPhanNhomMonHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewPhanNhomMonHocProviderBase ViewPhanNhomMonHocProvider
		{
			get
			{
				if (innerSqlViewPhanNhomMonHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewPhanNhomMonHocProvider == null)
						{
							this.innerSqlViewPhanNhomMonHocProvider = new SqlViewPhanNhomMonHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewPhanNhomMonHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewPhanNhomMonHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewPhanNhomMonHocProvider SqlViewPhanNhomMonHocProvider
		{
			get {return ViewPhanNhomMonHocProvider as SqlViewPhanNhomMonHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewPhanNhomMonHocActProvider"
		
		private SqlViewPhanNhomMonHocActProvider innerSqlViewPhanNhomMonHocActProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewPhanNhomMonHocAct"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewPhanNhomMonHocActProviderBase ViewPhanNhomMonHocActProvider
		{
			get
			{
				if (innerSqlViewPhanNhomMonHocActProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewPhanNhomMonHocActProvider == null)
						{
							this.innerSqlViewPhanNhomMonHocActProvider = new SqlViewPhanNhomMonHocActProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewPhanNhomMonHocActProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewPhanNhomMonHocActProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewPhanNhomMonHocActProvider SqlViewPhanNhomMonHocActProvider
		{
			get {return ViewPhanNhomMonHocActProvider as SqlViewPhanNhomMonHocActProvider;}
		}
		
		#endregion
		
		
		#region "ViewPhuCapHanhChinhProvider"
		
		private SqlViewPhuCapHanhChinhProvider innerSqlViewPhuCapHanhChinhProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewPhuCapHanhChinh"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewPhuCapHanhChinhProviderBase ViewPhuCapHanhChinhProvider
		{
			get
			{
				if (innerSqlViewPhuCapHanhChinhProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewPhuCapHanhChinhProvider == null)
						{
							this.innerSqlViewPhuCapHanhChinhProvider = new SqlViewPhuCapHanhChinhProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewPhuCapHanhChinhProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewPhuCapHanhChinhProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewPhuCapHanhChinhProvider SqlViewPhuCapHanhChinhProvider
		{
			get {return ViewPhuCapHanhChinhProvider as SqlViewPhuCapHanhChinhProvider;}
		}
		
		#endregion
		
		
		#region "ViewQuyDoiHoatDongNgoaiGiangDayProvider"
		
		private SqlViewQuyDoiHoatDongNgoaiGiangDayProvider innerSqlViewQuyDoiHoatDongNgoaiGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewQuyDoiHoatDongNgoaiGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewQuyDoiHoatDongNgoaiGiangDayProviderBase ViewQuyDoiHoatDongNgoaiGiangDayProvider
		{
			get
			{
				if (innerSqlViewQuyDoiHoatDongNgoaiGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewQuyDoiHoatDongNgoaiGiangDayProvider == null)
						{
							this.innerSqlViewQuyDoiHoatDongNgoaiGiangDayProvider = new SqlViewQuyDoiHoatDongNgoaiGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewQuyDoiHoatDongNgoaiGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewQuyDoiHoatDongNgoaiGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewQuyDoiHoatDongNgoaiGiangDayProvider SqlViewQuyDoiHoatDongNgoaiGiangDayProvider
		{
			get {return ViewQuyDoiHoatDongNgoaiGiangDayProvider as SqlViewQuyDoiHoatDongNgoaiGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewQuyetDinhDoiHocHamHocViProvider"
		
		private SqlViewQuyetDinhDoiHocHamHocViProvider innerSqlViewQuyetDinhDoiHocHamHocViProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewQuyetDinhDoiHocHamHocVi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewQuyetDinhDoiHocHamHocViProviderBase ViewQuyetDinhDoiHocHamHocViProvider
		{
			get
			{
				if (innerSqlViewQuyetDinhDoiHocHamHocViProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewQuyetDinhDoiHocHamHocViProvider == null)
						{
							this.innerSqlViewQuyetDinhDoiHocHamHocViProvider = new SqlViewQuyetDinhDoiHocHamHocViProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewQuyetDinhDoiHocHamHocViProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewQuyetDinhDoiHocHamHocViProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewQuyetDinhDoiHocHamHocViProvider SqlViewQuyetDinhDoiHocHamHocViProvider
		{
			get {return ViewQuyetDinhDoiHocHamHocViProvider as SqlViewQuyetDinhDoiHocHamHocViProvider;}
		}
		
		#endregion
		
		
		#region "ViewSdhLietKeKhoiLuongGiangDayChiTietProvider"
		
		private SqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider innerSqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewSdhLietKeKhoiLuongGiangDayChiTiet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewSdhLietKeKhoiLuongGiangDayChiTietProviderBase ViewSdhLietKeKhoiLuongGiangDayChiTietProvider
		{
			get
			{
				if (innerSqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider == null)
						{
							this.innerSqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider = new SqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider SqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider
		{
			get {return ViewSdhLietKeKhoiLuongGiangDayChiTietProvider as SqlViewSdhLietKeKhoiLuongGiangDayChiTietProvider;}
		}
		
		#endregion
		
		
		#region "ViewSdhUteKhoiLuongQuyDoiProvider"
		
		private SqlViewSdhUteKhoiLuongQuyDoiProvider innerSqlViewSdhUteKhoiLuongQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewSdhUteKhoiLuongQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewSdhUteKhoiLuongQuyDoiProviderBase ViewSdhUteKhoiLuongQuyDoiProvider
		{
			get
			{
				if (innerSqlViewSdhUteKhoiLuongQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewSdhUteKhoiLuongQuyDoiProvider == null)
						{
							this.innerSqlViewSdhUteKhoiLuongQuyDoiProvider = new SqlViewSdhUteKhoiLuongQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewSdhUteKhoiLuongQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewSdhUteKhoiLuongQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewSdhUteKhoiLuongQuyDoiProvider SqlViewSdhUteKhoiLuongQuyDoiProvider
		{
			get {return ViewSdhUteKhoiLuongQuyDoiProvider as SqlViewSdhUteKhoiLuongQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "ViewSinhVienHocPhanProvider"
		
		private SqlViewSinhVienHocPhanProvider innerSqlViewSinhVienHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewSinhVienHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewSinhVienHocPhanProviderBase ViewSinhVienHocPhanProvider
		{
			get
			{
				if (innerSqlViewSinhVienHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewSinhVienHocPhanProvider == null)
						{
							this.innerSqlViewSinhVienHocPhanProvider = new SqlViewSinhVienHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewSinhVienHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewSinhVienHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewSinhVienHocPhanProvider SqlViewSinhVienHocPhanProvider
		{
			get {return ViewSinhVienHocPhanProvider as SqlViewSinhVienHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "ViewSinhVienLopProvider"
		
		private SqlViewSinhVienLopProvider innerSqlViewSinhVienLopProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewSinhVienLop"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewSinhVienLopProviderBase ViewSinhVienLopProvider
		{
			get
			{
				if (innerSqlViewSinhVienLopProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewSinhVienLopProvider == null)
						{
							this.innerSqlViewSinhVienLopProvider = new SqlViewSinhVienLopProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewSinhVienLopProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewSinhVienLopProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewSinhVienLopProvider SqlViewSinhVienLopProvider
		{
			get {return ViewSinhVienLopProvider as SqlViewSinhVienLopProvider;}
		}
		
		#endregion
		
		
		#region "ViewSinhVienLopHocPhanProvider"
		
		private SqlViewSinhVienLopHocPhanProvider innerSqlViewSinhVienLopHocPhanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewSinhVienLopHocPhan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewSinhVienLopHocPhanProviderBase ViewSinhVienLopHocPhanProvider
		{
			get
			{
				if (innerSqlViewSinhVienLopHocPhanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewSinhVienLopHocPhanProvider == null)
						{
							this.innerSqlViewSinhVienLopHocPhanProvider = new SqlViewSinhVienLopHocPhanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewSinhVienLopHocPhanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewSinhVienLopHocPhanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewSinhVienLopHocPhanProvider SqlViewSinhVienLopHocPhanProvider
		{
			get {return ViewSinhVienLopHocPhanProvider as SqlViewSinhVienLopHocPhanProvider;}
		}
		
		#endregion
		
		
		#region "ViewSinhVienLopHocPhanSgProvider"
		
		private SqlViewSinhVienLopHocPhanSgProvider innerSqlViewSinhVienLopHocPhanSgProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewSinhVienLopHocPhanSg"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewSinhVienLopHocPhanSgProviderBase ViewSinhVienLopHocPhanSgProvider
		{
			get
			{
				if (innerSqlViewSinhVienLopHocPhanSgProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewSinhVienLopHocPhanSgProvider == null)
						{
							this.innerSqlViewSinhVienLopHocPhanSgProvider = new SqlViewSinhVienLopHocPhanSgProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewSinhVienLopHocPhanSgProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewSinhVienLopHocPhanSgProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewSinhVienLopHocPhanSgProvider SqlViewSinhVienLopHocPhanSgProvider
		{
			get {return ViewSinhVienLopHocPhanSgProvider as SqlViewSinhVienLopHocPhanSgProvider;}
		}
		
		#endregion
		
		
		#region "ViewSoTietCoiThiTieuChuanCuaGiangVienProvider"
		
		private SqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider innerSqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewSoTietCoiThiTieuChuanCuaGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewSoTietCoiThiTieuChuanCuaGiangVienProviderBase ViewSoTietCoiThiTieuChuanCuaGiangVienProvider
		{
			get
			{
				if (innerSqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider == null)
						{
							this.innerSqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider = new SqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider SqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider
		{
			get {return ViewSoTietCoiThiTieuChuanCuaGiangVienProvider as SqlViewSoTietCoiThiTieuChuanCuaGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ViewThamDinhLuanVanThacSyProvider"
		
		private SqlViewThamDinhLuanVanThacSyProvider innerSqlViewThamDinhLuanVanThacSyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThamDinhLuanVanThacSy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThamDinhLuanVanThacSyProviderBase ViewThamDinhLuanVanThacSyProvider
		{
			get
			{
				if (innerSqlViewThamDinhLuanVanThacSyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThamDinhLuanVanThacSyProvider == null)
						{
							this.innerSqlViewThamDinhLuanVanThacSyProvider = new SqlViewThamDinhLuanVanThacSyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThamDinhLuanVanThacSyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThamDinhLuanVanThacSyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThamDinhLuanVanThacSyProvider SqlViewThamDinhLuanVanThacSyProvider
		{
			get {return ViewThamDinhLuanVanThacSyProvider as SqlViewThamDinhLuanVanThacSyProvider;}
		}
		
		#endregion
		
		
		#region "ViewThanhToanGioDayProvider"
		
		private SqlViewThanhToanGioDayProvider innerSqlViewThanhToanGioDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThanhToanGioDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThanhToanGioDayProviderBase ViewThanhToanGioDayProvider
		{
			get
			{
				if (innerSqlViewThanhToanGioDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThanhToanGioDayProvider == null)
						{
							this.innerSqlViewThanhToanGioDayProvider = new SqlViewThanhToanGioDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThanhToanGioDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThanhToanGioDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThanhToanGioDayProvider SqlViewThanhToanGioDayProvider
		{
			get {return ViewThanhToanGioDayProvider as SqlViewThanhToanGioDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewThanhToanThuLaoProvider"
		
		private SqlViewThanhToanThuLaoProvider innerSqlViewThanhToanThuLaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThanhToanThuLao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThanhToanThuLaoProviderBase ViewThanhToanThuLaoProvider
		{
			get
			{
				if (innerSqlViewThanhToanThuLaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThanhToanThuLaoProvider == null)
						{
							this.innerSqlViewThanhToanThuLaoProvider = new SqlViewThanhToanThuLaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThanhToanThuLaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThanhToanThuLaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThanhToanThuLaoProvider SqlViewThanhToanThuLaoProvider
		{
			get {return ViewThanhToanThuLaoProvider as SqlViewThanhToanThuLaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewThanhToanTienGiangProvider"
		
		private SqlViewThanhToanTienGiangProvider innerSqlViewThanhToanTienGiangProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThanhToanTienGiang"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThanhToanTienGiangProviderBase ViewThanhToanTienGiangProvider
		{
			get
			{
				if (innerSqlViewThanhToanTienGiangProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThanhToanTienGiangProvider == null)
						{
							this.innerSqlViewThanhToanTienGiangProvider = new SqlViewThanhToanTienGiangProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThanhToanTienGiangProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThanhToanTienGiangProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThanhToanTienGiangProvider SqlViewThanhToanTienGiangProvider
		{
			get {return ViewThanhToanTienGiangProvider as SqlViewThanhToanTienGiangProvider;}
		}
		
		#endregion
		
		
		#region "ViewThanhTraChamGiangTheoKhoaHocProvider"
		
		private SqlViewThanhTraChamGiangTheoKhoaHocProvider innerSqlViewThanhTraChamGiangTheoKhoaHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThanhTraChamGiangTheoKhoaHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThanhTraChamGiangTheoKhoaHocProviderBase ViewThanhTraChamGiangTheoKhoaHocProvider
		{
			get
			{
				if (innerSqlViewThanhTraChamGiangTheoKhoaHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThanhTraChamGiangTheoKhoaHocProvider == null)
						{
							this.innerSqlViewThanhTraChamGiangTheoKhoaHocProvider = new SqlViewThanhTraChamGiangTheoKhoaHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThanhTraChamGiangTheoKhoaHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThanhTraChamGiangTheoKhoaHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThanhTraChamGiangTheoKhoaHocProvider SqlViewThanhTraChamGiangTheoKhoaHocProvider
		{
			get {return ViewThanhTraChamGiangTheoKhoaHocProvider as SqlViewThanhTraChamGiangTheoKhoaHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewThanhTraCoiThiProvider"
		
		private SqlViewThanhTraCoiThiProvider innerSqlViewThanhTraCoiThiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThanhTraCoiThi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThanhTraCoiThiProviderBase ViewThanhTraCoiThiProvider
		{
			get
			{
				if (innerSqlViewThanhTraCoiThiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThanhTraCoiThiProvider == null)
						{
							this.innerSqlViewThanhTraCoiThiProvider = new SqlViewThanhTraCoiThiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThanhTraCoiThiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThanhTraCoiThiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThanhTraCoiThiProvider SqlViewThanhTraCoiThiProvider
		{
			get {return ViewThanhTraCoiThiProvider as SqlViewThanhTraCoiThiProvider;}
		}
		
		#endregion
		
		
		#region "ViewThanhTraGiangDayProvider"
		
		private SqlViewThanhTraGiangDayProvider innerSqlViewThanhTraGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThanhTraGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThanhTraGiangDayProviderBase ViewThanhTraGiangDayProvider
		{
			get
			{
				if (innerSqlViewThanhTraGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThanhTraGiangDayProvider == null)
						{
							this.innerSqlViewThanhTraGiangDayProvider = new SqlViewThanhTraGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThanhTraGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThanhTraGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThanhTraGiangDayProvider SqlViewThanhTraGiangDayProvider
		{
			get {return ViewThanhTraGiangDayProvider as SqlViewThanhTraGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewThanhTraTheoThoiKhoaBieuProvider"
		
		private SqlViewThanhTraTheoThoiKhoaBieuProvider innerSqlViewThanhTraTheoThoiKhoaBieuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThanhTraTheoThoiKhoaBieu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThanhTraTheoThoiKhoaBieuProviderBase ViewThanhTraTheoThoiKhoaBieuProvider
		{
			get
			{
				if (innerSqlViewThanhTraTheoThoiKhoaBieuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThanhTraTheoThoiKhoaBieuProvider == null)
						{
							this.innerSqlViewThanhTraTheoThoiKhoaBieuProvider = new SqlViewThanhTraTheoThoiKhoaBieuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThanhTraTheoThoiKhoaBieuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThanhTraTheoThoiKhoaBieuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThanhTraTheoThoiKhoaBieuProvider SqlViewThanhTraTheoThoiKhoaBieuProvider
		{
			get {return ViewThanhTraTheoThoiKhoaBieuProvider as SqlViewThanhTraTheoThoiKhoaBieuProvider;}
		}
		
		#endregion
		
		
		#region "ViewTheoDoiGiangDayProvider"
		
		private SqlViewTheoDoiGiangDayProvider innerSqlViewTheoDoiGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTheoDoiGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTheoDoiGiangDayProviderBase ViewTheoDoiGiangDayProvider
		{
			get
			{
				if (innerSqlViewTheoDoiGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTheoDoiGiangDayProvider == null)
						{
							this.innerSqlViewTheoDoiGiangDayProvider = new SqlViewTheoDoiGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTheoDoiGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTheoDoiGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTheoDoiGiangDayProvider SqlViewTheoDoiGiangDayProvider
		{
			get {return ViewTheoDoiGiangDayProvider as SqlViewTheoDoiGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewThoiGianLamViecCuaNhanVienProvider"
		
		private SqlViewThoiGianLamViecCuaNhanVienProvider innerSqlViewThoiGianLamViecCuaNhanVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThoiGianLamViecCuaNhanVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThoiGianLamViecCuaNhanVienProviderBase ViewThoiGianLamViecCuaNhanVienProvider
		{
			get
			{
				if (innerSqlViewThoiGianLamViecCuaNhanVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThoiGianLamViecCuaNhanVienProvider == null)
						{
							this.innerSqlViewThoiGianLamViecCuaNhanVienProvider = new SqlViewThoiGianLamViecCuaNhanVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThoiGianLamViecCuaNhanVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThoiGianLamViecCuaNhanVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThoiGianLamViecCuaNhanVienProvider SqlViewThoiGianLamViecCuaNhanVienProvider
		{
			get {return ViewThoiGianLamViecCuaNhanVienProvider as SqlViewThoiGianLamViecCuaNhanVienProvider;}
		}
		
		#endregion
		
		
		#region "ViewThoiGianNghiTamThoiCuaGiangVienProvider"
		
		private SqlViewThoiGianNghiTamThoiCuaGiangVienProvider innerSqlViewThoiGianNghiTamThoiCuaGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThoiGianNghiTamThoiCuaGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThoiGianNghiTamThoiCuaGiangVienProviderBase ViewThoiGianNghiTamThoiCuaGiangVienProvider
		{
			get
			{
				if (innerSqlViewThoiGianNghiTamThoiCuaGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThoiGianNghiTamThoiCuaGiangVienProvider == null)
						{
							this.innerSqlViewThoiGianNghiTamThoiCuaGiangVienProvider = new SqlViewThoiGianNghiTamThoiCuaGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThoiGianNghiTamThoiCuaGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThoiGianNghiTamThoiCuaGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThoiGianNghiTamThoiCuaGiangVienProvider SqlViewThoiGianNghiTamThoiCuaGiangVienProvider
		{
			get {return ViewThoiGianNghiTamThoiCuaGiangVienProvider as SqlViewThoiGianNghiTamThoiCuaGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ViewThoiKhoaBieuProvider"
		
		private SqlViewThoiKhoaBieuProvider innerSqlViewThoiKhoaBieuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThoiKhoaBieu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThoiKhoaBieuProviderBase ViewThoiKhoaBieuProvider
		{
			get
			{
				if (innerSqlViewThoiKhoaBieuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThoiKhoaBieuProvider == null)
						{
							this.innerSqlViewThoiKhoaBieuProvider = new SqlViewThoiKhoaBieuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThoiKhoaBieuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThoiKhoaBieuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThoiKhoaBieuProvider SqlViewThoiKhoaBieuProvider
		{
			get {return ViewThoiKhoaBieuProvider as SqlViewThoiKhoaBieuProvider;}
		}
		
		#endregion
		
		
		#region "ViewThongKeChucVuProvider"
		
		private SqlViewThongKeChucVuProvider innerSqlViewThongKeChucVuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThongKeChucVu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThongKeChucVuProviderBase ViewThongKeChucVuProvider
		{
			get
			{
				if (innerSqlViewThongKeChucVuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThongKeChucVuProvider == null)
						{
							this.innerSqlViewThongKeChucVuProvider = new SqlViewThongKeChucVuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThongKeChucVuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThongKeChucVuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThongKeChucVuProvider SqlViewThongKeChucVuProvider
		{
			get {return ViewThongKeChucVuProvider as SqlViewThongKeChucVuProvider;}
		}
		
		#endregion
		
		
		#region "ViewThongKeHoSoProvider"
		
		private SqlViewThongKeHoSoProvider innerSqlViewThongKeHoSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThongKeHoSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThongKeHoSoProviderBase ViewThongKeHoSoProvider
		{
			get
			{
				if (innerSqlViewThongKeHoSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThongKeHoSoProvider == null)
						{
							this.innerSqlViewThongKeHoSoProvider = new SqlViewThongKeHoSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThongKeHoSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThongKeHoSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThongKeHoSoProvider SqlViewThongKeHoSoProvider
		{
			get {return ViewThongKeHoSoProvider as SqlViewThongKeHoSoProvider;}
		}
		
		#endregion
		
		
		#region "ViewThongKeHoSoChiTietProvider"
		
		private SqlViewThongKeHoSoChiTietProvider innerSqlViewThongKeHoSoChiTietProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThongKeHoSoChiTiet"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThongKeHoSoChiTietProviderBase ViewThongKeHoSoChiTietProvider
		{
			get
			{
				if (innerSqlViewThongKeHoSoChiTietProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThongKeHoSoChiTietProvider == null)
						{
							this.innerSqlViewThongKeHoSoChiTietProvider = new SqlViewThongKeHoSoChiTietProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThongKeHoSoChiTietProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThongKeHoSoChiTietProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThongKeHoSoChiTietProvider SqlViewThongKeHoSoChiTietProvider
		{
			get {return ViewThongKeHoSoChiTietProvider as SqlViewThongKeHoSoChiTietProvider;}
		}
		
		#endregion
		
		
		#region "ViewThongTinChiTietGiangVienProvider"
		
		private SqlViewThongTinChiTietGiangVienProvider innerSqlViewThongTinChiTietGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThongTinChiTietGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThongTinChiTietGiangVienProviderBase ViewThongTinChiTietGiangVienProvider
		{
			get
			{
				if (innerSqlViewThongTinChiTietGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThongTinChiTietGiangVienProvider == null)
						{
							this.innerSqlViewThongTinChiTietGiangVienProvider = new SqlViewThongTinChiTietGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThongTinChiTietGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThongTinChiTietGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThongTinChiTietGiangVienProvider SqlViewThongTinChiTietGiangVienProvider
		{
			get {return ViewThongTinChiTietGiangVienProvider as SqlViewThongTinChiTietGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ViewThongTinChiTietGiangVienChoDuyetHoSoProvider"
		
		private SqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider innerSqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThongTinChiTietGiangVienChoDuyetHoSo"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThongTinChiTietGiangVienChoDuyetHoSoProviderBase ViewThongTinChiTietGiangVienChoDuyetHoSoProvider
		{
			get
			{
				if (innerSqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider == null)
						{
							this.innerSqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider = new SqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider SqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider
		{
			get {return ViewThongTinChiTietGiangVienChoDuyetHoSoProvider as SqlViewThongTinChiTietGiangVienChoDuyetHoSoProvider;}
		}
		
		#endregion
		
		
		#region "ViewThongTinGiangVienProvider"
		
		private SqlViewThongTinGiangVienProvider innerSqlViewThongTinGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThongTinGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThongTinGiangVienProviderBase ViewThongTinGiangVienProvider
		{
			get
			{
				if (innerSqlViewThongTinGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThongTinGiangVienProvider == null)
						{
							this.innerSqlViewThongTinGiangVienProvider = new SqlViewThongTinGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThongTinGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThongTinGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThongTinGiangVienProvider SqlViewThongTinGiangVienProvider
		{
			get {return ViewThongTinGiangVienProvider as SqlViewThongTinGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ViewThongTinLopHocPhanHeSoCongViecProvider"
		
		private SqlViewThongTinLopHocPhanHeSoCongViecProvider innerSqlViewThongTinLopHocPhanHeSoCongViecProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewThongTinLopHocPhanHeSoCongViec"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewThongTinLopHocPhanHeSoCongViecProviderBase ViewThongTinLopHocPhanHeSoCongViecProvider
		{
			get
			{
				if (innerSqlViewThongTinLopHocPhanHeSoCongViecProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewThongTinLopHocPhanHeSoCongViecProvider == null)
						{
							this.innerSqlViewThongTinLopHocPhanHeSoCongViecProvider = new SqlViewThongTinLopHocPhanHeSoCongViecProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewThongTinLopHocPhanHeSoCongViecProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewThongTinLopHocPhanHeSoCongViecProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewThongTinLopHocPhanHeSoCongViecProvider SqlViewThongTinLopHocPhanHeSoCongViecProvider
		{
			get {return ViewThongTinLopHocPhanHeSoCongViecProvider as SqlViewThongTinLopHocPhanHeSoCongViecProvider;}
		}
		
		#endregion
		
		
		#region "ViewTietGiangDayProvider"
		
		private SqlViewTietGiangDayProvider innerSqlViewTietGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTietGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTietGiangDayProviderBase ViewTietGiangDayProvider
		{
			get
			{
				if (innerSqlViewTietGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTietGiangDayProvider == null)
						{
							this.innerSqlViewTietGiangDayProvider = new SqlViewTietGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTietGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTietGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTietGiangDayProvider SqlViewTietGiangDayProvider
		{
			get {return ViewTietGiangDayProvider as SqlViewTietGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewTietNghiaVuProvider"
		
		private SqlViewTietNghiaVuProvider innerSqlViewTietNghiaVuProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTietNghiaVu"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTietNghiaVuProviderBase ViewTietNghiaVuProvider
		{
			get
			{
				if (innerSqlViewTietNghiaVuProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTietNghiaVuProvider == null)
						{
							this.innerSqlViewTietNghiaVuProvider = new SqlViewTietNghiaVuProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTietNghiaVuProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTietNghiaVuProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTietNghiaVuProvider SqlViewTietNghiaVuProvider
		{
			get {return ViewTietNghiaVuProvider as SqlViewTietNghiaVuProvider;}
		}
		
		#endregion
		
		
		#region "ViewTietNghiaVuTheoNamHocHocKyProvider"
		
		private SqlViewTietNghiaVuTheoNamHocHocKyProvider innerSqlViewTietNghiaVuTheoNamHocHocKyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTietNghiaVuTheoNamHocHocKy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTietNghiaVuTheoNamHocHocKyProviderBase ViewTietNghiaVuTheoNamHocHocKyProvider
		{
			get
			{
				if (innerSqlViewTietNghiaVuTheoNamHocHocKyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTietNghiaVuTheoNamHocHocKyProvider == null)
						{
							this.innerSqlViewTietNghiaVuTheoNamHocHocKyProvider = new SqlViewTietNghiaVuTheoNamHocHocKyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTietNghiaVuTheoNamHocHocKyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTietNghiaVuTheoNamHocHocKyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTietNghiaVuTheoNamHocHocKyProvider SqlViewTietNghiaVuTheoNamHocHocKyProvider
		{
			get {return ViewTietNghiaVuTheoNamHocHocKyProvider as SqlViewTietNghiaVuTheoNamHocHocKyProvider;}
		}
		
		#endregion
		
		
		#region "ViewTietNoKyTruocProvider"
		
		private SqlViewTietNoKyTruocProvider innerSqlViewTietNoKyTruocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTietNoKyTruoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTietNoKyTruocProviderBase ViewTietNoKyTruocProvider
		{
			get
			{
				if (innerSqlViewTietNoKyTruocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTietNoKyTruocProvider == null)
						{
							this.innerSqlViewTietNoKyTruocProvider = new SqlViewTietNoKyTruocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTietNoKyTruocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTietNoKyTruocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTietNoKyTruocProvider SqlViewTietNoKyTruocProvider
		{
			get {return ViewTietNoKyTruocProvider as SqlViewTietNoKyTruocProvider;}
		}
		
		#endregion
		
		
		#region "ViewTinhKhoiLuongProvider"
		
		private SqlViewTinhKhoiLuongProvider innerSqlViewTinhKhoiLuongProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTinhKhoiLuong"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTinhKhoiLuongProviderBase ViewTinhKhoiLuongProvider
		{
			get
			{
				if (innerSqlViewTinhKhoiLuongProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTinhKhoiLuongProvider == null)
						{
							this.innerSqlViewTinhKhoiLuongProvider = new SqlViewTinhKhoiLuongProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTinhKhoiLuongProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTinhKhoiLuongProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTinhKhoiLuongProvider SqlViewTinhKhoiLuongProvider
		{
			get {return ViewTinhKhoiLuongProvider as SqlViewTinhKhoiLuongProvider;}
		}
		
		#endregion
		
		
		#region "ViewTinhKhoiLuongTungTuanProvider"
		
		private SqlViewTinhKhoiLuongTungTuanProvider innerSqlViewTinhKhoiLuongTungTuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTinhKhoiLuongTungTuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTinhKhoiLuongTungTuanProviderBase ViewTinhKhoiLuongTungTuanProvider
		{
			get
			{
				if (innerSqlViewTinhKhoiLuongTungTuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTinhKhoiLuongTungTuanProvider == null)
						{
							this.innerSqlViewTinhKhoiLuongTungTuanProvider = new SqlViewTinhKhoiLuongTungTuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTinhKhoiLuongTungTuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTinhKhoiLuongTungTuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTinhKhoiLuongTungTuanProvider SqlViewTinhKhoiLuongTungTuanProvider
		{
			get {return ViewTinhKhoiLuongTungTuanProvider as SqlViewTinhKhoiLuongTungTuanProvider;}
		}
		
		#endregion
		
		
		#region "ViewTongHopChiTienCoVanProvider"
		
		private SqlViewTongHopChiTienCoVanProvider innerSqlViewTongHopChiTienCoVanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTongHopChiTienCoVan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTongHopChiTienCoVanProviderBase ViewTongHopChiTienCoVanProvider
		{
			get
			{
				if (innerSqlViewTongHopChiTienCoVanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTongHopChiTienCoVanProvider == null)
						{
							this.innerSqlViewTongHopChiTienCoVanProvider = new SqlViewTongHopChiTienCoVanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTongHopChiTienCoVanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTongHopChiTienCoVanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTongHopChiTienCoVanProvider SqlViewTongHopChiTienCoVanProvider
		{
			get {return ViewTongHopChiTienCoVanProvider as SqlViewTongHopChiTienCoVanProvider;}
		}
		
		#endregion
		
		
		#region "ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider"
		
		private SqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider innerSqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKy"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProviderBase ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider
		{
			get
			{
				if (innerSqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider == null)
						{
							this.innerSqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider = new SqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider SqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider
		{
			get {return ViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider as SqlViewTonghopGiodayHeDaoTaoLoaiGiangVienNamHocHocKyProvider;}
		}
		
		#endregion
		
		
		#region "ViewTongHopQuyDoiProvider"
		
		private SqlViewTongHopQuyDoiProvider innerSqlViewTongHopQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTongHopQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTongHopQuyDoiProviderBase ViewTongHopQuyDoiProvider
		{
			get
			{
				if (innerSqlViewTongHopQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTongHopQuyDoiProvider == null)
						{
							this.innerSqlViewTongHopQuyDoiProvider = new SqlViewTongHopQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTongHopQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTongHopQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTongHopQuyDoiProvider SqlViewTongHopQuyDoiProvider
		{
			get {return ViewTongHopQuyDoiProvider as SqlViewTongHopQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "ViewTongHopGioDayGiangVienProvider"
		
		private SqlViewTongHopGioDayGiangVienProvider innerSqlViewTongHopGioDayGiangVienProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTongHopGioDayGiangVien"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTongHopGioDayGiangVienProviderBase ViewTongHopGioDayGiangVienProvider
		{
			get
			{
				if (innerSqlViewTongHopGioDayGiangVienProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTongHopGioDayGiangVienProvider == null)
						{
							this.innerSqlViewTongHopGioDayGiangVienProvider = new SqlViewTongHopGioDayGiangVienProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTongHopGioDayGiangVienProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTongHopGioDayGiangVienProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTongHopGioDayGiangVienProvider SqlViewTongHopGioDayGiangVienProvider
		{
			get {return ViewTongHopGioDayGiangVienProvider as SqlViewTongHopGioDayGiangVienProvider;}
		}
		
		#endregion
		
		
		#region "ViewTonGiaoProvider"
		
		private SqlViewTonGiaoProvider innerSqlViewTonGiaoProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewTonGiao"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewTonGiaoProviderBase ViewTonGiaoProvider
		{
			get
			{
				if (innerSqlViewTonGiaoProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewTonGiaoProvider == null)
						{
							this.innerSqlViewTonGiaoProvider = new SqlViewTonGiaoProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewTonGiaoProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewTonGiaoProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewTonGiaoProvider SqlViewTonGiaoProvider
		{
			get {return ViewTonGiaoProvider as SqlViewTonGiaoProvider;}
		}
		
		#endregion
		
		
		#region "ViewUteKhoiLuongGiangDayProvider"
		
		private SqlViewUteKhoiLuongGiangDayProvider innerSqlViewUteKhoiLuongGiangDayProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewUteKhoiLuongGiangDay"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewUteKhoiLuongGiangDayProviderBase ViewUteKhoiLuongGiangDayProvider
		{
			get
			{
				if (innerSqlViewUteKhoiLuongGiangDayProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewUteKhoiLuongGiangDayProvider == null)
						{
							this.innerSqlViewUteKhoiLuongGiangDayProvider = new SqlViewUteKhoiLuongGiangDayProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewUteKhoiLuongGiangDayProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewUteKhoiLuongGiangDayProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewUteKhoiLuongGiangDayProvider SqlViewUteKhoiLuongGiangDayProvider
		{
			get {return ViewUteKhoiLuongGiangDayProvider as SqlViewUteKhoiLuongGiangDayProvider;}
		}
		
		#endregion
		
		
		#region "ViewUteKhoiLuongQuyDoiProvider"
		
		private SqlViewUteKhoiLuongQuyDoiProvider innerSqlViewUteKhoiLuongQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewUteKhoiLuongQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewUteKhoiLuongQuyDoiProviderBase ViewUteKhoiLuongQuyDoiProvider
		{
			get
			{
				if (innerSqlViewUteKhoiLuongQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewUteKhoiLuongQuyDoiProvider == null)
						{
							this.innerSqlViewUteKhoiLuongQuyDoiProvider = new SqlViewUteKhoiLuongQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewUteKhoiLuongQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewUteKhoiLuongQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewUteKhoiLuongQuyDoiProvider SqlViewUteKhoiLuongQuyDoiProvider
		{
			get {return ViewUteKhoiLuongQuyDoiProvider as SqlViewUteKhoiLuongQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "ViewUteKhoiLuongQuyDoi2Provider"
		
		private SqlViewUteKhoiLuongQuyDoi2Provider innerSqlViewUteKhoiLuongQuyDoi2Provider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewUteKhoiLuongQuyDoi2"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewUteKhoiLuongQuyDoi2ProviderBase ViewUteKhoiLuongQuyDoi2Provider
		{
			get
			{
				if (innerSqlViewUteKhoiLuongQuyDoi2Provider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewUteKhoiLuongQuyDoi2Provider == null)
						{
							this.innerSqlViewUteKhoiLuongQuyDoi2Provider = new SqlViewUteKhoiLuongQuyDoi2Provider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewUteKhoiLuongQuyDoi2Provider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewUteKhoiLuongQuyDoi2Provider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewUteKhoiLuongQuyDoi2Provider SqlViewUteKhoiLuongQuyDoi2Provider
		{
			get {return ViewUteKhoiLuongQuyDoi2Provider as SqlViewUteKhoiLuongQuyDoi2Provider;}
		}
		
		#endregion
		
		
		#region "ViewXetDuyetDeCuongLuanVanCaoHocProvider"
		
		private SqlViewXetDuyetDeCuongLuanVanCaoHocProvider innerSqlViewXetDuyetDeCuongLuanVanCaoHocProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewXetDuyetDeCuongLuanVanCaoHoc"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewXetDuyetDeCuongLuanVanCaoHocProviderBase ViewXetDuyetDeCuongLuanVanCaoHocProvider
		{
			get
			{
				if (innerSqlViewXetDuyetDeCuongLuanVanCaoHocProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewXetDuyetDeCuongLuanVanCaoHocProvider == null)
						{
							this.innerSqlViewXetDuyetDeCuongLuanVanCaoHocProvider = new SqlViewXetDuyetDeCuongLuanVanCaoHocProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewXetDuyetDeCuongLuanVanCaoHocProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewXetDuyetDeCuongLuanVanCaoHocProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewXetDuyetDeCuongLuanVanCaoHocProvider SqlViewXetDuyetDeCuongLuanVanCaoHocProvider
		{
			get {return ViewXetDuyetDeCuongLuanVanCaoHocProvider as SqlViewXetDuyetDeCuongLuanVanCaoHocProvider;}
		}
		
		#endregion
		
		
		#region "ViewXuLyQuyDoiProvider"
		
		private SqlViewXuLyQuyDoiProvider innerSqlViewXuLyQuyDoiProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewXuLyQuyDoi"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewXuLyQuyDoiProviderBase ViewXuLyQuyDoiProvider
		{
			get
			{
				if (innerSqlViewXuLyQuyDoiProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewXuLyQuyDoiProvider == null)
						{
							this.innerSqlViewXuLyQuyDoiProvider = new SqlViewXuLyQuyDoiProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewXuLyQuyDoiProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewXuLyQuyDoiProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewXuLyQuyDoiProvider SqlViewXuLyQuyDoiProvider
		{
			get {return ViewXuLyQuyDoiProvider as SqlViewXuLyQuyDoiProvider;}
		}
		
		#endregion
		
		
		#region "ViewXuLyQuyDoiTungTuanProvider"
		
		private SqlViewXuLyQuyDoiTungTuanProvider innerSqlViewXuLyQuyDoiTungTuanProvider;

		///<summary>
		/// This class is the Data Access Logic Component for the <see cref="ViewXuLyQuyDoiTungTuan"/> business entity.
		/// It exposes CRUD methods as well as selecting on index, foreign keys and custom stored procedures.
		///</summary>
		/// <value></value>
		public override ViewXuLyQuyDoiTungTuanProviderBase ViewXuLyQuyDoiTungTuanProvider
		{
			get
			{
				if (innerSqlViewXuLyQuyDoiTungTuanProvider == null) 
				{
					lock (syncRoot) 
					{
						if (innerSqlViewXuLyQuyDoiTungTuanProvider == null)
						{
							this.innerSqlViewXuLyQuyDoiTungTuanProvider = new SqlViewXuLyQuyDoiTungTuanProvider(_connectionString, _useStoredProcedure, _providerInvariantName);
						}
					}
				}
				return innerSqlViewXuLyQuyDoiTungTuanProvider;
			}
		}
		
		/// <summary>
		/// Gets the current <see cref="SqlViewXuLyQuyDoiTungTuanProvider"/>.
		/// </summary>
		/// <value></value>
		public SqlViewXuLyQuyDoiTungTuanProvider SqlViewXuLyQuyDoiTungTuanProvider
		{
			get {return ViewXuLyQuyDoiTungTuanProvider as SqlViewXuLyQuyDoiTungTuanProvider;}
		}
		
		#endregion
		
		
		#region "General data access methods"

		#region "ExecuteNonQuery"
		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteNonQuery(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteNonQuery(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		public override void ExecuteNonQuery(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			database.ExecuteNonQuery(commandWrapper);	
			
		}

		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		public override void ExecuteNonQuery(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			database.ExecuteNonQuery(commandWrapper, transactionManager.TransactionObject);	
		}


		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteNonQuery(commandType, commandText);	
		}
		/// <summary>
		/// Executes the non query.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override int ExecuteNonQuery(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteNonQuery(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#region "ExecuteDataReader"
		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteReader(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			Database database = transactionManager.Database;
			return database.ExecuteReader(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteReader(commandWrapper);	
		}

		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			Database database = transactionManager.Database;
			return database.ExecuteReader(commandWrapper, transactionManager.TransactionObject);	
		}


		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteReader(commandType, commandText);	
		}
		/// <summary>
		/// Executes the reader.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override IDataReader ExecuteReader(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteReader(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#region "ExecuteDataSet"
		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteDataSet(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			Database database = transactionManager.Database;
			return database.ExecuteDataSet(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteDataSet(commandWrapper);	
		}

		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			Database database = transactionManager.Database;
			return database.ExecuteDataSet(commandWrapper, transactionManager.TransactionObject);	
		}


		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteDataSet(commandType, commandText);	
		}
		/// <summary>
		/// Executes the data set.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override DataSet ExecuteDataSet(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteDataSet(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#region "ExecuteScalar"
		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override object ExecuteScalar(string storedProcedureName, params object[] parameterValues)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteScalar(storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="storedProcedureName">Name of the stored procedure.</param>
		/// <param name="parameterValues">The parameter values.</param>
		/// <returns></returns>
		public override object ExecuteScalar(TransactionManager transactionManager, string storedProcedureName, params object[] parameterValues)
		{
			Database database = transactionManager.Database;
			return database.ExecuteScalar(transactionManager.TransactionObject, storedProcedureName, parameterValues);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override object ExecuteScalar(DbCommand commandWrapper)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);			
			return database.ExecuteScalar(commandWrapper);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandWrapper">The command wrapper.</param>
		/// <returns></returns>
		public override object ExecuteScalar(TransactionManager transactionManager, DbCommand commandWrapper)
		{
			Database database = transactionManager.Database;
			return database.ExecuteScalar(commandWrapper, transactionManager.TransactionObject);	
		}

		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override object ExecuteScalar(CommandType commandType, string commandText)
		{
			SqlDatabase database = new SqlDatabase(this._connectionString);
			return database.ExecuteScalar(commandType, commandText);	
		}
		/// <summary>
		/// Executes the scalar.
		/// </summary>
		/// <param name="transactionManager">The transaction manager.</param>
		/// <param name="commandType">Type of the command.</param>
		/// <param name="commandText">The command text.</param>
		/// <returns></returns>
		public override object ExecuteScalar(TransactionManager transactionManager, CommandType commandType, string commandText)
		{
			Database database = transactionManager.Database;			
			return database.ExecuteScalar(transactionManager.TransactionObject , commandType, commandText);				
		}
		#endregion

		#endregion


	}
}
