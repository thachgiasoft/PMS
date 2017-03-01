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
	/// Represents the DataRepository.NgachCongChucProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(NgachCongChucDataSourceDesigner))]
	public class NgachCongChucDataSource : ProviderDataSource<NgachCongChuc, NgachCongChucKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NgachCongChucDataSource class.
		/// </summary>
		public NgachCongChucDataSource() : base(new NgachCongChucService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the NgachCongChucDataSourceView used by the NgachCongChucDataSource.
		/// </summary>
		protected NgachCongChucDataSourceView NgachCongChucView
		{
			get { return ( View as NgachCongChucDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the NgachCongChucDataSource control invokes to retrieve data.
		/// </summary>
		public NgachCongChucSelectMethod SelectMethod
		{
			get
			{
				NgachCongChucSelectMethod selectMethod = NgachCongChucSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (NgachCongChucSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the NgachCongChucDataSourceView class that is to be
		/// used by the NgachCongChucDataSource.
		/// </summary>
		/// <returns>An instance of the NgachCongChucDataSourceView class.</returns>
		protected override BaseDataSourceView<NgachCongChuc, NgachCongChucKey> GetNewDataSourceView()
		{
			return new NgachCongChucDataSourceView(this, DefaultViewName);
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
	/// Supports the NgachCongChucDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class NgachCongChucDataSourceView : ProviderDataSourceView<NgachCongChuc, NgachCongChucKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the NgachCongChucDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the NgachCongChucDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public NgachCongChucDataSourceView(NgachCongChucDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal NgachCongChucDataSource NgachCongChucOwner
		{
			get { return Owner as NgachCongChucDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal NgachCongChucSelectMethod SelectMethod
		{
			get { return NgachCongChucOwner.SelectMethod; }
			set { NgachCongChucOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal NgachCongChucService NgachCongChucProvider
		{
			get { return Provider as NgachCongChucService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<NgachCongChuc> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<NgachCongChuc> results = null;
			NgachCongChuc item;
			count = 0;
			
			System.Int32 _maNgachCongChuc;

			switch ( SelectMethod )
			{
				case NgachCongChucSelectMethod.Get:
					NgachCongChucKey entityKey  = new NgachCongChucKey();
					entityKey.Load(values);
					item = NgachCongChucProvider.Get(entityKey);
					results = new TList<NgachCongChuc>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case NgachCongChucSelectMethod.GetAll:
                    results = NgachCongChucProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case NgachCongChucSelectMethod.GetPaged:
					results = NgachCongChucProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case NgachCongChucSelectMethod.Find:
					if ( FilterParameters != null )
						results = NgachCongChucProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = NgachCongChucProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case NgachCongChucSelectMethod.GetByMaNgachCongChuc:
					_maNgachCongChuc = ( values["MaNgachCongChuc"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaNgachCongChuc"], typeof(System.Int32)) : (int)0;
					item = NgachCongChucProvider.GetByMaNgachCongChuc(_maNgachCongChuc);
					results = new TList<NgachCongChuc>();
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
			if ( SelectMethod == NgachCongChucSelectMethod.Get || SelectMethod == NgachCongChucSelectMethod.GetByMaNgachCongChuc )
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
				NgachCongChuc entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					NgachCongChucProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<NgachCongChuc> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			NgachCongChucProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region NgachCongChucDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the NgachCongChucDataSource class.
	/// </summary>
	public class NgachCongChucDataSourceDesigner : ProviderDataSourceDesigner<NgachCongChuc, NgachCongChucKey>
	{
		/// <summary>
		/// Initializes a new instance of the NgachCongChucDataSourceDesigner class.
		/// </summary>
		public NgachCongChucDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NgachCongChucSelectMethod SelectMethod
		{
			get { return ((NgachCongChucDataSource) DataSource).SelectMethod; }
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
				actions.Add(new NgachCongChucDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region NgachCongChucDataSourceActionList

	/// <summary>
	/// Supports the NgachCongChucDataSourceDesigner class.
	/// </summary>
	internal class NgachCongChucDataSourceActionList : DesignerActionList
	{
		private NgachCongChucDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the NgachCongChucDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public NgachCongChucDataSourceActionList(NgachCongChucDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public NgachCongChucSelectMethod SelectMethod
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

	#endregion NgachCongChucDataSourceActionList
	
	#endregion NgachCongChucDataSourceDesigner
	
	#region NgachCongChucSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the NgachCongChucDataSource.SelectMethod property.
	/// </summary>
	public enum NgachCongChucSelectMethod
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
		/// Represents the GetByMaNgachCongChuc method.
		/// </summary>
		GetByMaNgachCongChuc
	}
	
	#endregion NgachCongChucSelectMethod

	#region NgachCongChucFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NgachCongChuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NgachCongChucFilter : SqlFilter<NgachCongChucColumn>
	{
	}
	
	#endregion NgachCongChucFilter

	#region NgachCongChucExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="NgachCongChuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NgachCongChucExpressionBuilder : SqlExpressionBuilder<NgachCongChucColumn>
	{
	}
	
	#endregion NgachCongChucExpressionBuilder	

	#region NgachCongChucProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;NgachCongChucChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="NgachCongChuc"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class NgachCongChucProperty : ChildEntityProperty<NgachCongChucChildEntityTypes>
	{
	}
	
	#endregion NgachCongChucProperty
}

