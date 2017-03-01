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
	/// Represents the DataRepository.KcqUteKhoiLuongQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqUteKhoiLuongQuyDoiDataSourceDesigner))]
	public class KcqUteKhoiLuongQuyDoiDataSource : ProviderDataSource<KcqUteKhoiLuongQuyDoi, KcqUteKhoiLuongQuyDoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongQuyDoiDataSource class.
		/// </summary>
		public KcqUteKhoiLuongQuyDoiDataSource() : base(new KcqUteKhoiLuongQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqUteKhoiLuongQuyDoiDataSourceView used by the KcqUteKhoiLuongQuyDoiDataSource.
		/// </summary>
		protected KcqUteKhoiLuongQuyDoiDataSourceView KcqUteKhoiLuongQuyDoiView
		{
			get { return ( View as KcqUteKhoiLuongQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqUteKhoiLuongQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public KcqUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get
			{
				KcqUteKhoiLuongQuyDoiSelectMethod selectMethod = KcqUteKhoiLuongQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqUteKhoiLuongQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqUteKhoiLuongQuyDoiDataSourceView class that is to be
		/// used by the KcqUteKhoiLuongQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the KcqUteKhoiLuongQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqUteKhoiLuongQuyDoi, KcqUteKhoiLuongQuyDoiKey> GetNewDataSourceView()
		{
			return new KcqUteKhoiLuongQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqUteKhoiLuongQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqUteKhoiLuongQuyDoiDataSourceView : ProviderDataSourceView<KcqUteKhoiLuongQuyDoi, KcqUteKhoiLuongQuyDoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqUteKhoiLuongQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqUteKhoiLuongQuyDoiDataSourceView(KcqUteKhoiLuongQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqUteKhoiLuongQuyDoiDataSource KcqUteKhoiLuongQuyDoiOwner
		{
			get { return Owner as KcqUteKhoiLuongQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return KcqUteKhoiLuongQuyDoiOwner.SelectMethod; }
			set { KcqUteKhoiLuongQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqUteKhoiLuongQuyDoiService KcqUteKhoiLuongQuyDoiProvider
		{
			get { return Provider as KcqUteKhoiLuongQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqUteKhoiLuongQuyDoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqUteKhoiLuongQuyDoi> results = null;
			KcqUteKhoiLuongQuyDoi item;
			count = 0;
			
			System.Int32 _id;
			System.Int32 _idKhoiLuongGiangDay;

			switch ( SelectMethod )
			{
				case KcqUteKhoiLuongQuyDoiSelectMethod.Get:
					KcqUteKhoiLuongQuyDoiKey entityKey  = new KcqUteKhoiLuongQuyDoiKey();
					entityKey.Load(values);
					item = KcqUteKhoiLuongQuyDoiProvider.Get(entityKey);
					results = new TList<KcqUteKhoiLuongQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqUteKhoiLuongQuyDoiSelectMethod.GetAll:
                    results = KcqUteKhoiLuongQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqUteKhoiLuongQuyDoiSelectMethod.GetPaged:
					results = KcqUteKhoiLuongQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqUteKhoiLuongQuyDoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqUteKhoiLuongQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqUteKhoiLuongQuyDoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqUteKhoiLuongQuyDoiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqUteKhoiLuongQuyDoiProvider.GetById(_id);
					results = new TList<KcqUteKhoiLuongQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KcqUteKhoiLuongQuyDoiSelectMethod.GetByIdKhoiLuongGiangDay:
					_idKhoiLuongGiangDay = ( values["IdKhoiLuongGiangDay"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["IdKhoiLuongGiangDay"], typeof(System.Int32)) : (int)0;
					results = KcqUteKhoiLuongQuyDoiProvider.GetByIdKhoiLuongGiangDay(_idKhoiLuongGiangDay, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == KcqUteKhoiLuongQuyDoiSelectMethod.Get || SelectMethod == KcqUteKhoiLuongQuyDoiSelectMethod.GetById )
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
				KcqUteKhoiLuongQuyDoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqUteKhoiLuongQuyDoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqUteKhoiLuongQuyDoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqUteKhoiLuongQuyDoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqUteKhoiLuongQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqUteKhoiLuongQuyDoiDataSource class.
	/// </summary>
	public class KcqUteKhoiLuongQuyDoiDataSourceDesigner : ProviderDataSourceDesigner<KcqUteKhoiLuongQuyDoi, KcqUteKhoiLuongQuyDoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongQuyDoiDataSourceDesigner class.
		/// </summary>
		public KcqUteKhoiLuongQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqUteKhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return ((KcqUteKhoiLuongQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqUteKhoiLuongQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqUteKhoiLuongQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the KcqUteKhoiLuongQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class KcqUteKhoiLuongQuyDoiDataSourceActionList : DesignerActionList
	{
		private KcqUteKhoiLuongQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqUteKhoiLuongQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqUteKhoiLuongQuyDoiDataSourceActionList(KcqUteKhoiLuongQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqUteKhoiLuongQuyDoiSelectMethod SelectMethod
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

	#endregion KcqUteKhoiLuongQuyDoiDataSourceActionList
	
	#endregion KcqUteKhoiLuongQuyDoiDataSourceDesigner
	
	#region KcqUteKhoiLuongQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqUteKhoiLuongQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum KcqUteKhoiLuongQuyDoiSelectMethod
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
	
	#endregion KcqUteKhoiLuongQuyDoiSelectMethod

	#region KcqUteKhoiLuongQuyDoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongQuyDoiFilter : SqlFilter<KcqUteKhoiLuongQuyDoiColumn>
	{
	}
	
	#endregion KcqUteKhoiLuongQuyDoiFilter

	#region KcqUteKhoiLuongQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongQuyDoiExpressionBuilder : SqlExpressionBuilder<KcqUteKhoiLuongQuyDoiColumn>
	{
	}
	
	#endregion KcqUteKhoiLuongQuyDoiExpressionBuilder	

	#region KcqUteKhoiLuongQuyDoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqUteKhoiLuongQuyDoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqUteKhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqUteKhoiLuongQuyDoiProperty : ChildEntityProperty<KcqUteKhoiLuongQuyDoiChildEntityTypes>
	{
	}
	
	#endregion KcqUteKhoiLuongQuyDoiProperty
}

