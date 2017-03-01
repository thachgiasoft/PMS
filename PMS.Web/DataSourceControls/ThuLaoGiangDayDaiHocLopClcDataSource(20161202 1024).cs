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
	/// Represents the DataRepository.ThuLaoGiangDayDaiHocLopClcProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(ThuLaoGiangDayDaiHocLopClcDataSourceDesigner))]
	public class ThuLaoGiangDayDaiHocLopClcDataSource : ProviderDataSource<ThuLaoGiangDayDaiHocLopClc, ThuLaoGiangDayDaiHocLopClcKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayDaiHocLopClcDataSource class.
		/// </summary>
		public ThuLaoGiangDayDaiHocLopClcDataSource() : base(new ThuLaoGiangDayDaiHocLopClcService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the ThuLaoGiangDayDaiHocLopClcDataSourceView used by the ThuLaoGiangDayDaiHocLopClcDataSource.
		/// </summary>
		protected ThuLaoGiangDayDaiHocLopClcDataSourceView ThuLaoGiangDayDaiHocLopClcView
		{
			get { return ( View as ThuLaoGiangDayDaiHocLopClcDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the ThuLaoGiangDayDaiHocLopClcDataSource control invokes to retrieve data.
		/// </summary>
		public ThuLaoGiangDayDaiHocLopClcSelectMethod SelectMethod
		{
			get
			{
				ThuLaoGiangDayDaiHocLopClcSelectMethod selectMethod = ThuLaoGiangDayDaiHocLopClcSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (ThuLaoGiangDayDaiHocLopClcSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the ThuLaoGiangDayDaiHocLopClcDataSourceView class that is to be
		/// used by the ThuLaoGiangDayDaiHocLopClcDataSource.
		/// </summary>
		/// <returns>An instance of the ThuLaoGiangDayDaiHocLopClcDataSourceView class.</returns>
		protected override BaseDataSourceView<ThuLaoGiangDayDaiHocLopClc, ThuLaoGiangDayDaiHocLopClcKey> GetNewDataSourceView()
		{
			return new ThuLaoGiangDayDaiHocLopClcDataSourceView(this, DefaultViewName);
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
	/// Supports the ThuLaoGiangDayDaiHocLopClcDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class ThuLaoGiangDayDaiHocLopClcDataSourceView : ProviderDataSourceView<ThuLaoGiangDayDaiHocLopClc, ThuLaoGiangDayDaiHocLopClcKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayDaiHocLopClcDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the ThuLaoGiangDayDaiHocLopClcDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public ThuLaoGiangDayDaiHocLopClcDataSourceView(ThuLaoGiangDayDaiHocLopClcDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal ThuLaoGiangDayDaiHocLopClcDataSource ThuLaoGiangDayDaiHocLopClcOwner
		{
			get { return Owner as ThuLaoGiangDayDaiHocLopClcDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal ThuLaoGiangDayDaiHocLopClcSelectMethod SelectMethod
		{
			get { return ThuLaoGiangDayDaiHocLopClcOwner.SelectMethod; }
			set { ThuLaoGiangDayDaiHocLopClcOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal ThuLaoGiangDayDaiHocLopClcService ThuLaoGiangDayDaiHocLopClcProvider
		{
			get { return Provider as ThuLaoGiangDayDaiHocLopClcService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<ThuLaoGiangDayDaiHocLopClc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<ThuLaoGiangDayDaiHocLopClc> results = null;
			ThuLaoGiangDayDaiHocLopClc item;
			count = 0;
			
			System.Int32 _id;
			System.String sp2947_NamHoc;
			System.String sp2947_HocKy;

			switch ( SelectMethod )
			{
				case ThuLaoGiangDayDaiHocLopClcSelectMethod.Get:
					ThuLaoGiangDayDaiHocLopClcKey entityKey  = new ThuLaoGiangDayDaiHocLopClcKey();
					entityKey.Load(values);
					item = ThuLaoGiangDayDaiHocLopClcProvider.Get(entityKey);
					results = new TList<ThuLaoGiangDayDaiHocLopClc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case ThuLaoGiangDayDaiHocLopClcSelectMethod.GetAll:
                    results = ThuLaoGiangDayDaiHocLopClcProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case ThuLaoGiangDayDaiHocLopClcSelectMethod.GetPaged:
					results = ThuLaoGiangDayDaiHocLopClcProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case ThuLaoGiangDayDaiHocLopClcSelectMethod.Find:
					if ( FilterParameters != null )
						results = ThuLaoGiangDayDaiHocLopClcProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = ThuLaoGiangDayDaiHocLopClcProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case ThuLaoGiangDayDaiHocLopClcSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = ThuLaoGiangDayDaiHocLopClcProvider.GetById(_id);
					results = new TList<ThuLaoGiangDayDaiHocLopClc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				// M:M
				// Custom
				case ThuLaoGiangDayDaiHocLopClcSelectMethod.GetByNamHocHocKy:
					sp2947_NamHoc = (System.String) EntityUtil.ChangeType(values["NamHoc"], typeof(System.String));
					sp2947_HocKy = (System.String) EntityUtil.ChangeType(values["HocKy"], typeof(System.String));
					results = ThuLaoGiangDayDaiHocLopClcProvider.GetByNamHocHocKy(sp2947_NamHoc, sp2947_HocKy, StartIndex, PageSize);
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
			if ( SelectMethod == ThuLaoGiangDayDaiHocLopClcSelectMethod.Get || SelectMethod == ThuLaoGiangDayDaiHocLopClcSelectMethod.GetById )
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
				ThuLaoGiangDayDaiHocLopClc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					ThuLaoGiangDayDaiHocLopClcProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<ThuLaoGiangDayDaiHocLopClc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			ThuLaoGiangDayDaiHocLopClcProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region ThuLaoGiangDayDaiHocLopClcDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the ThuLaoGiangDayDaiHocLopClcDataSource class.
	/// </summary>
	public class ThuLaoGiangDayDaiHocLopClcDataSourceDesigner : ProviderDataSourceDesigner<ThuLaoGiangDayDaiHocLopClc, ThuLaoGiangDayDaiHocLopClcKey>
	{
		/// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayDaiHocLopClcDataSourceDesigner class.
		/// </summary>
		public ThuLaoGiangDayDaiHocLopClcDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoGiangDayDaiHocLopClcSelectMethod SelectMethod
		{
			get { return ((ThuLaoGiangDayDaiHocLopClcDataSource) DataSource).SelectMethod; }
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
				actions.Add(new ThuLaoGiangDayDaiHocLopClcDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region ThuLaoGiangDayDaiHocLopClcDataSourceActionList

	/// <summary>
	/// Supports the ThuLaoGiangDayDaiHocLopClcDataSourceDesigner class.
	/// </summary>
	internal class ThuLaoGiangDayDaiHocLopClcDataSourceActionList : DesignerActionList
	{
		private ThuLaoGiangDayDaiHocLopClcDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the ThuLaoGiangDayDaiHocLopClcDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public ThuLaoGiangDayDaiHocLopClcDataSourceActionList(ThuLaoGiangDayDaiHocLopClcDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public ThuLaoGiangDayDaiHocLopClcSelectMethod SelectMethod
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

	#endregion ThuLaoGiangDayDaiHocLopClcDataSourceActionList
	
	#endregion ThuLaoGiangDayDaiHocLopClcDataSourceDesigner
	
	#region ThuLaoGiangDayDaiHocLopClcSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the ThuLaoGiangDayDaiHocLopClcDataSource.SelectMethod property.
	/// </summary>
	public enum ThuLaoGiangDayDaiHocLopClcSelectMethod
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
	
	#endregion ThuLaoGiangDayDaiHocLopClcSelectMethod

	#region ThuLaoGiangDayDaiHocLopClcFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoGiangDayDaiHocLopClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoGiangDayDaiHocLopClcFilter : SqlFilter<ThuLaoGiangDayDaiHocLopClcColumn>
	{
	}
	
	#endregion ThuLaoGiangDayDaiHocLopClcFilter

	#region ThuLaoGiangDayDaiHocLopClcExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoGiangDayDaiHocLopClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoGiangDayDaiHocLopClcExpressionBuilder : SqlExpressionBuilder<ThuLaoGiangDayDaiHocLopClcColumn>
	{
	}
	
	#endregion ThuLaoGiangDayDaiHocLopClcExpressionBuilder	

	#region ThuLaoGiangDayDaiHocLopClcProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;ThuLaoGiangDayDaiHocLopClcChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="ThuLaoGiangDayDaiHocLopClc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class ThuLaoGiangDayDaiHocLopClcProperty : ChildEntityProperty<ThuLaoGiangDayDaiHocLopClcChildEntityTypes>
	{
	}
	
	#endregion ThuLaoGiangDayDaiHocLopClcProperty
}

