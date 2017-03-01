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
	/// Represents the DataRepository.KhoiLuongDoAnTotNghiepChiTietProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongDoAnTotNghiepChiTietDataSourceDesigner))]
	public class KhoiLuongDoAnTotNghiepChiTietDataSource : ProviderDataSource<KhoiLuongDoAnTotNghiepChiTiet, KhoiLuongDoAnTotNghiepChiTietKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietDataSource class.
		/// </summary>
		public KhoiLuongDoAnTotNghiepChiTietDataSource() : base(new KhoiLuongDoAnTotNghiepChiTietService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongDoAnTotNghiepChiTietDataSourceView used by the KhoiLuongDoAnTotNghiepChiTietDataSource.
		/// </summary>
		protected KhoiLuongDoAnTotNghiepChiTietDataSourceView KhoiLuongDoAnTotNghiepChiTietView
		{
			get { return ( View as KhoiLuongDoAnTotNghiepChiTietDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongDoAnTotNghiepChiTietDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongDoAnTotNghiepChiTietSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongDoAnTotNghiepChiTietSelectMethod selectMethod = KhoiLuongDoAnTotNghiepChiTietSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongDoAnTotNghiepChiTietSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongDoAnTotNghiepChiTietDataSourceView class that is to be
		/// used by the KhoiLuongDoAnTotNghiepChiTietDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongDoAnTotNghiepChiTietDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongDoAnTotNghiepChiTiet, KhoiLuongDoAnTotNghiepChiTietKey> GetNewDataSourceView()
		{
			return new KhoiLuongDoAnTotNghiepChiTietDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongDoAnTotNghiepChiTietDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongDoAnTotNghiepChiTietDataSourceView : ProviderDataSourceView<KhoiLuongDoAnTotNghiepChiTiet, KhoiLuongDoAnTotNghiepChiTietKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongDoAnTotNghiepChiTietDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongDoAnTotNghiepChiTietDataSourceView(KhoiLuongDoAnTotNghiepChiTietDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongDoAnTotNghiepChiTietDataSource KhoiLuongDoAnTotNghiepChiTietOwner
		{
			get { return Owner as KhoiLuongDoAnTotNghiepChiTietDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongDoAnTotNghiepChiTietSelectMethod SelectMethod
		{
			get { return KhoiLuongDoAnTotNghiepChiTietOwner.SelectMethod; }
			set { KhoiLuongDoAnTotNghiepChiTietOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongDoAnTotNghiepChiTietService KhoiLuongDoAnTotNghiepChiTietProvider
		{
			get { return Provider as KhoiLuongDoAnTotNghiepChiTietService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongDoAnTotNghiepChiTiet> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongDoAnTotNghiepChiTiet> results = null;
			KhoiLuongDoAnTotNghiepChiTiet item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2650_NamHoc;
			System.String sp2650_HocKy;

			switch ( SelectMethod )
			{
				case KhoiLuongDoAnTotNghiepChiTietSelectMethod.Get:
					KhoiLuongDoAnTotNghiepChiTietKey entityKey  = new KhoiLuongDoAnTotNghiepChiTietKey();
					entityKey.Load(values);
					item = KhoiLuongDoAnTotNghiepChiTietProvider.Get(entityKey);
					results = new TList<KhoiLuongDoAnTotNghiepChiTiet>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongDoAnTotNghiepChiTietSelectMethod.GetAll:
                    results = KhoiLuongDoAnTotNghiepChiTietProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongDoAnTotNghiepChiTietSelectMethod.GetPaged:
					results = KhoiLuongDoAnTotNghiepChiTietProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongDoAnTotNghiepChiTietSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongDoAnTotNghiepChiTietProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongDoAnTotNghiepChiTietProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongDoAnTotNghiepChiTietSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongDoAnTotNghiepChiTietProvider.GetById(_id);
					results = new TList<KhoiLuongDoAnTotNghiepChiTiet>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KhoiLuongDoAnTotNghiepChiTietSelectMethod.GetByNamHocHocKy:
					sp2650_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2650_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KhoiLuongDoAnTotNghiepChiTietProvider.GetByNamHocHocKy(sp2650_NamHoc, sp2650_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == KhoiLuongDoAnTotNghiepChiTietSelectMethod.Get || SelectMethod == KhoiLuongDoAnTotNghiepChiTietSelectMethod.GetById )
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
				KhoiLuongDoAnTotNghiepChiTiet entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongDoAnTotNghiepChiTietProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongDoAnTotNghiepChiTiet> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongDoAnTotNghiepChiTietProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongDoAnTotNghiepChiTietDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongDoAnTotNghiepChiTietDataSource class.
	/// </summary>
	public class KhoiLuongDoAnTotNghiepChiTietDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongDoAnTotNghiepChiTiet, KhoiLuongDoAnTotNghiepChiTietKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietDataSourceDesigner class.
		/// </summary>
		public KhoiLuongDoAnTotNghiepChiTietDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongDoAnTotNghiepChiTietSelectMethod SelectMethod
		{
			get { return ((KhoiLuongDoAnTotNghiepChiTietDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongDoAnTotNghiepChiTietDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongDoAnTotNghiepChiTietDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongDoAnTotNghiepChiTietDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongDoAnTotNghiepChiTietDataSourceActionList : DesignerActionList
	{
		private KhoiLuongDoAnTotNghiepChiTietDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongDoAnTotNghiepChiTietDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongDoAnTotNghiepChiTietDataSourceActionList(KhoiLuongDoAnTotNghiepChiTietDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongDoAnTotNghiepChiTietSelectMethod SelectMethod
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

	#endregion KhoiLuongDoAnTotNghiepChiTietDataSourceActionList
	
	#endregion KhoiLuongDoAnTotNghiepChiTietDataSourceDesigner
	
	#region KhoiLuongDoAnTotNghiepChiTietSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongDoAnTotNghiepChiTietDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongDoAnTotNghiepChiTietSelectMethod
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
		/// Represents the GetById method.
		/// </summary>
		GetById,
		/// <summary>
		/// Represents the GetByNamHocHocKy method.
		/// </summary>
		GetByNamHocHocKy
	}
	
	#endregion KhoiLuongDoAnTotNghiepChiTietSelectMethod

	#region KhoiLuongDoAnTotNghiepChiTietFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongDoAnTotNghiepChiTietFilter : SqlFilter<KhoiLuongDoAnTotNghiepChiTietColumn>
	{
	}
	
	#endregion KhoiLuongDoAnTotNghiepChiTietFilter

	#region KhoiLuongDoAnTotNghiepChiTietExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongDoAnTotNghiepChiTietExpressionBuilder : SqlExpressionBuilder<KhoiLuongDoAnTotNghiepChiTietColumn>
	{
	}
	
	#endregion KhoiLuongDoAnTotNghiepChiTietExpressionBuilder	

	#region KhoiLuongDoAnTotNghiepChiTietProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongDoAnTotNghiepChiTietChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongDoAnTotNghiepChiTietProperty : ChildEntityProperty<KhoiLuongDoAnTotNghiepChiTietChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongDoAnTotNghiepChiTietProperty
}

