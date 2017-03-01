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
	/// Represents the DataRepository.KcqPhanBienLuanAnProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqPhanBienLuanAnDataSourceDesigner))]
	public class KcqPhanBienLuanAnDataSource : ProviderDataSource<KcqPhanBienLuanAn, KcqPhanBienLuanAnKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnDataSource class.
		/// </summary>
		public KcqPhanBienLuanAnDataSource() : base(new KcqPhanBienLuanAnService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqPhanBienLuanAnDataSourceView used by the KcqPhanBienLuanAnDataSource.
		/// </summary>
		protected KcqPhanBienLuanAnDataSourceView KcqPhanBienLuanAnView
		{
			get { return ( View as KcqPhanBienLuanAnDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqPhanBienLuanAnDataSource control invokes to retrieve data.
		/// </summary>
		public KcqPhanBienLuanAnSelectMethod SelectMethod
		{
			get
			{
				KcqPhanBienLuanAnSelectMethod selectMethod = KcqPhanBienLuanAnSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqPhanBienLuanAnSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqPhanBienLuanAnDataSourceView class that is to be
		/// used by the KcqPhanBienLuanAnDataSource.
		/// </summary>
		/// <returns>An instance of the KcqPhanBienLuanAnDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqPhanBienLuanAn, KcqPhanBienLuanAnKey> GetNewDataSourceView()
		{
			return new KcqPhanBienLuanAnDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqPhanBienLuanAnDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqPhanBienLuanAnDataSourceView : ProviderDataSourceView<KcqPhanBienLuanAn, KcqPhanBienLuanAnKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqPhanBienLuanAnDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqPhanBienLuanAnDataSourceView(KcqPhanBienLuanAnDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqPhanBienLuanAnDataSource KcqPhanBienLuanAnOwner
		{
			get { return Owner as KcqPhanBienLuanAnDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqPhanBienLuanAnSelectMethod SelectMethod
		{
			get { return KcqPhanBienLuanAnOwner.SelectMethod; }
			set { KcqPhanBienLuanAnOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqPhanBienLuanAnService KcqPhanBienLuanAnProvider
		{
			get { return Provider as KcqPhanBienLuanAnService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqPhanBienLuanAn> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqPhanBienLuanAn> results = null;
			KcqPhanBienLuanAn item;
			count = 0;
			
			System.Int32 _maGiangVien;
			System.String _namHoc;
			System.String _hocKy;
			System.String _loai;

			switch ( SelectMethod )
			{
				case KcqPhanBienLuanAnSelectMethod.Get:
					KcqPhanBienLuanAnKey entityKey  = new KcqPhanBienLuanAnKey();
					entityKey.Load(values);
					item = KcqPhanBienLuanAnProvider.Get(entityKey);
					results = new TList<KcqPhanBienLuanAn>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqPhanBienLuanAnSelectMethod.GetAll:
                    results = KcqPhanBienLuanAnProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqPhanBienLuanAnSelectMethod.GetPaged:
					results = KcqPhanBienLuanAnProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqPhanBienLuanAnSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqPhanBienLuanAnProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqPhanBienLuanAnProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqPhanBienLuanAnSelectMethod.GetByMaGiangVienNamHocHocKyLoai:
					_maGiangVien = ( values["MaGiangVien"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaGiangVien"], typeof(System.Int32)) : (int)0;
					_namHoc = ( values["NamHoc"] != null ) ? (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String)) : string.Empty;
					_hocKy = ( values["HocKy"] != null ) ? (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String)) : string.Empty;
					_loai = ( values["Loai"] != null ) ? (System.String) EntityUtil.ChangeType(values["Loai"], typeof(System.String)) : string.Empty;
					item = KcqPhanBienLuanAnProvider.GetByMaGiangVienNamHocHocKyLoai(_maGiangVien, _namHoc, _hocKy, _loai);
					results = new TList<KcqPhanBienLuanAn>();
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
			if ( SelectMethod == KcqPhanBienLuanAnSelectMethod.Get || SelectMethod == KcqPhanBienLuanAnSelectMethod.GetByMaGiangVienNamHocHocKyLoai )
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
				KcqPhanBienLuanAn entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqPhanBienLuanAnProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqPhanBienLuanAn> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqPhanBienLuanAnProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqPhanBienLuanAnDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqPhanBienLuanAnDataSource class.
	/// </summary>
	public class KcqPhanBienLuanAnDataSourceDesigner : ProviderDataSourceDesigner<KcqPhanBienLuanAn, KcqPhanBienLuanAnKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnDataSourceDesigner class.
		/// </summary>
		public KcqPhanBienLuanAnDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhanBienLuanAnSelectMethod SelectMethod
		{
			get { return ((KcqPhanBienLuanAnDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqPhanBienLuanAnDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqPhanBienLuanAnDataSourceActionList

	/// <summary>
	/// Supports the KcqPhanBienLuanAnDataSourceDesigner class.
	/// </summary>
	internal class KcqPhanBienLuanAnDataSourceActionList : DesignerActionList
	{
		private KcqPhanBienLuanAnDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqPhanBienLuanAnDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqPhanBienLuanAnDataSourceActionList(KcqPhanBienLuanAnDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhanBienLuanAnSelectMethod SelectMethod
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

	#endregion KcqPhanBienLuanAnDataSourceActionList
	
	#endregion KcqPhanBienLuanAnDataSourceDesigner
	
	#region KcqPhanBienLuanAnSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqPhanBienLuanAnDataSource.SelectMethod property.
	/// </summary>
	public enum KcqPhanBienLuanAnSelectMethod
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
	
	#endregion KcqPhanBienLuanAnSelectMethod

	#region KcqPhanBienLuanAnFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanBienLuanAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanBienLuanAnFilter : SqlFilter<KcqPhanBienLuanAnColumn>
	{
	}
	
	#endregion KcqPhanBienLuanAnFilter

	#region KcqPhanBienLuanAnExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanBienLuanAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanBienLuanAnExpressionBuilder : SqlExpressionBuilder<KcqPhanBienLuanAnColumn>
	{
	}
	
	#endregion KcqPhanBienLuanAnExpressionBuilder	

	#region KcqPhanBienLuanAnProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqPhanBienLuanAnChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanBienLuanAn"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanBienLuanAnProperty : ChildEntityProperty<KcqPhanBienLuanAnChildEntityTypes>
	{
	}
	
	#endregion KcqPhanBienLuanAnProperty
}

