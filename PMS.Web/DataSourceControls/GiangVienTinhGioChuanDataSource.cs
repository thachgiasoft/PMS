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
	/// Represents the DataRepository.GiangVienTinhGioChuanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienTinhGioChuanDataSourceDesigner))]
	public class GiangVienTinhGioChuanDataSource : ProviderDataSource<GiangVienTinhGioChuan, GiangVienTinhGioChuanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTinhGioChuanDataSource class.
		/// </summary>
		public GiangVienTinhGioChuanDataSource() : base(new GiangVienTinhGioChuanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienTinhGioChuanDataSourceView used by the GiangVienTinhGioChuanDataSource.
		/// </summary>
		protected GiangVienTinhGioChuanDataSourceView GiangVienTinhGioChuanView
		{
			get { return ( View as GiangVienTinhGioChuanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienTinhGioChuanDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienTinhGioChuanSelectMethod SelectMethod
		{
			get
			{
				GiangVienTinhGioChuanSelectMethod selectMethod = GiangVienTinhGioChuanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienTinhGioChuanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienTinhGioChuanDataSourceView class that is to be
		/// used by the GiangVienTinhGioChuanDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienTinhGioChuanDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienTinhGioChuan, GiangVienTinhGioChuanKey> GetNewDataSourceView()
		{
			return new GiangVienTinhGioChuanDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienTinhGioChuanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienTinhGioChuanDataSourceView : ProviderDataSourceView<GiangVienTinhGioChuan, GiangVienTinhGioChuanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienTinhGioChuanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienTinhGioChuanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienTinhGioChuanDataSourceView(GiangVienTinhGioChuanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienTinhGioChuanDataSource GiangVienTinhGioChuanOwner
		{
			get { return Owner as GiangVienTinhGioChuanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienTinhGioChuanSelectMethod SelectMethod
		{
			get { return GiangVienTinhGioChuanOwner.SelectMethod; }
			set { GiangVienTinhGioChuanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienTinhGioChuanService GiangVienTinhGioChuanProvider
		{
			get { return Provider as GiangVienTinhGioChuanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienTinhGioChuan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienTinhGioChuan> results = null;
			GiangVienTinhGioChuan item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case GiangVienTinhGioChuanSelectMethod.Get:
					GiangVienTinhGioChuanKey entityKey  = new GiangVienTinhGioChuanKey();
					entityKey.Load(values);
					item = GiangVienTinhGioChuanProvider.Get(entityKey);
					results = new TList<GiangVienTinhGioChuan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienTinhGioChuanSelectMethod.GetAll:
                    results = GiangVienTinhGioChuanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienTinhGioChuanSelectMethod.GetPaged:
					results = GiangVienTinhGioChuanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienTinhGioChuanSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienTinhGioChuanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienTinhGioChuanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienTinhGioChuanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienTinhGioChuanProvider.GetById(_id);
					results = new TList<GiangVienTinhGioChuan>();
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
			if ( SelectMethod == GiangVienTinhGioChuanSelectMethod.Get || SelectMethod == GiangVienTinhGioChuanSelectMethod.GetById )
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
				GiangVienTinhGioChuan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienTinhGioChuanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienTinhGioChuan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienTinhGioChuanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienTinhGioChuanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienTinhGioChuanDataSource class.
	/// </summary>
	public class GiangVienTinhGioChuanDataSourceDesigner : ProviderDataSourceDesigner<GiangVienTinhGioChuan, GiangVienTinhGioChuanKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienTinhGioChuanDataSourceDesigner class.
		/// </summary>
		public GiangVienTinhGioChuanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienTinhGioChuanSelectMethod SelectMethod
		{
			get { return ((GiangVienTinhGioChuanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienTinhGioChuanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienTinhGioChuanDataSourceActionList

	/// <summary>
	/// Supports the GiangVienTinhGioChuanDataSourceDesigner class.
	/// </summary>
	internal class GiangVienTinhGioChuanDataSourceActionList : DesignerActionList
	{
		private GiangVienTinhGioChuanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienTinhGioChuanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienTinhGioChuanDataSourceActionList(GiangVienTinhGioChuanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienTinhGioChuanSelectMethod SelectMethod
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

	#endregion GiangVienTinhGioChuanDataSourceActionList
	
	#endregion GiangVienTinhGioChuanDataSourceDesigner
	
	#region GiangVienTinhGioChuanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienTinhGioChuanDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienTinhGioChuanSelectMethod
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
	
	#endregion GiangVienTinhGioChuanSelectMethod

	#region GiangVienTinhGioChuanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTinhGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTinhGioChuanFilter : SqlFilter<GiangVienTinhGioChuanColumn>
	{
	}
	
	#endregion GiangVienTinhGioChuanFilter

	#region GiangVienTinhGioChuanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTinhGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTinhGioChuanExpressionBuilder : SqlExpressionBuilder<GiangVienTinhGioChuanColumn>
	{
	}
	
	#endregion GiangVienTinhGioChuanExpressionBuilder	

	#region GiangVienTinhGioChuanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienTinhGioChuanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienTinhGioChuan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienTinhGioChuanProperty : ChildEntityProperty<GiangVienTinhGioChuanChildEntityTypes>
	{
	}
	
	#endregion GiangVienTinhGioChuanProperty
}

