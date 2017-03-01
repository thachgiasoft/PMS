#region Using Directives
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Web.UI;
using System.Web.UI.Design;

using PMS.Entities;
using PMS.Data;
using PMS.Data.Bases;
using PMS.Services;
#endregion

namespace PMS.Web.Data
{
	/// <summary>
	/// Represents the DataRepository.UteThanhToanThuLaoProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(UteThanhToanThuLaoDataSourceDesigner))]
	public class UteThanhToanThuLaoDataSource : ProviderDataSource<UteThanhToanThuLao, UteThanhToanThuLaoKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteThanhToanThuLaoDataSource class.
		/// </summary>
		public UteThanhToanThuLaoDataSource() : base(new UteThanhToanThuLaoService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the UteThanhToanThuLaoDataSourceView used by the UteThanhToanThuLaoDataSource.
		/// </summary>
		protected UteThanhToanThuLaoDataSourceView UteThanhToanThuLaoView
		{
			get { return ( View as UteThanhToanThuLaoDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the UteThanhToanThuLaoDataSource control invokes to retrieve data.
		/// </summary>
		public UteThanhToanThuLaoSelectMethod SelectMethod
		{
			get
			{
				UteThanhToanThuLaoSelectMethod selectMethod = UteThanhToanThuLaoSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (UteThanhToanThuLaoSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the UteThanhToanThuLaoDataSourceView class that is to be
		/// used by the UteThanhToanThuLaoDataSource.
		/// </summary>
		/// <returns>An instance of the UteThanhToanThuLaoDataSourceView class.</returns>
		protected override BaseDataSourceView<UteThanhToanThuLao, UteThanhToanThuLaoKey> GetNewDataSourceView()
		{
			return new UteThanhToanThuLaoDataSourceView(this, DefaultViewName);
		}
		
		/// <summary>
        /// Creates a cache hashing key based on the startIndex, pageSize and the SelectMethod being used.
        /// </summary>
        /// <param name="startIndex">The current start row index.</param>
        /// <param name="pageSize">The current page size.</param>
        /// <returns>A string that can be used as a key for caching purposes.</returns>
		protected override string CacheHashKey(int startIndex, int pageSize)
        {
			return String.Format("{0}:{1}:{2}", SelectMethod, startIndex, pageSize);
        }
		
		#endregion Methods
	}
	
	/// <summary>
	/// Supports the UteThanhToanThuLaoDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class UteThanhToanThuLaoDataSourceView : ProviderDataSourceView<UteThanhToanThuLao, UteThanhToanThuLaoKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UteThanhToanThuLaoDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the UteThanhToanThuLaoDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public UteThanhToanThuLaoDataSourceView(UteThanhToanThuLaoDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal UteThanhToanThuLaoDataSource UteThanhToanThuLaoOwner
		{
			get { return Owner as UteThanhToanThuLaoDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal UteThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return UteThanhToanThuLaoOwner.SelectMethod; }
			set { UteThanhToanThuLaoOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal UteThanhToanThuLaoService UteThanhToanThuLaoProvider
		{
			get { return Provider as UteThanhToanThuLaoService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<UteThanhToanThuLao> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<UteThanhToanThuLao> results = null;
			UteThanhToanThuLao item;
			count = 0;
			
			System.Int32 _idKhoiLuongQuyDoi;
			System.String sp924_NamHoc;
			System.String sp924_HocKy;
			System.String sp924_MaDonVi;
			System.Int32 sp924_MaLoaiGiangVien;

			switch ( SelectMethod )
			{
				case UteThanhToanThuLaoSelectMethod.Get:
					UteThanhToanThuLaoKey entityKey  = new UteThanhToanThuLaoKey();
					entityKey.Load(values);
					item = UteThanhToanThuLaoProvider.Get(entityKey);
					results = new TList<UteThanhToanThuLao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case UteThanhToanThuLaoSelectMethod.GetAll:
                    results = UteThanhToanThuLaoProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case UteThanhToanThuLaoSelectMethod.GetPaged:
					results = UteThanhToanThuLaoProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case UteThanhToanThuLaoSelectMethod.Find:
					if ( FilterParameters != null )
						results = UteThanhToanThuLaoProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = UteThanhToanThuLaoProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case UteThanhToanThuLaoSelectMethod.GetByIdKhoiLuongQuyDoi:
					_idKhoiLuongQuyDoi = ( values["IdKhoiLuongQuyDoi"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["IdKhoiLuongQuyDoi"], typeof(System.Int32)) : (int)0;
					item = UteThanhToanThuLaoProvider.GetByIdKhoiLuongQuyDoi(_idKhoiLuongQuyDoi);
					results = new TList<UteThanhToanThuLao>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case UteThanhToanThuLaoSelectMethod.GetByNamHocHocKyDonViLoaiGiangVien:
					sp924_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp924_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					sp924_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					sp924_MaLoaiGiangVien = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.Int32));
					results = UteThanhToanThuLaoProvider.GetByNamHocHocKyDonViLoaiGiangVien(sp924_NamHoc, sp924_HocKy, sp924_MaDonVi, sp924_MaLoaiGiangVien, StartIndex, PageSize);
					break;
				default:
					break;
			}

			if ( results != null && count < 1 )
			{
				count = results.Count;

				if ( !String.IsNullOrEmpty(CustomMethodRecordCountParamName) )
				{
					object objCustomCount = EntityUtil.ChangeType(customOutput[CustomMethodRecordCountParamName], typeof(Int32));
					
					if ( objCustomCount != null )
					{
						count = (int) objCustomCount;
					}
				}
			}
			
			return results;
		}
		
		/// <summary>
		/// Gets the values of any supplied parameters for internal caching.
		/// </summary>
		/// <param name="values">An IDictionary object of name/value pairs.</param>
		protected override void GetSelectParameters(IDictionary values)
		{
			if ( SelectMethod == UteThanhToanThuLaoSelectMethod.Get || SelectMethod == UteThanhToanThuLaoSelectMethod.GetByIdKhoiLuongQuyDoi )
			{
				EntityId = GetEntityKey(values);
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation for the current entity if it has
		/// not already been performed.
		/// </summary>
		internal override void DeepLoad()
		{
			if ( !IsDeepLoaded )
			{
				UteThanhToanThuLao entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					UteThanhToanThuLaoProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
					// set loaded flag
					IsDeepLoaded = true;
				}
			}
		}

		/// <summary>
		/// Performs a DeepLoad operation on the specified entity collection.
		/// </summary>
		/// <param name="entityList"></param>
		/// <param name="properties"></param>
		internal override void DeepLoad(TList<UteThanhToanThuLao> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			UteThanhToanThuLaoProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region UteThanhToanThuLaoDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the UteThanhToanThuLaoDataSource class.
	/// </summary>
	public class UteThanhToanThuLaoDataSourceDesigner : ProviderDataSourceDesigner<UteThanhToanThuLao, UteThanhToanThuLaoKey>
	{
		/// <summary>
		/// Initializes a new instance of the UteThanhToanThuLaoDataSourceDesigner class.
		/// </summary>
		public UteThanhToanThuLaoDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public UteThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return ((UteThanhToanThuLaoDataSource) DataSource).SelectMethod; }
			set { SetPropertyValue("SelectMethod", value); }
		}

		/// <summary>Gets the designer action list collection for this designer.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.Design.DesignerActionListCollection"/>
		/// associated with this designer.</returns>
		public override DesignerActionListCollection ActionLists
		{
			get
			{
				DesignerActionListCollection actions = new DesignerActionListCollection();
				actions.Add(new UteThanhToanThuLaoDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region UteThanhToanThuLaoDataSourceActionList

	/// <summary>
	/// Supports the UteThanhToanThuLaoDataSourceDesigner class.
	/// </summary>
	internal class UteThanhToanThuLaoDataSourceActionList : DesignerActionList
	{
		private UteThanhToanThuLaoDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the UteThanhToanThuLaoDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public UteThanhToanThuLaoDataSourceActionList(UteThanhToanThuLaoDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public UteThanhToanThuLaoSelectMethod SelectMethod
		{
			get { return _designer.SelectMethod; }
			set { _designer.SelectMethod = value; }
		}

		/// <summary>
		/// Returns the collection of <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// objects contained in the list.
		/// </summary>
		/// <returns>A <see cref="T:System.ComponentModel.Design.DesignerActionItem"/>
		/// array that contains the items in this list.</returns>
		public override DesignerActionItemCollection GetSortedActionItems()
		{
			DesignerActionItemCollection items = new DesignerActionItemCollection();
			items.Add(new DesignerActionPropertyItem("SelectMethod", "Select Method", "Methods"));
			return items;
		}
	}

	#endregion UteThanhToanThuLaoDataSourceActionList
	
	#endregion UteThanhToanThuLaoDataSourceDesigner
	
	#region UteThanhToanThuLaoSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the UteThanhToanThuLaoDataSource.SelectMethod property.
	/// </summary>
	public enum UteThanhToanThuLaoSelectMethod
	{
		/// <summary>
		/// Represents the Get method.
		/// </summary>
		Get,
		/// <summary>
		/// Represents the GetAll method.
		/// </summary>
		GetAll,
		/// <summary>
		/// Represents the GetPaged method.
		/// </summary>
		GetPaged,
		/// <summary>
		/// Represents the Find method.
		/// </summary>
		Find,
		/// <summary>
		/// Represents the GetByIdKhoiLuongQuyDoi method.
		/// </summary>
		GetByIdKhoiLuongQuyDoi,
		/// <summary>
		/// Represents the GetByNamHocHocKyDonViLoaiGiangVien method.
		/// </summary>
		GetByNamHocHocKyDonViLoaiGiangVien
	}
	
	#endregion UteThanhToanThuLaoSelectMethod

	#region UteThanhToanThuLaoFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteThanhToanThuLaoFilter : SqlFilter<UteThanhToanThuLaoColumn>
	{
	}
	
	#endregion UteThanhToanThuLaoFilter

	#region UteThanhToanThuLaoExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="UteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteThanhToanThuLaoExpressionBuilder : SqlExpressionBuilder<UteThanhToanThuLaoColumn>
	{
	}
	
	#endregion UteThanhToanThuLaoExpressionBuilder	

	#region UteThanhToanThuLaoProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;UteThanhToanThuLaoChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="UteThanhToanThuLao"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class UteThanhToanThuLaoProperty : ChildEntityProperty<UteThanhToanThuLaoChildEntityTypes>
	{
	}
	
	#endregion UteThanhToanThuLaoProperty
}

