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
	/// Represents the DataRepository.GiangVienKhongTinhGioGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienKhongTinhGioGiangDataSourceDesigner))]
	public class GiangVienKhongTinhGioGiangDataSource : ProviderDataSource<GiangVienKhongTinhGioGiang, GiangVienKhongTinhGioGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienKhongTinhGioGiangDataSource class.
		/// </summary>
		public GiangVienKhongTinhGioGiangDataSource() : base(new GiangVienKhongTinhGioGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienKhongTinhGioGiangDataSourceView used by the GiangVienKhongTinhGioGiangDataSource.
		/// </summary>
		protected GiangVienKhongTinhGioGiangDataSourceView GiangVienKhongTinhGioGiangView
		{
			get { return ( View as GiangVienKhongTinhGioGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienKhongTinhGioGiangDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienKhongTinhGioGiangSelectMethod SelectMethod
		{
			get
			{
				GiangVienKhongTinhGioGiangSelectMethod selectMethod = GiangVienKhongTinhGioGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienKhongTinhGioGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienKhongTinhGioGiangDataSourceView class that is to be
		/// used by the GiangVienKhongTinhGioGiangDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienKhongTinhGioGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienKhongTinhGioGiang, GiangVienKhongTinhGioGiangKey> GetNewDataSourceView()
		{
			return new GiangVienKhongTinhGioGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienKhongTinhGioGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienKhongTinhGioGiangDataSourceView : ProviderDataSourceView<GiangVienKhongTinhGioGiang, GiangVienKhongTinhGioGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienKhongTinhGioGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienKhongTinhGioGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienKhongTinhGioGiangDataSourceView(GiangVienKhongTinhGioGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienKhongTinhGioGiangDataSource GiangVienKhongTinhGioGiangOwner
		{
			get { return Owner as GiangVienKhongTinhGioGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienKhongTinhGioGiangSelectMethod SelectMethod
		{
			get { return GiangVienKhongTinhGioGiangOwner.SelectMethod; }
			set { GiangVienKhongTinhGioGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienKhongTinhGioGiangService GiangVienKhongTinhGioGiangProvider
		{
			get { return Provider as GiangVienKhongTinhGioGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienKhongTinhGioGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienKhongTinhGioGiang> results = null;
			GiangVienKhongTinhGioGiang item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case GiangVienKhongTinhGioGiangSelectMethod.Get:
					GiangVienKhongTinhGioGiangKey entityKey  = new GiangVienKhongTinhGioGiangKey();
					entityKey.Load(values);
					item = GiangVienKhongTinhGioGiangProvider.Get(entityKey);
					results = new TList<GiangVienKhongTinhGioGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienKhongTinhGioGiangSelectMethod.GetAll:
                    results = GiangVienKhongTinhGioGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienKhongTinhGioGiangSelectMethod.GetPaged:
					results = GiangVienKhongTinhGioGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienKhongTinhGioGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienKhongTinhGioGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienKhongTinhGioGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienKhongTinhGioGiangSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienKhongTinhGioGiangProvider.GetById(_id);
					results = new TList<GiangVienKhongTinhGioGiang>();
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
			if ( SelectMethod == GiangVienKhongTinhGioGiangSelectMethod.Get || SelectMethod == GiangVienKhongTinhGioGiangSelectMethod.GetById )
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
				GiangVienKhongTinhGioGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienKhongTinhGioGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienKhongTinhGioGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienKhongTinhGioGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienKhongTinhGioGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienKhongTinhGioGiangDataSource class.
	/// </summary>
	public class GiangVienKhongTinhGioGiangDataSourceDesigner : ProviderDataSourceDesigner<GiangVienKhongTinhGioGiang, GiangVienKhongTinhGioGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienKhongTinhGioGiangDataSourceDesigner class.
		/// </summary>
		public GiangVienKhongTinhGioGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienKhongTinhGioGiangSelectMethod SelectMethod
		{
			get { return ((GiangVienKhongTinhGioGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienKhongTinhGioGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienKhongTinhGioGiangDataSourceActionList

	/// <summary>
	/// Supports the GiangVienKhongTinhGioGiangDataSourceDesigner class.
	/// </summary>
	internal class GiangVienKhongTinhGioGiangDataSourceActionList : DesignerActionList
	{
		private GiangVienKhongTinhGioGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienKhongTinhGioGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienKhongTinhGioGiangDataSourceActionList(GiangVienKhongTinhGioGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienKhongTinhGioGiangSelectMethod SelectMethod
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

	#endregion GiangVienKhongTinhGioGiangDataSourceActionList
	
	#endregion GiangVienKhongTinhGioGiangDataSourceDesigner
	
	#region GiangVienKhongTinhGioGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienKhongTinhGioGiangDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienKhongTinhGioGiangSelectMethod
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
	
	#endregion GiangVienKhongTinhGioGiangSelectMethod

	#region GiangVienKhongTinhGioGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienKhongTinhGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienKhongTinhGioGiangFilter : SqlFilter<GiangVienKhongTinhGioGiangColumn>
	{
	}
	
	#endregion GiangVienKhongTinhGioGiangFilter

	#region GiangVienKhongTinhGioGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienKhongTinhGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienKhongTinhGioGiangExpressionBuilder : SqlExpressionBuilder<GiangVienKhongTinhGioGiangColumn>
	{
	}
	
	#endregion GiangVienKhongTinhGioGiangExpressionBuilder	

	#region GiangVienKhongTinhGioGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienKhongTinhGioGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienKhongTinhGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienKhongTinhGioGiangProperty : ChildEntityProperty<GiangVienKhongTinhGioGiangChildEntityTypes>
	{
	}
	
	#endregion GiangVienKhongTinhGioGiangProperty
}

