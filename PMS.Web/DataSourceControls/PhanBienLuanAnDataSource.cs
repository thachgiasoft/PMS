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
	/// Represents the DataRepository.PhanBienLuanAnProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(PhanBienLuanAnDataSourceDesigner))]
	public class PhanBienLuanAnDataSource : ProviderDataSource<PhanBienLuanAn, PhanBienLuanAnKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanBienLuanAnDataSource class.
		/// </summary>
		public PhanBienLuanAnDataSource() : base(new PhanBienLuanAnService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the PhanBienLuanAnDataSourceView used by the PhanBienLuanAnDataSource.
		/// </summary>
		protected PhanBienLuanAnDataSourceView PhanBienLuanAnView
		{
			get { return ( View as PhanBienLuanAnDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the PhanBienLuanAnDataSource control invokes to retrieve data.
		/// </summary>
		public PhanBienLuanAnSelectMethod SelectMethod
		{
			get
			{
				PhanBienLuanAnSelectMethod selectMethod = PhanBienLuanAnSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (PhanBienLuanAnSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the PhanBienLuanAnDataSourceView class that is to be
		/// used by the PhanBienLuanAnDataSource.
		/// </summary>
		/// <returns>An instance of the PhanBienLuanAnDataSourceView class.</returns>
		protected override BaseDataSourceView<PhanBienLuanAn, PhanBienLuanAnKey> GetNewDataSourceView()
		{
			return new PhanBienLuanAnDataSourceView(this, DefaultViewName);
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
	/// Supports the PhanBienLuanAnDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class PhanBienLuanAnDataSourceView : ProviderDataSourceView<PhanBienLuanAn, PhanBienLuanAnKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanBienLuanAnDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the PhanBienLuanAnDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public PhanBienLuanAnDataSourceView(PhanBienLuanAnDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal PhanBienLuanAnDataSource PhanBienLuanAnOwner
		{
			get { return Owner as PhanBienLuanAnDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal PhanBienLuanAnSelectMethod SelectMethod
		{
			get { return PhanBienLuanAnOwner.SelectMethod; }
			set { PhanBienLuanAnOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal PhanBienLuanAnService PhanBienLuanAnProvider
		{
			get { return Provider as PhanBienLuanAnService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<PhanBienLuanAn> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<PhanBienLuanAn> results = null;
			PhanBienLuanAn item;
			count = 0;
			
			System.Int32 _maGiangVien;
			System.String _namHoc;
			System.String _hocKy;
			System.String _loai;

			switch ( SelectMethod )
			{
				case PhanBienLuanAnSelectMethod.Get:
					PhanBienLuanAnKey entityKey  = new PhanBienLuanAnKey();
					entityKey.Load(values);
					item = PhanBienLuanAnProvider.Get(entityKey);
					results = new TList<PhanBienLuanAn>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case PhanBienLuanAnSelectMethod.GetAll:
                    results = PhanBienLuanAnProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case PhanBienLuanAnSelectMethod.GetPaged:
					results = PhanBienLuanAnProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case PhanBienLuanAnSelectMethod.Find:
					if ( FilterParameters != null )
						results = PhanBienLuanAnProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = PhanBienLuanAnProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case PhanBienLuanAnSelectMethod.GetByMaGiangVienNamHocHocKyLoai:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					_namHoc = ( values["NamHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String)) : string.Empty;
					_hocKy = ( values["HocKy"] != null ) ? (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String)) : string.Empty;
					_loai = ( values["Loai"] != null ) ? (System.String) EntityUtil.ChangeType(values["Loai"], typeof(System.String)) : string.Empty;
					item = PhanBienLuanAnProvider.GetByMaGiangVienNamHocHocKyLoai(_maGiangVien, _namHoc, _hocKy, _loai);
					results = new TList<PhanBienLuanAn>();
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
			if ( SelectMethod == PhanBienLuanAnSelectMethod.Get || SelectMethod == PhanBienLuanAnSelectMethod.GetByMaGiangVienNamHocHocKyLoai )
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
				PhanBienLuanAn entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					PhanBienLuanAnProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<PhanBienLuanAn> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			PhanBienLuanAnProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region PhanBienLuanAnDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the PhanBienLuanAnDataSource class.
	/// </summary>
	public class PhanBienLuanAnDataSourceDesigner : ProviderDataSourceDesigner<PhanBienLuanAn, PhanBienLuanAnKey>
	{
		/// <summary>
		/// Initializes a new instance of the PhanBienLuanAnDataSourceDesigner class.
		/// </summary>
		public PhanBienLuanAnDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanBienLuanAnSelectMethod SelectMethod
		{
			get { return ((PhanBienLuanAnDataSource) DataSource).SelectMethod; }
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
				actions.Add(new PhanBienLuanAnDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region PhanBienLuanAnDataSourceActionList

	/// <summary>
	/// Supports the PhanBienLuanAnDataSourceDesigner class.
	/// </summary>
	internal class PhanBienLuanAnDataSourceActionList : DesignerActionList
	{
		private PhanBienLuanAnDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the PhanBienLuanAnDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public PhanBienLuanAnDataSourceActionList(PhanBienLuanAnDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanBienLuanAnSelectMethod SelectMethod
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

	#endregion PhanBienLuanAnDataSourceActionList
	
	#endregion PhanBienLuanAnDataSourceDesigner
	
	#region PhanBienLuanAnSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the PhanBienLuanAnDataSource.SelectMethod property.
	/// </summary>
	public enum PhanBienLuanAnSelectMethod
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
		/// Represents the GetByMaGiangVienNamHocHocKyLoai method.
		/// </summary>
		GetByMaGiangVienNamHocHocKyLoai
	}
	
	#endregion PhanBienLuanAnSelectMethod

	#region PhanBienLuanAnFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanBienLuanAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanBienLuanAnFilter : SqlFilter<PhanBienLuanAnColumn>
	{
	}
	
	#endregion PhanBienLuanAnFilter

	#region PhanBienLuanAnExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanBienLuanAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanBienLuanAnExpressionBuilder : SqlExpressionBuilder<PhanBienLuanAnColumn>
	{
	}
	
	#endregion PhanBienLuanAnExpressionBuilder	

	#region PhanBienLuanAnProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;PhanBienLuanAnChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="PhanBienLuanAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanBienLuanAnProperty : ChildEntityProperty<PhanBienLuanAnChildEntityTypes>
	{
	}
	
	#endregion PhanBienLuanAnProperty
}

