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
	/// Represents the DataRepository.KcqKhoiLuongDoAnTotNghiepChiTietProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqKhoiLuongDoAnTotNghiepChiTietDataSourceDesigner))]
	public class KcqKhoiLuongDoAnTotNghiepChiTietDataSource : ProviderDataSource<KcqKhoiLuongDoAnTotNghiepChiTiet, KcqKhoiLuongDoAnTotNghiepChiTietKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietDataSource class.
		/// </summary>
		public KcqKhoiLuongDoAnTotNghiepChiTietDataSource() : base(new KcqKhoiLuongDoAnTotNghiepChiTietService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqKhoiLuongDoAnTotNghiepChiTietDataSourceView used by the KcqKhoiLuongDoAnTotNghiepChiTietDataSource.
		/// </summary>
		protected KcqKhoiLuongDoAnTotNghiepChiTietDataSourceView KcqKhoiLuongDoAnTotNghiepChiTietView
		{
			get { return ( View as KcqKhoiLuongDoAnTotNghiepChiTietDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqKhoiLuongDoAnTotNghiepChiTietDataSource control invokes to retrieve data.
		/// </summary>
		public KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod SelectMethod
		{
			get
			{
				KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod selectMethod = KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietDataSourceView class that is to be
		/// used by the KcqKhoiLuongDoAnTotNghiepChiTietDataSource.
		/// </summary>
		/// <returns>An instance of the KcqKhoiLuongDoAnTotNghiepChiTietDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqKhoiLuongDoAnTotNghiepChiTiet, KcqKhoiLuongDoAnTotNghiepChiTietKey> GetNewDataSourceView()
		{
			return new KcqKhoiLuongDoAnTotNghiepChiTietDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqKhoiLuongDoAnTotNghiepChiTietDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqKhoiLuongDoAnTotNghiepChiTietDataSourceView : ProviderDataSourceView<KcqKhoiLuongDoAnTotNghiepChiTiet, KcqKhoiLuongDoAnTotNghiepChiTietKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqKhoiLuongDoAnTotNghiepChiTietDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqKhoiLuongDoAnTotNghiepChiTietDataSourceView(KcqKhoiLuongDoAnTotNghiepChiTietDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqKhoiLuongDoAnTotNghiepChiTietDataSource KcqKhoiLuongDoAnTotNghiepChiTietOwner
		{
			get { return Owner as KcqKhoiLuongDoAnTotNghiepChiTietDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod SelectMethod
		{
			get { return KcqKhoiLuongDoAnTotNghiepChiTietOwner.SelectMethod; }
			set { KcqKhoiLuongDoAnTotNghiepChiTietOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqKhoiLuongDoAnTotNghiepChiTietService KcqKhoiLuongDoAnTotNghiepChiTietProvider
		{
			get { return Provider as KcqKhoiLuongDoAnTotNghiepChiTietService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqKhoiLuongDoAnTotNghiepChiTiet> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqKhoiLuongDoAnTotNghiepChiTiet> results = null;
			KcqKhoiLuongDoAnTotNghiepChiTiet item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2465_NamHoc;
			System.String sp2465_HocKy;

			switch ( SelectMethod )
			{
				case KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod.Get:
					KcqKhoiLuongDoAnTotNghiepChiTietKey entityKey  = new KcqKhoiLuongDoAnTotNghiepChiTietKey();
					entityKey.Load(values);
					item = KcqKhoiLuongDoAnTotNghiepChiTietProvider.Get(entityKey);
					results = new TList<KcqKhoiLuongDoAnTotNghiepChiTiet>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod.GetAll:
                    results = KcqKhoiLuongDoAnTotNghiepChiTietProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod.GetPaged:
					results = KcqKhoiLuongDoAnTotNghiepChiTietProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqKhoiLuongDoAnTotNghiepChiTietProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqKhoiLuongDoAnTotNghiepChiTietProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqKhoiLuongDoAnTotNghiepChiTietProvider.GetById(_id);
					results = new TList<KcqKhoiLuongDoAnTotNghiepChiTiet>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod.GetByNamHocHocKyDot:
					sp2465_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2465_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KcqKhoiLuongDoAnTotNghiepChiTietProvider.GetByNamHocHocKyDot(sp2465_NamHoc, sp2465_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod.Get || SelectMethod == KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod.GetById )
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
				KcqKhoiLuongDoAnTotNghiepChiTiet entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqKhoiLuongDoAnTotNghiepChiTietProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqKhoiLuongDoAnTotNghiepChiTiet> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqKhoiLuongDoAnTotNghiepChiTietProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqKhoiLuongDoAnTotNghiepChiTietDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqKhoiLuongDoAnTotNghiepChiTietDataSource class.
	/// </summary>
	public class KcqKhoiLuongDoAnTotNghiepChiTietDataSourceDesigner : ProviderDataSourceDesigner<KcqKhoiLuongDoAnTotNghiepChiTiet, KcqKhoiLuongDoAnTotNghiepChiTietKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietDataSourceDesigner class.
		/// </summary>
		public KcqKhoiLuongDoAnTotNghiepChiTietDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod SelectMethod
		{
			get { return ((KcqKhoiLuongDoAnTotNghiepChiTietDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqKhoiLuongDoAnTotNghiepChiTietDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqKhoiLuongDoAnTotNghiepChiTietDataSourceActionList

	/// <summary>
	/// Supports the KcqKhoiLuongDoAnTotNghiepChiTietDataSourceDesigner class.
	/// </summary>
	internal class KcqKhoiLuongDoAnTotNghiepChiTietDataSourceActionList : DesignerActionList
	{
		private KcqKhoiLuongDoAnTotNghiepChiTietDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqKhoiLuongDoAnTotNghiepChiTietDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqKhoiLuongDoAnTotNghiepChiTietDataSourceActionList(KcqKhoiLuongDoAnTotNghiepChiTietDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod SelectMethod
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

	#endregion KcqKhoiLuongDoAnTotNghiepChiTietDataSourceActionList
	
	#endregion KcqKhoiLuongDoAnTotNghiepChiTietDataSourceDesigner
	
	#region KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqKhoiLuongDoAnTotNghiepChiTietDataSource.SelectMethod property.
	/// </summary>
	public enum KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod
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
		/// Represents the GetByNamHocHocKyDot method.
		/// </summary>
		GetByNamHocHocKyDot
	}
	
	#endregion KcqKhoiLuongDoAnTotNghiepChiTietSelectMethod

	#region KcqKhoiLuongDoAnTotNghiepChiTietFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongDoAnTotNghiepChiTietFilter : SqlFilter<KcqKhoiLuongDoAnTotNghiepChiTietColumn>
	{
	}
	
	#endregion KcqKhoiLuongDoAnTotNghiepChiTietFilter

	#region KcqKhoiLuongDoAnTotNghiepChiTietExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongDoAnTotNghiepChiTietExpressionBuilder : SqlExpressionBuilder<KcqKhoiLuongDoAnTotNghiepChiTietColumn>
	{
	}
	
	#endregion KcqKhoiLuongDoAnTotNghiepChiTietExpressionBuilder	

	#region KcqKhoiLuongDoAnTotNghiepChiTietProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqKhoiLuongDoAnTotNghiepChiTietChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoiLuongDoAnTotNghiepChiTiet"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoiLuongDoAnTotNghiepChiTietProperty : ChildEntityProperty<KcqKhoiLuongDoAnTotNghiepChiTietChildEntityTypes>
	{
	}
	
	#endregion KcqKhoiLuongDoAnTotNghiepChiTietProperty
}

