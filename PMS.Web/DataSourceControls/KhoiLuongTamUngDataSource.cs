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
	/// Represents the DataRepository.KhoiLuongTamUngProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongTamUngDataSourceDesigner))]
	public class KhoiLuongTamUngDataSource : ProviderDataSource<KhoiLuongTamUng, KhoiLuongTamUngKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngDataSource class.
		/// </summary>
		public KhoiLuongTamUngDataSource() : base(new KhoiLuongTamUngService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongTamUngDataSourceView used by the KhoiLuongTamUngDataSource.
		/// </summary>
		protected KhoiLuongTamUngDataSourceView KhoiLuongTamUngView
		{
			get { return ( View as KhoiLuongTamUngDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongTamUngDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongTamUngSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongTamUngSelectMethod selectMethod = KhoiLuongTamUngSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongTamUngSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongTamUngDataSourceView class that is to be
		/// used by the KhoiLuongTamUngDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongTamUngDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongTamUng, KhoiLuongTamUngKey> GetNewDataSourceView()
		{
			return new KhoiLuongTamUngDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongTamUngDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongTamUngDataSourceView : ProviderDataSourceView<KhoiLuongTamUng, KhoiLuongTamUngKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongTamUngDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongTamUngDataSourceView(KhoiLuongTamUngDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongTamUngDataSource KhoiLuongTamUngOwner
		{
			get { return Owner as KhoiLuongTamUngDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongTamUngSelectMethod SelectMethod
		{
			get { return KhoiLuongTamUngOwner.SelectMethod; }
			set { KhoiLuongTamUngOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongTamUngService KhoiLuongTamUngProvider
		{
			get { return Provider as KhoiLuongTamUngService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongTamUng> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongTamUng> results = null;
			KhoiLuongTamUng item;
			count = 0;
			
			System.Int32 _maKhoiLuong;
			System.String sp639_NamHoc;
			System.String sp639_HocKy;

			switch ( SelectMethod )
			{
				case KhoiLuongTamUngSelectMethod.Get:
					KhoiLuongTamUngKey entityKey  = new KhoiLuongTamUngKey();
					entityKey.Load(values);
					item = KhoiLuongTamUngProvider.Get(entityKey);
					results = new TList<KhoiLuongTamUng>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongTamUngSelectMethod.GetAll:
                    results = KhoiLuongTamUngProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongTamUngSelectMethod.GetPaged:
					results = KhoiLuongTamUngProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongTamUngSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongTamUngProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongTamUngProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongTamUngSelectMethod.GetByMaKhoiLuong:
					_maKhoiLuong = ( values["MaKhoiLuong"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuong"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongTamUngProvider.GetByMaKhoiLuong(_maKhoiLuong);
					results = new TList<KhoiLuongTamUng>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case KhoiLuongTamUngSelectMethod.GetListByNamHocHocKy:
					sp639_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp639_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = KhoiLuongTamUngProvider.GetListByNamHocHocKy(sp639_NamHoc, sp639_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == KhoiLuongTamUngSelectMethod.Get || SelectMethod == KhoiLuongTamUngSelectMethod.GetByMaKhoiLuong )
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
				KhoiLuongTamUng entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongTamUngProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongTamUng> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongTamUngProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongTamUngDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongTamUngDataSource class.
	/// </summary>
	public class KhoiLuongTamUngDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongTamUng, KhoiLuongTamUngKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngDataSourceDesigner class.
		/// </summary>
		public KhoiLuongTamUngDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongTamUngSelectMethod SelectMethod
		{
			get { return ((KhoiLuongTamUngDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongTamUngDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongTamUngDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongTamUngDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongTamUngDataSourceActionList : DesignerActionList
	{
		private KhoiLuongTamUngDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongTamUngDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongTamUngDataSourceActionList(KhoiLuongTamUngDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongTamUngSelectMethod SelectMethod
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

	#endregion KhoiLuongTamUngDataSourceActionList
	
	#endregion KhoiLuongTamUngDataSourceDesigner
	
	#region KhoiLuongTamUngSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongTamUngDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongTamUngSelectMethod
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
		/// Represents the GetByMaKhoiLuong method.
		/// </summary>
		GetByMaKhoiLuong,
		/// <summary>
		/// Represents the GetListByNamHocHocKy method.
		/// </summary>
		GetListByNamHocHocKy
	}
	
	#endregion KhoiLuongTamUngSelectMethod

	#region KhoiLuongTamUngFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongTamUngFilter : SqlFilter<KhoiLuongTamUngColumn>
	{
	}
	
	#endregion KhoiLuongTamUngFilter

	#region KhoiLuongTamUngExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongTamUngExpressionBuilder : SqlExpressionBuilder<KhoiLuongTamUngColumn>
	{
	}
	
	#endregion KhoiLuongTamUngExpressionBuilder	

	#region KhoiLuongTamUngProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongTamUngChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongTamUng"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongTamUngProperty : ChildEntityProperty<KhoiLuongTamUngChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongTamUngProperty
}

