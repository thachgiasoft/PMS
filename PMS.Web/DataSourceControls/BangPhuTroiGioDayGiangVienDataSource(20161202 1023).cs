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
	/// Represents the DataRepository.BangPhuTroiGioDayGiangVienProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(BangPhuTroiGioDayGiangVienDataSourceDesigner))]
	public class BangPhuTroiGioDayGiangVienDataSource : ProviderDataSource<BangPhuTroiGioDayGiangVien, BangPhuTroiGioDayGiangVienKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienDataSource class.
		/// </summary>
		public BangPhuTroiGioDayGiangVienDataSource() : base(new BangPhuTroiGioDayGiangVienService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the BangPhuTroiGioDayGiangVienDataSourceView used by the BangPhuTroiGioDayGiangVienDataSource.
		/// </summary>
		protected BangPhuTroiGioDayGiangVienDataSourceView BangPhuTroiGioDayGiangVienView
		{
			get { return ( View as BangPhuTroiGioDayGiangVienDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the BangPhuTroiGioDayGiangVienDataSource control invokes to retrieve data.
		/// </summary>
		public BangPhuTroiGioDayGiangVienSelectMethod SelectMethod
		{
			get
			{
				BangPhuTroiGioDayGiangVienSelectMethod selectMethod = BangPhuTroiGioDayGiangVienSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (BangPhuTroiGioDayGiangVienSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the BangPhuTroiGioDayGiangVienDataSourceView class that is to be
		/// used by the BangPhuTroiGioDayGiangVienDataSource.
		/// </summary>
		/// <returns>An instance of the BangPhuTroiGioDayGiangVienDataSourceView class.</returns>
		protected override BaseDataSourceView<BangPhuTroiGioDayGiangVien, BangPhuTroiGioDayGiangVienKey> GetNewDataSourceView()
		{
			return new BangPhuTroiGioDayGiangVienDataSourceView(this, DefaultViewName);
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
	/// Supports the BangPhuTroiGioDayGiangVienDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class BangPhuTroiGioDayGiangVienDataSourceView : ProviderDataSourceView<BangPhuTroiGioDayGiangVien, BangPhuTroiGioDayGiangVienKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the BangPhuTroiGioDayGiangVienDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public BangPhuTroiGioDayGiangVienDataSourceView(BangPhuTroiGioDayGiangVienDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal BangPhuTroiGioDayGiangVienDataSource BangPhuTroiGioDayGiangVienOwner
		{
			get { return Owner as BangPhuTroiGioDayGiangVienDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal BangPhuTroiGioDayGiangVienSelectMethod SelectMethod
		{
			get { return BangPhuTroiGioDayGiangVienOwner.SelectMethod; }
			set { BangPhuTroiGioDayGiangVienOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal BangPhuTroiGioDayGiangVienService BangPhuTroiGioDayGiangVienProvider
		{
			get { return Provider as BangPhuTroiGioDayGiangVienService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<BangPhuTroiGioDayGiangVien> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<BangPhuTroiGioDayGiangVien> results = null;
			BangPhuTroiGioDayGiangVien item;
			count = 0;
			
			System.Int32 _maGiangVien;
			System.String sp2100_NamHoc;
			System.Int32 sp2100_MaLoaiGv;
			System.String sp2100_MaDonVi;

			switch ( SelectMethod )
			{
				case BangPhuTroiGioDayGiangVienSelectMethod.Get:
					BangPhuTroiGioDayGiangVienKey entityKey  = new BangPhuTroiGioDayGiangVienKey();
					entityKey.Load(values);
					item = BangPhuTroiGioDayGiangVienProvider.Get(entityKey);
					results = new TList<BangPhuTroiGioDayGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case BangPhuTroiGioDayGiangVienSelectMethod.GetAll:
                    results = BangPhuTroiGioDayGiangVienProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case BangPhuTroiGioDayGiangVienSelectMethod.GetPaged:
					results = BangPhuTroiGioDayGiangVienProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case BangPhuTroiGioDayGiangVienSelectMethod.Find:
					if ( FilterParameters != null )
						results = BangPhuTroiGioDayGiangVienProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = BangPhuTroiGioDayGiangVienProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case BangPhuTroiGioDayGiangVienSelectMethod.GetByMaGiangVien:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					item = BangPhuTroiGioDayGiangVienProvider.GetByMaGiangVien(_maGiangVien);
					results = new TList<BangPhuTroiGioDayGiangVien>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case BangPhuTroiGioDayGiangVienSelectMethod.GetByNamHocHocKyMaDonViMaLoaiGiangVien:
					sp2100_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2100_MaLoaiGv = (System.Int32) EntityUtil.ChangeType(values["MaLoaiGv"], typeof(System.Int32));
					sp2100_MaDonVi = (System.String) EntityUtil.ChangeType(values["MaDonVi"], typeof(System.String));
					results = BangPhuTroiGioDayGiangVienProvider.GetByNamHocHocKyMaDonViMaLoaiGiangVien(sp2100_NamHoc, sp2100_MaLoaiGv, sp2100_MaDonVi, StartIndex, PageSize);
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
			if ( SelectMethod == BangPhuTroiGioDayGiangVienSelectMethod.Get || SelectMethod == BangPhuTroiGioDayGiangVienSelectMethod.GetByMaGiangVien )
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
				BangPhuTroiGioDayGiangVien entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					BangPhuTroiGioDayGiangVienProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<BangPhuTroiGioDayGiangVien> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			BangPhuTroiGioDayGiangVienProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region BangPhuTroiGioDayGiangVienDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the BangPhuTroiGioDayGiangVienDataSource class.
	/// </summary>
	public class BangPhuTroiGioDayGiangVienDataSourceDesigner : ProviderDataSourceDesigner<BangPhuTroiGioDayGiangVien, BangPhuTroiGioDayGiangVienKey>
	{
		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienDataSourceDesigner class.
		/// </summary>
		public BangPhuTroiGioDayGiangVienDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public BangPhuTroiGioDayGiangVienSelectMethod SelectMethod
		{
			get { return ((BangPhuTroiGioDayGiangVienDataSource) DataSource).SelectMethod; }
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
				actions.Add(new BangPhuTroiGioDayGiangVienDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region BangPhuTroiGioDayGiangVienDataSourceActionList

	/// <summary>
	/// Supports the BangPhuTroiGioDayGiangVienDataSourceDesigner class.
	/// </summary>
	internal class BangPhuTroiGioDayGiangVienDataSourceActionList : DesignerActionList
	{
		private BangPhuTroiGioDayGiangVienDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the BangPhuTroiGioDayGiangVienDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public BangPhuTroiGioDayGiangVienDataSourceActionList(BangPhuTroiGioDayGiangVienDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public BangPhuTroiGioDayGiangVienSelectMethod SelectMethod
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

	#endregion BangPhuTroiGioDayGiangVienDataSourceActionList
	
	#endregion BangPhuTroiGioDayGiangVienDataSourceDesigner
	
	#region BangPhuTroiGioDayGiangVienSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the BangPhuTroiGioDayGiangVienDataSource.SelectMethod property.
	/// </summary>
	public enum BangPhuTroiGioDayGiangVienSelectMethod
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
		/// Represents the GetByMaGiangVien method.
		/// </summary>
		GetByMaGiangVien,
		/// <summary>
		/// Represents the GetByNamHocHocKyMaDonViMaLoaiGiangVien method.
		/// </summary>
		GetByNamHocHocKyMaDonViMaLoaiGiangVien
	}
	
	#endregion BangPhuTroiGioDayGiangVienSelectMethod

	#region BangPhuTroiGioDayGiangVienFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiGioDayGiangVienFilter : SqlFilter<BangPhuTroiGioDayGiangVienColumn>
	{
	}
	
	#endregion BangPhuTroiGioDayGiangVienFilter

	#region BangPhuTroiGioDayGiangVienExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiGioDayGiangVienExpressionBuilder : SqlExpressionBuilder<BangPhuTroiGioDayGiangVienColumn>
	{
	}
	
	#endregion BangPhuTroiGioDayGiangVienExpressionBuilder	

	#region BangPhuTroiGioDayGiangVienProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;BangPhuTroiGioDayGiangVienChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="BangPhuTroiGioDayGiangVien"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class BangPhuTroiGioDayGiangVienProperty : ChildEntityProperty<BangPhuTroiGioDayGiangVienChildEntityTypes>
	{
	}
	
	#endregion BangPhuTroiGioDayGiangVienProperty
}

