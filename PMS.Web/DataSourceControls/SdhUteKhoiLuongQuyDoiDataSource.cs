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
	/// Represents the DataRepository.SdhUteKhoiLuongQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(SdhUteKhoiLuongQuyDoiDataSourceDesigner))]
	public class SdhUteKhoiLuongQuyDoiDataSource : ProviderDataSource<SdhUteKhoiLuongQuyDoi, SdhUteKhoiLuongQuyDoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiDataSource class.
		/// </summary>
		public SdhUteKhoiLuongQuyDoiDataSource() : base(new SdhUteKhoiLuongQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the SdhUteKhoiLuongQuyDoiDataSourceView used by the SdhUteKhoiLuongQuyDoiDataSource.
		/// </summary>
		protected SdhUteKhoiLuongQuyDoiDataSourceView SdhUteKhoiLuongQuyDoiView
		{
			get { return ( View as SdhUteKhoiLuongQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the SdhUteKhoiLuongQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public SdhUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get
			{
				SdhUteKhoiLuongQuyDoiSelectMethod selectMethod = SdhUteKhoiLuongQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (SdhUteKhoiLuongQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the SdhUteKhoiLuongQuyDoiDataSourceView class that is to be
		/// used by the SdhUteKhoiLuongQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the SdhUteKhoiLuongQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<SdhUteKhoiLuongQuyDoi, SdhUteKhoiLuongQuyDoiKey> GetNewDataSourceView()
		{
			return new SdhUteKhoiLuongQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the SdhUteKhoiLuongQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class SdhUteKhoiLuongQuyDoiDataSourceView : ProviderDataSourceView<SdhUteKhoiLuongQuyDoi, SdhUteKhoiLuongQuyDoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the SdhUteKhoiLuongQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public SdhUteKhoiLuongQuyDoiDataSourceView(SdhUteKhoiLuongQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal SdhUteKhoiLuongQuyDoiDataSource SdhUteKhoiLuongQuyDoiOwner
		{
			get { return Owner as SdhUteKhoiLuongQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal SdhUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return SdhUteKhoiLuongQuyDoiOwner.SelectMethod; }
			set { SdhUteKhoiLuongQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal SdhUteKhoiLuongQuyDoiService SdhUteKhoiLuongQuyDoiProvider
		{
			get { return Provider as SdhUteKhoiLuongQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<SdhUteKhoiLuongQuyDoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<SdhUteKhoiLuongQuyDoi> results = null;
			SdhUteKhoiLuongQuyDoi item;
			count = 0;
			
			System.Int32 _id;
			System.Int32 _idKhoiLuongGiangDay;

			switch ( SelectMethod )
			{
				case SdhUteKhoiLuongQuyDoiSelectMethod.Get:
					SdhUteKhoiLuongQuyDoiKey entityKey  = new SdhUteKhoiLuongQuyDoiKey();
					entityKey.Load(values);
					item = SdhUteKhoiLuongQuyDoiProvider.Get(entityKey);
					results = new TList<SdhUteKhoiLuongQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case SdhUteKhoiLuongQuyDoiSelectMethod.GetAll:
                    results = SdhUteKhoiLuongQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case SdhUteKhoiLuongQuyDoiSelectMethod.GetPaged:
					results = SdhUteKhoiLuongQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case SdhUteKhoiLuongQuyDoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = SdhUteKhoiLuongQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = SdhUteKhoiLuongQuyDoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case SdhUteKhoiLuongQuyDoiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = SdhUteKhoiLuongQuyDoiProvider.GetById(_id);
					results = new TList<SdhUteKhoiLuongQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case SdhUteKhoiLuongQuyDoiSelectMethod.GetByIdKhoiLuongGiangDay:
					_idKhoiLuongGiangDay = ( values["IdKhoiLuongGiangDay"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["IdKhoiLuongGiangDay"], typeof(System.Int32)) : (int)0;
					results = SdhUteKhoiLuongQuyDoiProvider.GetByIdKhoiLuongGiangDay(_idKhoiLuongGiangDay, this.StartIndex, this.PageSize, out count);
					break;
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
			if ( SelectMethod == SdhUteKhoiLuongQuyDoiSelectMethod.Get || SelectMethod == SdhUteKhoiLuongQuyDoiSelectMethod.GetById )
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
				SdhUteKhoiLuongQuyDoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					SdhUteKhoiLuongQuyDoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<SdhUteKhoiLuongQuyDoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			SdhUteKhoiLuongQuyDoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region SdhUteKhoiLuongQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the SdhUteKhoiLuongQuyDoiDataSource class.
	/// </summary>
	public class SdhUteKhoiLuongQuyDoiDataSourceDesigner : ProviderDataSourceDesigner<SdhUteKhoiLuongQuyDoi, SdhUteKhoiLuongQuyDoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiDataSourceDesigner class.
		/// </summary>
		public SdhUteKhoiLuongQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return ((SdhUteKhoiLuongQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new SdhUteKhoiLuongQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region SdhUteKhoiLuongQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the SdhUteKhoiLuongQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class SdhUteKhoiLuongQuyDoiDataSourceActionList : DesignerActionList
	{
		private SdhUteKhoiLuongQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the SdhUteKhoiLuongQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public SdhUteKhoiLuongQuyDoiDataSourceActionList(SdhUteKhoiLuongQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public SdhUteKhoiLuongQuyDoiSelectMethod SelectMethod
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

	#endregion SdhUteKhoiLuongQuyDoiDataSourceActionList
	
	#endregion SdhUteKhoiLuongQuyDoiDataSourceDesigner
	
	#region SdhUteKhoiLuongQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the SdhUteKhoiLuongQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum SdhUteKhoiLuongQuyDoiSelectMethod
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
		/// Represents the GetByIdKhoiLuongGiangDay method.
		/// </summary>
		GetByIdKhoiLuongGiangDay
	}
	
	#endregion SdhUteKhoiLuongQuyDoiSelectMethod

	#region SdhUteKhoiLuongQuyDoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteKhoiLuongQuyDoiFilter : SqlFilter<SdhUteKhoiLuongQuyDoiColumn>
	{
	}
	
	#endregion SdhUteKhoiLuongQuyDoiFilter

	#region SdhUteKhoiLuongQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteKhoiLuongQuyDoiExpressionBuilder : SqlExpressionBuilder<SdhUteKhoiLuongQuyDoiColumn>
	{
	}
	
	#endregion SdhUteKhoiLuongQuyDoiExpressionBuilder	

	#region SdhUteKhoiLuongQuyDoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;SdhUteKhoiLuongQuyDoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="SdhUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class SdhUteKhoiLuongQuyDoiProperty : ChildEntityProperty<SdhUteKhoiLuongQuyDoiChildEntityTypes>
	{
	}
	
	#endregion SdhUteKhoiLuongQuyDoiProperty
}

