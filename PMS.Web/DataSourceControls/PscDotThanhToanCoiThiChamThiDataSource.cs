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
	/// Represents the DataRepository.PscDotThanhToanCoiThiChamThiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(PscDotThanhToanCoiThiChamThiDataSourceDesigner))]
	public class PscDotThanhToanCoiThiChamThiDataSource : ProviderDataSource<PscDotThanhToanCoiThiChamThi, PscDotThanhToanCoiThiChamThiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscDotThanhToanCoiThiChamThiDataSource class.
		/// </summary>
		public PscDotThanhToanCoiThiChamThiDataSource() : base(new PscDotThanhToanCoiThiChamThiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the PscDotThanhToanCoiThiChamThiDataSourceView used by the PscDotThanhToanCoiThiChamThiDataSource.
		/// </summary>
		protected PscDotThanhToanCoiThiChamThiDataSourceView PscDotThanhToanCoiThiChamThiView
		{
			get { return ( View as PscDotThanhToanCoiThiChamThiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the PscDotThanhToanCoiThiChamThiDataSource control invokes to retrieve data.
		/// </summary>
		public PscDotThanhToanCoiThiChamThiSelectMethod SelectMethod
		{
			get
			{
				PscDotThanhToanCoiThiChamThiSelectMethod selectMethod = PscDotThanhToanCoiThiChamThiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (PscDotThanhToanCoiThiChamThiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the PscDotThanhToanCoiThiChamThiDataSourceView class that is to be
		/// used by the PscDotThanhToanCoiThiChamThiDataSource.
		/// </summary>
		/// <returns>An instance of the PscDotThanhToanCoiThiChamThiDataSourceView class.</returns>
		protected override BaseDataSourceView<PscDotThanhToanCoiThiChamThi, PscDotThanhToanCoiThiChamThiKey> GetNewDataSourceView()
		{
			return new PscDotThanhToanCoiThiChamThiDataSourceView(this, DefaultViewName);
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
	/// Supports the PscDotThanhToanCoiThiChamThiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class PscDotThanhToanCoiThiChamThiDataSourceView : ProviderDataSourceView<PscDotThanhToanCoiThiChamThi, PscDotThanhToanCoiThiChamThiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscDotThanhToanCoiThiChamThiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the PscDotThanhToanCoiThiChamThiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public PscDotThanhToanCoiThiChamThiDataSourceView(PscDotThanhToanCoiThiChamThiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal PscDotThanhToanCoiThiChamThiDataSource PscDotThanhToanCoiThiChamThiOwner
		{
			get { return Owner as PscDotThanhToanCoiThiChamThiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal PscDotThanhToanCoiThiChamThiSelectMethod SelectMethod
		{
			get { return PscDotThanhToanCoiThiChamThiOwner.SelectMethod; }
			set { PscDotThanhToanCoiThiChamThiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal PscDotThanhToanCoiThiChamThiService PscDotThanhToanCoiThiChamThiProvider
		{
			get { return Provider as PscDotThanhToanCoiThiChamThiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<PscDotThanhToanCoiThiChamThi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<PscDotThanhToanCoiThiChamThi> results = null;
			PscDotThanhToanCoiThiChamThi item;
			count = 0;
			
			System.String _maDot;

			switch ( SelectMethod )
			{
				case PscDotThanhToanCoiThiChamThiSelectMethod.Get:
					PscDotThanhToanCoiThiChamThiKey entityKey  = new PscDotThanhToanCoiThiChamThiKey();
					entityKey.Load(values);
					item = PscDotThanhToanCoiThiChamThiProvider.Get(entityKey);
					results = new TList<PscDotThanhToanCoiThiChamThi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case PscDotThanhToanCoiThiChamThiSelectMethod.GetAll:
                    results = PscDotThanhToanCoiThiChamThiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case PscDotThanhToanCoiThiChamThiSelectMethod.GetPaged:
					results = PscDotThanhToanCoiThiChamThiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case PscDotThanhToanCoiThiChamThiSelectMethod.Find:
					if ( FilterParameters != null )
						results = PscDotThanhToanCoiThiChamThiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = PscDotThanhToanCoiThiChamThiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case PscDotThanhToanCoiThiChamThiSelectMethod.GetByMaDot:
					_maDot = ( values["MaDot"] != null ) ? (System.String) EntityUtil.ChangeType(values["MaDot"], typeof(System.String)) : string.Empty;
					item = PscDotThanhToanCoiThiChamThiProvider.GetByMaDot(_maDot);
					results = new TList<PscDotThanhToanCoiThiChamThi>();
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
			if ( SelectMethod == PscDotThanhToanCoiThiChamThiSelectMethod.Get || SelectMethod == PscDotThanhToanCoiThiChamThiSelectMethod.GetByMaDot )
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
				PscDotThanhToanCoiThiChamThi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					PscDotThanhToanCoiThiChamThiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<PscDotThanhToanCoiThiChamThi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			PscDotThanhToanCoiThiChamThiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region PscDotThanhToanCoiThiChamThiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the PscDotThanhToanCoiThiChamThiDataSource class.
	/// </summary>
	public class PscDotThanhToanCoiThiChamThiDataSourceDesigner : ProviderDataSourceDesigner<PscDotThanhToanCoiThiChamThi, PscDotThanhToanCoiThiChamThiKey>
	{
		/// <summary>
		/// Initializes a new instance of the PscDotThanhToanCoiThiChamThiDataSourceDesigner class.
		/// </summary>
		public PscDotThanhToanCoiThiChamThiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PscDotThanhToanCoiThiChamThiSelectMethod SelectMethod
		{
			get { return ((PscDotThanhToanCoiThiChamThiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new PscDotThanhToanCoiThiChamThiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region PscDotThanhToanCoiThiChamThiDataSourceActionList

	/// <summary>
	/// Supports the PscDotThanhToanCoiThiChamThiDataSourceDesigner class.
	/// </summary>
	internal class PscDotThanhToanCoiThiChamThiDataSourceActionList : DesignerActionList
	{
		private PscDotThanhToanCoiThiChamThiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the PscDotThanhToanCoiThiChamThiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public PscDotThanhToanCoiThiChamThiDataSourceActionList(PscDotThanhToanCoiThiChamThiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PscDotThanhToanCoiThiChamThiSelectMethod SelectMethod
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

	#endregion PscDotThanhToanCoiThiChamThiDataSourceActionList
	
	#endregion PscDotThanhToanCoiThiChamThiDataSourceDesigner
	
	#region PscDotThanhToanCoiThiChamThiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the PscDotThanhToanCoiThiChamThiDataSource.SelectMethod property.
	/// </summary>
	public enum PscDotThanhToanCoiThiChamThiSelectMethod
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
		/// Represents the GetByMaDot method.
		/// </summary>
		GetByMaDot
	}
	
	#endregion PscDotThanhToanCoiThiChamThiSelectMethod

	#region PscDotThanhToanCoiThiChamThiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscDotThanhToanCoiThiChamThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscDotThanhToanCoiThiChamThiFilter : SqlFilter<PscDotThanhToanCoiThiChamThiColumn>
	{
	}
	
	#endregion PscDotThanhToanCoiThiChamThiFilter

	#region PscDotThanhToanCoiThiChamThiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscDotThanhToanCoiThiChamThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscDotThanhToanCoiThiChamThiExpressionBuilder : SqlExpressionBuilder<PscDotThanhToanCoiThiChamThiColumn>
	{
	}
	
	#endregion PscDotThanhToanCoiThiChamThiExpressionBuilder	

	#region PscDotThanhToanCoiThiChamThiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;PscDotThanhToanCoiThiChamThiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="PscDotThanhToanCoiThiChamThi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscDotThanhToanCoiThiChamThiProperty : ChildEntityProperty<PscDotThanhToanCoiThiChamThiChildEntityTypes>
	{
	}
	
	#endregion PscDotThanhToanCoiThiChamThiProperty
}

