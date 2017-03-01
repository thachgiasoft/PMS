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
	/// Represents the DataRepository.GiamTruGioChuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiamTruGioChuanDataSourceDesigner))]
	public class GiamTruGioChuanDataSource : ProviderDataSource<GiamTruGioChuan, GiamTruGioChuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanDataSource class.
		/// </summary>
		public GiamTruGioChuanDataSource() : base(new GiamTruGioChuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiamTruGioChuanDataSourceView used by the GiamTruGioChuanDataSource.
		/// </summary>
		protected GiamTruGioChuanDataSourceView GiamTruGioChuanView
		{
			get { return ( View as GiamTruGioChuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiamTruGioChuanDataSource control invokes to retrieve data.
		/// </summary>
		public GiamTruGioChuanSelectMethod SelectMethod
		{
			get
			{
				GiamTruGioChuanSelectMethod selectMethod = GiamTruGioChuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiamTruGioChuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiamTruGioChuanDataSourceView class that is to be
		/// used by the GiamTruGioChuanDataSource.
		/// </summary>
		/// <returns>An instance of the GiamTruGioChuanDataSourceView class.</returns>
		protected override BaseDataSourceView<GiamTruGioChuan, GiamTruGioChuanKey> GetNewDataSourceView()
		{
			return new GiamTruGioChuanDataSourceView(this, DefaultViewName);
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
	/// Supports the GiamTruGioChuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiamTruGioChuanDataSourceView : ProviderDataSourceView<GiamTruGioChuan, GiamTruGioChuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiamTruGioChuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiamTruGioChuanDataSourceView(GiamTruGioChuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiamTruGioChuanDataSource GiamTruGioChuanOwner
		{
			get { return Owner as GiamTruGioChuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiamTruGioChuanSelectMethod SelectMethod
		{
			get { return GiamTruGioChuanOwner.SelectMethod; }
			set { GiamTruGioChuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiamTruGioChuanService GiamTruGioChuanProvider
		{
			get { return Provider as GiamTruGioChuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiamTruGioChuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiamTruGioChuan> results = null;
			GiamTruGioChuan item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case GiamTruGioChuanSelectMethod.Get:
					GiamTruGioChuanKey entityKey  = new GiamTruGioChuanKey();
					entityKey.Load(values);
					item = GiamTruGioChuanProvider.Get(entityKey);
					results = new TList<GiamTruGioChuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiamTruGioChuanSelectMethod.GetAll:
                    results = GiamTruGioChuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiamTruGioChuanSelectMethod.GetPaged:
					results = GiamTruGioChuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiamTruGioChuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiamTruGioChuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiamTruGioChuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiamTruGioChuanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiamTruGioChuanProvider.GetById(_id);
					results = new TList<GiamTruGioChuan>();
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
			if ( SelectMethod == GiamTruGioChuanSelectMethod.Get || SelectMethod == GiamTruGioChuanSelectMethod.GetById )
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
				GiamTruGioChuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiamTruGioChuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiamTruGioChuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiamTruGioChuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiamTruGioChuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiamTruGioChuanDataSource class.
	/// </summary>
	public class GiamTruGioChuanDataSourceDesigner : ProviderDataSourceDesigner<GiamTruGioChuan, GiamTruGioChuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanDataSourceDesigner class.
		/// </summary>
		public GiamTruGioChuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiamTruGioChuanSelectMethod SelectMethod
		{
			get { return ((GiamTruGioChuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiamTruGioChuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiamTruGioChuanDataSourceActionList

	/// <summary>
	/// Supports the GiamTruGioChuanDataSourceDesigner class.
	/// </summary>
	internal class GiamTruGioChuanDataSourceActionList : DesignerActionList
	{
		private GiamTruGioChuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiamTruGioChuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiamTruGioChuanDataSourceActionList(GiamTruGioChuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiamTruGioChuanSelectMethod SelectMethod
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

	#endregion GiamTruGioChuanDataSourceActionList
	
	#endregion GiamTruGioChuanDataSourceDesigner
	
	#region GiamTruGioChuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiamTruGioChuanDataSource.SelectMethod property.
	/// </summary>
	public enum GiamTruGioChuanSelectMethod
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
		GetById
	}
	
	#endregion GiamTruGioChuanSelectMethod

	#region GiamTruGioChuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiamTruGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiamTruGioChuanFilter : SqlFilter<GiamTruGioChuanColumn>
	{
	}
	
	#endregion GiamTruGioChuanFilter

	#region GiamTruGioChuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiamTruGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiamTruGioChuanExpressionBuilder : SqlExpressionBuilder<GiamTruGioChuanColumn>
	{
	}
	
	#endregion GiamTruGioChuanExpressionBuilder	

	#region GiamTruGioChuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiamTruGioChuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiamTruGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiamTruGioChuanProperty : ChildEntityProperty<GiamTruGioChuanChildEntityTypes>
	{
	}
	
	#endregion GiamTruGioChuanProperty
}

