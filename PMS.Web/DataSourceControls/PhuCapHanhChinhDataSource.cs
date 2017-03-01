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
	/// Represents the DataRepository.PhuCapHanhChinhProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(PhuCapHanhChinhDataSourceDesigner))]
	public class PhuCapHanhChinhDataSource : ProviderDataSource<PhuCapHanhChinh, PhuCapHanhChinhKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhuCapHanhChinhDataSource class.
		/// </summary>
		public PhuCapHanhChinhDataSource() : base(new PhuCapHanhChinhService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the PhuCapHanhChinhDataSourceView used by the PhuCapHanhChinhDataSource.
		/// </summary>
		protected PhuCapHanhChinhDataSourceView PhuCapHanhChinhView
		{
			get { return ( View as PhuCapHanhChinhDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the PhuCapHanhChinhDataSource control invokes to retrieve data.
		/// </summary>
		public PhuCapHanhChinhSelectMethod SelectMethod
		{
			get
			{
				PhuCapHanhChinhSelectMethod selectMethod = PhuCapHanhChinhSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (PhuCapHanhChinhSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the PhuCapHanhChinhDataSourceView class that is to be
		/// used by the PhuCapHanhChinhDataSource.
		/// </summary>
		/// <returns>An instance of the PhuCapHanhChinhDataSourceView class.</returns>
		protected override BaseDataSourceView<PhuCapHanhChinh, PhuCapHanhChinhKey> GetNewDataSourceView()
		{
			return new PhuCapHanhChinhDataSourceView(this, DefaultViewName);
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
	/// Supports the PhuCapHanhChinhDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class PhuCapHanhChinhDataSourceView : ProviderDataSourceView<PhuCapHanhChinh, PhuCapHanhChinhKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhuCapHanhChinhDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the PhuCapHanhChinhDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public PhuCapHanhChinhDataSourceView(PhuCapHanhChinhDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal PhuCapHanhChinhDataSource PhuCapHanhChinhOwner
		{
			get { return Owner as PhuCapHanhChinhDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal PhuCapHanhChinhSelectMethod SelectMethod
		{
			get { return PhuCapHanhChinhOwner.SelectMethod; }
			set { PhuCapHanhChinhOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal PhuCapHanhChinhService PhuCapHanhChinhProvider
		{
			get { return Provider as PhuCapHanhChinhService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<PhuCapHanhChinh> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<PhuCapHanhChinh> results = null;
			PhuCapHanhChinh item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case PhuCapHanhChinhSelectMethod.Get:
					PhuCapHanhChinhKey entityKey  = new PhuCapHanhChinhKey();
					entityKey.Load(values);
					item = PhuCapHanhChinhProvider.Get(entityKey);
					results = new TList<PhuCapHanhChinh>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case PhuCapHanhChinhSelectMethod.GetAll:
                    results = PhuCapHanhChinhProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case PhuCapHanhChinhSelectMethod.GetPaged:
					results = PhuCapHanhChinhProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case PhuCapHanhChinhSelectMethod.Find:
					if ( FilterParameters != null )
						results = PhuCapHanhChinhProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = PhuCapHanhChinhProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case PhuCapHanhChinhSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = PhuCapHanhChinhProvider.GetById(_id);
					results = new TList<PhuCapHanhChinh>();
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
			if ( SelectMethod == PhuCapHanhChinhSelectMethod.Get || SelectMethod == PhuCapHanhChinhSelectMethod.GetById )
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
				PhuCapHanhChinh entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					PhuCapHanhChinhProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<PhuCapHanhChinh> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			PhuCapHanhChinhProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region PhuCapHanhChinhDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the PhuCapHanhChinhDataSource class.
	/// </summary>
	public class PhuCapHanhChinhDataSourceDesigner : ProviderDataSourceDesigner<PhuCapHanhChinh, PhuCapHanhChinhKey>
	{
		/// <summary>
		/// Initializes a new instance of the PhuCapHanhChinhDataSourceDesigner class.
		/// </summary>
		public PhuCapHanhChinhDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhuCapHanhChinhSelectMethod SelectMethod
		{
			get { return ((PhuCapHanhChinhDataSource) DataSource).SelectMethod; }
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
				actions.Add(new PhuCapHanhChinhDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region PhuCapHanhChinhDataSourceActionList

	/// <summary>
	/// Supports the PhuCapHanhChinhDataSourceDesigner class.
	/// </summary>
	internal class PhuCapHanhChinhDataSourceActionList : DesignerActionList
	{
		private PhuCapHanhChinhDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the PhuCapHanhChinhDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public PhuCapHanhChinhDataSourceActionList(PhuCapHanhChinhDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhuCapHanhChinhSelectMethod SelectMethod
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

	#endregion PhuCapHanhChinhDataSourceActionList
	
	#endregion PhuCapHanhChinhDataSourceDesigner
	
	#region PhuCapHanhChinhSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the PhuCapHanhChinhDataSource.SelectMethod property.
	/// </summary>
	public enum PhuCapHanhChinhSelectMethod
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
	
	#endregion PhuCapHanhChinhSelectMethod

	#region PhuCapHanhChinhFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhuCapHanhChinhFilter : SqlFilter<PhuCapHanhChinhColumn>
	{
	}
	
	#endregion PhuCapHanhChinhFilter

	#region PhuCapHanhChinhExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhuCapHanhChinhExpressionBuilder : SqlExpressionBuilder<PhuCapHanhChinhColumn>
	{
	}
	
	#endregion PhuCapHanhChinhExpressionBuilder	

	#region PhuCapHanhChinhProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;PhuCapHanhChinhChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="PhuCapHanhChinh"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhuCapHanhChinhProperty : ChildEntityProperty<PhuCapHanhChinhChildEntityTypes>
	{
	}
	
	#endregion PhuCapHanhChinhProperty
}

