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
	/// Represents the DataRepository.PhanQuyenControlTrenFormProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(PhanQuyenControlTrenFormDataSourceDesigner))]
	public class PhanQuyenControlTrenFormDataSource : ProviderDataSource<PhanQuyenControlTrenForm, PhanQuyenControlTrenFormKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanQuyenControlTrenFormDataSource class.
		/// </summary>
		public PhanQuyenControlTrenFormDataSource() : base(new PhanQuyenControlTrenFormService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the PhanQuyenControlTrenFormDataSourceView used by the PhanQuyenControlTrenFormDataSource.
		/// </summary>
		protected PhanQuyenControlTrenFormDataSourceView PhanQuyenControlTrenFormView
		{
			get { return ( View as PhanQuyenControlTrenFormDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the PhanQuyenControlTrenFormDataSource control invokes to retrieve data.
		/// </summary>
		public PhanQuyenControlTrenFormSelectMethod SelectMethod
		{
			get
			{
				PhanQuyenControlTrenFormSelectMethod selectMethod = PhanQuyenControlTrenFormSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (PhanQuyenControlTrenFormSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the PhanQuyenControlTrenFormDataSourceView class that is to be
		/// used by the PhanQuyenControlTrenFormDataSource.
		/// </summary>
		/// <returns>An instance of the PhanQuyenControlTrenFormDataSourceView class.</returns>
		protected override BaseDataSourceView<PhanQuyenControlTrenForm, PhanQuyenControlTrenFormKey> GetNewDataSourceView()
		{
			return new PhanQuyenControlTrenFormDataSourceView(this, DefaultViewName);
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
	/// Supports the PhanQuyenControlTrenFormDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class PhanQuyenControlTrenFormDataSourceView : ProviderDataSourceView<PhanQuyenControlTrenForm, PhanQuyenControlTrenFormKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the PhanQuyenControlTrenFormDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the PhanQuyenControlTrenFormDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public PhanQuyenControlTrenFormDataSourceView(PhanQuyenControlTrenFormDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal PhanQuyenControlTrenFormDataSource PhanQuyenControlTrenFormOwner
		{
			get { return Owner as PhanQuyenControlTrenFormDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal PhanQuyenControlTrenFormSelectMethod SelectMethod
		{
			get { return PhanQuyenControlTrenFormOwner.SelectMethod; }
			set { PhanQuyenControlTrenFormOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal PhanQuyenControlTrenFormService PhanQuyenControlTrenFormProvider
		{
			get { return Provider as PhanQuyenControlTrenFormService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<PhanQuyenControlTrenForm> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<PhanQuyenControlTrenForm> results = null;
			PhanQuyenControlTrenForm item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case PhanQuyenControlTrenFormSelectMethod.Get:
					PhanQuyenControlTrenFormKey entityKey  = new PhanQuyenControlTrenFormKey();
					entityKey.Load(values);
					item = PhanQuyenControlTrenFormProvider.Get(entityKey);
					results = new TList<PhanQuyenControlTrenForm>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case PhanQuyenControlTrenFormSelectMethod.GetAll:
                    results = PhanQuyenControlTrenFormProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case PhanQuyenControlTrenFormSelectMethod.GetPaged:
					results = PhanQuyenControlTrenFormProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case PhanQuyenControlTrenFormSelectMethod.Find:
					if ( FilterParameters != null )
						results = PhanQuyenControlTrenFormProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = PhanQuyenControlTrenFormProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case PhanQuyenControlTrenFormSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = PhanQuyenControlTrenFormProvider.GetById(_id);
					results = new TList<PhanQuyenControlTrenForm>();
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
			if ( SelectMethod == PhanQuyenControlTrenFormSelectMethod.Get || SelectMethod == PhanQuyenControlTrenFormSelectMethod.GetById )
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
				PhanQuyenControlTrenForm entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					PhanQuyenControlTrenFormProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<PhanQuyenControlTrenForm> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			PhanQuyenControlTrenFormProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region PhanQuyenControlTrenFormDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the PhanQuyenControlTrenFormDataSource class.
	/// </summary>
	public class PhanQuyenControlTrenFormDataSourceDesigner : ProviderDataSourceDesigner<PhanQuyenControlTrenForm, PhanQuyenControlTrenFormKey>
	{
		/// <summary>
		/// Initializes a new instance of the PhanQuyenControlTrenFormDataSourceDesigner class.
		/// </summary>
		public PhanQuyenControlTrenFormDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanQuyenControlTrenFormSelectMethod SelectMethod
		{
			get { return ((PhanQuyenControlTrenFormDataSource) DataSource).SelectMethod; }
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
				actions.Add(new PhanQuyenControlTrenFormDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region PhanQuyenControlTrenFormDataSourceActionList

	/// <summary>
	/// Supports the PhanQuyenControlTrenFormDataSourceDesigner class.
	/// </summary>
	internal class PhanQuyenControlTrenFormDataSourceActionList : DesignerActionList
	{
		private PhanQuyenControlTrenFormDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the PhanQuyenControlTrenFormDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public PhanQuyenControlTrenFormDataSourceActionList(PhanQuyenControlTrenFormDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public PhanQuyenControlTrenFormSelectMethod SelectMethod
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

	#endregion PhanQuyenControlTrenFormDataSourceActionList
	
	#endregion PhanQuyenControlTrenFormDataSourceDesigner
	
	#region PhanQuyenControlTrenFormSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the PhanQuyenControlTrenFormDataSource.SelectMethod property.
	/// </summary>
	public enum PhanQuyenControlTrenFormSelectMethod
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
	
	#endregion PhanQuyenControlTrenFormSelectMethod

	#region PhanQuyenControlTrenFormFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanQuyenControlTrenForm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanQuyenControlTrenFormFilter : SqlFilter<PhanQuyenControlTrenFormColumn>
	{
	}
	
	#endregion PhanQuyenControlTrenFormFilter

	#region PhanQuyenControlTrenFormExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="PhanQuyenControlTrenForm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanQuyenControlTrenFormExpressionBuilder : SqlExpressionBuilder<PhanQuyenControlTrenFormColumn>
	{
	}
	
	#endregion PhanQuyenControlTrenFormExpressionBuilder	

	#region PhanQuyenControlTrenFormProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;PhanQuyenControlTrenFormChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="PhanQuyenControlTrenForm"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class PhanQuyenControlTrenFormProperty : ChildEntityProperty<PhanQuyenControlTrenFormChildEntityTypes>
	{
	}
	
	#endregion PhanQuyenControlTrenFormProperty
}

