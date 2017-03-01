﻿#region Using Directives
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
	/// Represents the DataRepository.HeSoTinChiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(HeSoTinChiDataSourceDesigner))]
	public class HeSoTinChiDataSource : ProviderDataSource<HeSoTinChi, HeSoTinChiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiDataSource class.
		/// </summary>
		public HeSoTinChiDataSource() : base(new HeSoTinChiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the HeSoTinChiDataSourceView used by the HeSoTinChiDataSource.
		/// </summary>
		protected HeSoTinChiDataSourceView HeSoTinChiView
		{
			get { return ( View as HeSoTinChiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the HeSoTinChiDataSource control invokes to retrieve data.
		/// </summary>
		public HeSoTinChiSelectMethod SelectMethod
		{
			get
			{
				HeSoTinChiSelectMethod selectMethod = HeSoTinChiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (HeSoTinChiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the HeSoTinChiDataSourceView class that is to be
		/// used by the HeSoTinChiDataSource.
		/// </summary>
		/// <returns>An instance of the HeSoTinChiDataSourceView class.</returns>
		protected override BaseDataSourceView<HeSoTinChi, HeSoTinChiKey> GetNewDataSourceView()
		{
			return new HeSoTinChiDataSourceView(this, DefaultViewName);
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
	/// Supports the HeSoTinChiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class HeSoTinChiDataSourceView : ProviderDataSourceView<HeSoTinChi, HeSoTinChiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the HeSoTinChiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public HeSoTinChiDataSourceView(HeSoTinChiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal HeSoTinChiDataSource HeSoTinChiOwner
		{
			get { return Owner as HeSoTinChiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal HeSoTinChiSelectMethod SelectMethod
		{
			get { return HeSoTinChiOwner.SelectMethod; }
			set { HeSoTinChiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal HeSoTinChiService HeSoTinChiProvider
		{
			get { return Provider as HeSoTinChiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<HeSoTinChi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<HeSoTinChi> results = null;
			HeSoTinChi item;
			count = 0;
			
			System.String _maHeDaoTao;
			System.String _maBacDaoTao;
			System.String _maLoaiGiangVien;

			switch ( SelectMethod )
			{
				case HeSoTinChiSelectMethod.Get:
					HeSoTinChiKey entityKey  = new HeSoTinChiKey();
					entityKey.Load(values);
					item = HeSoTinChiProvider.Get(entityKey);
					results = new TList<HeSoTinChi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case HeSoTinChiSelectMethod.GetAll:
                    results = HeSoTinChiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case HeSoTinChiSelectMethod.GetPaged:
					results = HeSoTinChiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case HeSoTinChiSelectMethod.Find:
					if ( FilterParameters != null )
						results = HeSoTinChiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = HeSoTinChiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case HeSoTinChiSelectMethod.GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien:
					_maHeDaoTao = ( values["MaHeDaoTao"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaHeDaoTao"], typeof(System.String)) : string.Empty;
					_maBacDaoTao = ( values["MaBacDaoTao"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaBacDaoTao"], typeof(System.String)) : string.Empty;
					_maLoaiGiangVien = ( values["MaLoaiGiangVien"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaLoaiGiangVien"], typeof(System.String)) : string.Empty;
					item = HeSoTinChiProvider.GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien(_maHeDaoTao, _maBacDaoTao, _maLoaiGiangVien);
					results = new TList<HeSoTinChi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
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
			if ( SelectMethod == HeSoTinChiSelectMethod.Get || SelectMethod == HeSoTinChiSelectMethod.GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien )
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
				HeSoTinChi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					HeSoTinChiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<HeSoTinChi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			HeSoTinChiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region HeSoTinChiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the HeSoTinChiDataSource class.
	/// </summary>
	public class HeSoTinChiDataSourceDesigner : ProviderDataSourceDesigner<HeSoTinChi, HeSoTinChiKey>
	{
		/// <summary>
		/// Initializes a new instance of the HeSoTinChiDataSourceDesigner class.
		/// </summary>
		public HeSoTinChiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoTinChiSelectMethod SelectMethod
		{
			get { return ((HeSoTinChiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new HeSoTinChiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region HeSoTinChiDataSourceActionList

	/// <summary>
	/// Supports the HeSoTinChiDataSourceDesigner class.
	/// </summary>
	internal class HeSoTinChiDataSourceActionList : DesignerActionList
	{
		private HeSoTinChiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the HeSoTinChiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public HeSoTinChiDataSourceActionList(HeSoTinChiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public HeSoTinChiSelectMethod SelectMethod
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

	#endregion HeSoTinChiDataSourceActionList
	
	#endregion HeSoTinChiDataSourceDesigner
	
	#region HeSoTinChiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the HeSoTinChiDataSource.SelectMethod property.
	/// </summary>
	public enum HeSoTinChiSelectMethod
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
		/// Represents the GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien method.
		/// </summary>
		GetByMaHeDaoTaoMaBacDaoTaoMaLoaiGiangVien
	}
	
	#endregion HeSoTinChiSelectMethod

	#region HeSoTinChiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoTinChiFilter : SqlFilter<HeSoTinChiColumn>
	{
	}
	
	#endregion HeSoTinChiFilter

	#region HeSoTinChiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoTinChiExpressionBuilder : SqlExpressionBuilder<HeSoTinChiColumn>
	{
	}
	
	#endregion HeSoTinChiExpressionBuilder	

	#region HeSoTinChiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;HeSoTinChiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="HeSoTinChi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class HeSoTinChiProperty : ChildEntityProperty<HeSoTinChiChildEntityTypes>
	{
	}
	
	#endregion HeSoTinChiProperty
}

