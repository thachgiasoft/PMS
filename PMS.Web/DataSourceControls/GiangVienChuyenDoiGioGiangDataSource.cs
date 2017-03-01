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
	/// Represents the DataRepository.GiangVienChuyenDoiGioGiangProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(GiangVienChuyenDoiGioGiangDataSourceDesigner))]
	public class GiangVienChuyenDoiGioGiangDataSource : ProviderDataSource<GiangVienChuyenDoiGioGiang, GiangVienChuyenDoiGioGiangKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenDoiGioGiangDataSource class.
		/// </summary>
		public GiangVienChuyenDoiGioGiangDataSource() : base(new GiangVienChuyenDoiGioGiangService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the GiangVienChuyenDoiGioGiangDataSourceView used by the GiangVienChuyenDoiGioGiangDataSource.
		/// </summary>
		protected GiangVienChuyenDoiGioGiangDataSourceView GiangVienChuyenDoiGioGiangView
		{
			get { return ( View as GiangVienChuyenDoiGioGiangDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the GiangVienChuyenDoiGioGiangDataSource control invokes to retrieve data.
		/// </summary>
		public GiangVienChuyenDoiGioGiangSelectMethod SelectMethod
		{
			get
			{
				GiangVienChuyenDoiGioGiangSelectMethod selectMethod = GiangVienChuyenDoiGioGiangSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (GiangVienChuyenDoiGioGiangSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the GiangVienChuyenDoiGioGiangDataSourceView class that is to be
		/// used by the GiangVienChuyenDoiGioGiangDataSource.
		/// </summary>
		/// <returns>An instance of the GiangVienChuyenDoiGioGiangDataSourceView class.</returns>
		protected override BaseDataSourceView<GiangVienChuyenDoiGioGiang, GiangVienChuyenDoiGioGiangKey> GetNewDataSourceView()
		{
			return new GiangVienChuyenDoiGioGiangDataSourceView(this, DefaultViewName);
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
	/// Supports the GiangVienChuyenDoiGioGiangDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class GiangVienChuyenDoiGioGiangDataSourceView : ProviderDataSourceView<GiangVienChuyenDoiGioGiang, GiangVienChuyenDoiGioGiangKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenDoiGioGiangDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the GiangVienChuyenDoiGioGiangDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public GiangVienChuyenDoiGioGiangDataSourceView(GiangVienChuyenDoiGioGiangDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal GiangVienChuyenDoiGioGiangDataSource GiangVienChuyenDoiGioGiangOwner
		{
			get { return Owner as GiangVienChuyenDoiGioGiangDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal GiangVienChuyenDoiGioGiangSelectMethod SelectMethod
		{
			get { return GiangVienChuyenDoiGioGiangOwner.SelectMethod; }
			set { GiangVienChuyenDoiGioGiangOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal GiangVienChuyenDoiGioGiangService GiangVienChuyenDoiGioGiangProvider
		{
			get { return Provider as GiangVienChuyenDoiGioGiangService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<GiangVienChuyenDoiGioGiang> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<GiangVienChuyenDoiGioGiang> results = null;
			GiangVienChuyenDoiGioGiang item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case GiangVienChuyenDoiGioGiangSelectMethod.Get:
					GiangVienChuyenDoiGioGiangKey entityKey  = new GiangVienChuyenDoiGioGiangKey();
					entityKey.Load(values);
					item = GiangVienChuyenDoiGioGiangProvider.Get(entityKey);
					results = new TList<GiangVienChuyenDoiGioGiang>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case GiangVienChuyenDoiGioGiangSelectMethod.GetAll:
                    results = GiangVienChuyenDoiGioGiangProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case GiangVienChuyenDoiGioGiangSelectMethod.GetPaged:
					results = GiangVienChuyenDoiGioGiangProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case GiangVienChuyenDoiGioGiangSelectMethod.Find:
					if ( FilterParameters != null )
						results = GiangVienChuyenDoiGioGiangProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = GiangVienChuyenDoiGioGiangProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case GiangVienChuyenDoiGioGiangSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = GiangVienChuyenDoiGioGiangProvider.GetById(_id);
					results = new TList<GiangVienChuyenDoiGioGiang>();
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
			if ( SelectMethod == GiangVienChuyenDoiGioGiangSelectMethod.Get || SelectMethod == GiangVienChuyenDoiGioGiangSelectMethod.GetById )
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
				GiangVienChuyenDoiGioGiang entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					GiangVienChuyenDoiGioGiangProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<GiangVienChuyenDoiGioGiang> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			GiangVienChuyenDoiGioGiangProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region GiangVienChuyenDoiGioGiangDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the GiangVienChuyenDoiGioGiangDataSource class.
	/// </summary>
	public class GiangVienChuyenDoiGioGiangDataSourceDesigner : ProviderDataSourceDesigner<GiangVienChuyenDoiGioGiang, GiangVienChuyenDoiGioGiangKey>
	{
		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenDoiGioGiangDataSourceDesigner class.
		/// </summary>
		public GiangVienChuyenDoiGioGiangDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienChuyenDoiGioGiangSelectMethod SelectMethod
		{
			get { return ((GiangVienChuyenDoiGioGiangDataSource) DataSource).SelectMethod; }
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
				actions.Add(new GiangVienChuyenDoiGioGiangDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region GiangVienChuyenDoiGioGiangDataSourceActionList

	/// <summary>
	/// Supports the GiangVienChuyenDoiGioGiangDataSourceDesigner class.
	/// </summary>
	internal class GiangVienChuyenDoiGioGiangDataSourceActionList : DesignerActionList
	{
		private GiangVienChuyenDoiGioGiangDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the GiangVienChuyenDoiGioGiangDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public GiangVienChuyenDoiGioGiangDataSourceActionList(GiangVienChuyenDoiGioGiangDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public GiangVienChuyenDoiGioGiangSelectMethod SelectMethod
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

	#endregion GiangVienChuyenDoiGioGiangDataSourceActionList
	
	#endregion GiangVienChuyenDoiGioGiangDataSourceDesigner
	
	#region GiangVienChuyenDoiGioGiangSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the GiangVienChuyenDoiGioGiangDataSource.SelectMethod property.
	/// </summary>
	public enum GiangVienChuyenDoiGioGiangSelectMethod
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
	
	#endregion GiangVienChuyenDoiGioGiangSelectMethod

	#region GiangVienChuyenDoiGioGiangFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChuyenDoiGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChuyenDoiGioGiangFilter : SqlFilter<GiangVienChuyenDoiGioGiangColumn>
	{
	}
	
	#endregion GiangVienChuyenDoiGioGiangFilter

	#region GiangVienChuyenDoiGioGiangExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChuyenDoiGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChuyenDoiGioGiangExpressionBuilder : SqlExpressionBuilder<GiangVienChuyenDoiGioGiangColumn>
	{
	}
	
	#endregion GiangVienChuyenDoiGioGiangExpressionBuilder	

	#region GiangVienChuyenDoiGioGiangProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;GiangVienChuyenDoiGioGiangChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="GiangVienChuyenDoiGioGiang"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class GiangVienChuyenDoiGioGiangProperty : ChildEntityProperty<GiangVienChuyenDoiGioGiangChildEntityTypes>
	{
	}
	
	#endregion GiangVienChuyenDoiGioGiangProperty
}

