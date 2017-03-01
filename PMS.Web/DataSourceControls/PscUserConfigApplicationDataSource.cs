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
	/// Represents the DataRepository.PscUserConfigApplicationProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(PscUserConfigApplicationDataSourceDesigner))]
	public class PscUserConfigApplicationDataSource : ProviderDataSource<PscUserConfigApplication, PscUserConfigApplicationKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationDataSource class.
		/// </summary>
		public PscUserConfigApplicationDataSource() : base(new PscUserConfigApplicationService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the PscUserConfigApplicationDataSourceView used by the PscUserConfigApplicationDataSource.
		/// </summary>
		protected PscUserConfigApplicationDataSourceView PscUserConfigApplicationView
		{
			get { return ( View as PscUserConfigApplicationDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the PscUserConfigApplicationDataSource control invokes to retrieve data.
		/// </summary>
		public PscUserConfigApplicationSelectMethod SelectMethod
		{
			get
			{
				PscUserConfigApplicationSelectMethod selectMethod = PscUserConfigApplicationSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (PscUserConfigApplicationSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the PscUserConfigApplicationDataSourceView class that is to be
		/// used by the PscUserConfigApplicationDataSource.
		/// </summary>
		/// <returns>An instance of the PscUserConfigApplicationDataSourceView class.</returns>
		protected override BaseDataSourceView<PscUserConfigApplication, PscUserConfigApplicationKey> GetNewDataSourceView()
		{
			return new PscUserConfigApplicationDataSourceView(this, DefaultViewName);
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
	/// Supports the PscUserConfigApplicationDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class PscUserConfigApplicationDataSourceView : ProviderDataSourceView<PscUserConfigApplication, PscUserConfigApplicationKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the PscUserConfigApplicationDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public PscUserConfigApplicationDataSourceView(PscUserConfigApplicationDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal PscUserConfigApplicationDataSource PscUserConfigApplicationOwner
		{
			get { return Owner as PscUserConfigApplicationDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal PscUserConfigApplicationSelectMethod SelectMethod
		{
			get { return PscUserConfigApplicationOwner.SelectMethod; }
			set { PscUserConfigApplicationOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal PscUserConfigApplicationService PscUserConfigApplicationProvider
		{
			get { return Provider as PscUserConfigApplicationService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<PscUserConfigApplication> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<PscUserConfigApplication> results = null;
			PscUserConfigApplication item;
			count = 0;
			
			System.String _staffId;
			System.String _configName;

			switch ( SelectMethod )
			{
				case PscUserConfigApplicationSelectMethod.Get:
					PscUserConfigApplicationKey entityKey  = new PscUserConfigApplicationKey();
					entityKey.Load(values);
					item = PscUserConfigApplicationProvider.Get(entityKey);
					results = new TList<PscUserConfigApplication>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case PscUserConfigApplicationSelectMethod.GetAll:
                    results = PscUserConfigApplicationProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case PscUserConfigApplicationSelectMethod.GetPaged:
					results = PscUserConfigApplicationProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case PscUserConfigApplicationSelectMethod.Find:
					if ( FilterParameters != null )
						results = PscUserConfigApplicationProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = PscUserConfigApplicationProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case PscUserConfigApplicationSelectMethod.GetByStaffIdConfigName:
					_staffId = ( values["StaffId"] != null ) ? (System.String) EntityUtil.ChangeType(values["StaffId"], typeof(System.String)) : string.Empty;
					_configName = ( values["ConfigName"] != null ) ? (System.String) EntityUtil.ChangeType(values["ConfigName"], typeof(System.String)) : string.Empty;
					item = PscUserConfigApplicationProvider.GetByStaffIdConfigName(_staffId, _configName);
					results = new TList<PscUserConfigApplication>();
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
			if ( SelectMethod == PscUserConfigApplicationSelectMethod.Get || SelectMethod == PscUserConfigApplicationSelectMethod.GetByStaffIdConfigName )
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
				PscUserConfigApplication entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					PscUserConfigApplicationProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<PscUserConfigApplication> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			PscUserConfigApplicationProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region PscUserConfigApplicationDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the PscUserConfigApplicationDataSource class.
	/// </summary>
	public class PscUserConfigApplicationDataSourceDesigner : ProviderDataSourceDesigner<PscUserConfigApplication, PscUserConfigApplicationKey>
	{
		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationDataSourceDesigner class.
		/// </summary>
		public PscUserConfigApplicationDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PscUserConfigApplicationSelectMethod SelectMethod
		{
			get { return ((PscUserConfigApplicationDataSource) DataSource).SelectMethod; }
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
				actions.Add(new PscUserConfigApplicationDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region PscUserConfigApplicationDataSourceActionList

	/// <summary>
	/// Supports the PscUserConfigApplicationDataSourceDesigner class.
	/// </summary>
	internal class PscUserConfigApplicationDataSourceActionList : DesignerActionList
	{
		private PscUserConfigApplicationDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the PscUserConfigApplicationDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public PscUserConfigApplicationDataSourceActionList(PscUserConfigApplicationDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PscUserConfigApplicationSelectMethod SelectMethod
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

	#endregion PscUserConfigApplicationDataSourceActionList
	
	#endregion PscUserConfigApplicationDataSourceDesigner
	
	#region PscUserConfigApplicationSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the PscUserConfigApplicationDataSource.SelectMethod property.
	/// </summary>
	public enum PscUserConfigApplicationSelectMethod
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
		/// Represents the GetByStaffIdConfigName method.
		/// </summary>
		GetByStaffIdConfigName
	}
	
	#endregion PscUserConfigApplicationSelectMethod

	#region PscUserConfigApplicationFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscUserConfigApplication"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscUserConfigApplicationFilter : SqlFilter<PscUserConfigApplicationColumn>
	{
	}
	
	#endregion PscUserConfigApplicationFilter

	#region PscUserConfigApplicationExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PscUserConfigApplication"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscUserConfigApplicationExpressionBuilder : SqlExpressionBuilder<PscUserConfigApplicationColumn>
	{
	}
	
	#endregion PscUserConfigApplicationExpressionBuilder	

	#region PscUserConfigApplicationProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;PscUserConfigApplicationChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="PscUserConfigApplication"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PscUserConfigApplicationProperty : ChildEntityProperty<PscUserConfigApplicationChildEntityTypes>
	{
	}
	
	#endregion PscUserConfigApplicationProperty
}

