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
	/// Represents the DataRepository.KhoiLuongQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoiLuongQuyDoiDataSourceDesigner))]
	public class KhoiLuongQuyDoiDataSource : ProviderDataSource<KhoiLuongQuyDoi, KhoiLuongQuyDoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiDataSource class.
		/// </summary>
		public KhoiLuongQuyDoiDataSource() : base(new KhoiLuongQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoiLuongQuyDoiDataSourceView used by the KhoiLuongQuyDoiDataSource.
		/// </summary>
		protected KhoiLuongQuyDoiDataSourceView KhoiLuongQuyDoiView
		{
			get { return ( View as KhoiLuongQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoiLuongQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public KhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get
			{
				KhoiLuongQuyDoiSelectMethod selectMethod = KhoiLuongQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoiLuongQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoiLuongQuyDoiDataSourceView class that is to be
		/// used by the KhoiLuongQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the KhoiLuongQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoiLuongQuyDoi, KhoiLuongQuyDoiKey> GetNewDataSourceView()
		{
			return new KhoiLuongQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoiLuongQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoiLuongQuyDoiDataSourceView : ProviderDataSourceView<KhoiLuongQuyDoi, KhoiLuongQuyDoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoiLuongQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoiLuongQuyDoiDataSourceView(KhoiLuongQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoiLuongQuyDoiDataSource KhoiLuongQuyDoiOwner
		{
			get { return Owner as KhoiLuongQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return KhoiLuongQuyDoiOwner.SelectMethod; }
			set { KhoiLuongQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoiLuongQuyDoiService KhoiLuongQuyDoiProvider
		{
			get { return Provider as KhoiLuongQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoiLuongQuyDoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoiLuongQuyDoi> results = null;
			KhoiLuongQuyDoi item;
			count = 0;
			
			System.Int32 _maKhoiLuongQuyDoi;
			System.Int32? _maKhoiLuongGiangDay_nullable;

			switch ( SelectMethod )
			{
				case KhoiLuongQuyDoiSelectMethod.Get:
					KhoiLuongQuyDoiKey entityKey  = new KhoiLuongQuyDoiKey();
					entityKey.Load(values);
					item = KhoiLuongQuyDoiProvider.Get(entityKey);
					results = new TList<KhoiLuongQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoiLuongQuyDoiSelectMethod.GetAll:
                    results = KhoiLuongQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoiLuongQuyDoiSelectMethod.GetPaged:
					results = KhoiLuongQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoiLuongQuyDoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoiLuongQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoiLuongQuyDoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoiLuongQuyDoiSelectMethod.GetByMaKhoiLuongQuyDoi:
					_maKhoiLuongQuyDoi = ( values["MaKhoiLuongQuyDoi"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoiLuongQuyDoi"], typeof(System.Int32)) : (int)0;
					item = KhoiLuongQuyDoiProvider.GetByMaKhoiLuongQuyDoi(_maKhoiLuongQuyDoi);
					results = new TList<KhoiLuongQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KhoiLuongQuyDoiSelectMethod.GetByMaKhoiLuongGiangDay:
					_maKhoiLuongGiangDay_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaKhoiLuongGiangDay"], typeof(System.Int32?));
					results = KhoiLuongQuyDoiProvider.GetByMaKhoiLuongGiangDay(_maKhoiLuongGiangDay_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == KhoiLuongQuyDoiSelectMethod.Get || SelectMethod == KhoiLuongQuyDoiSelectMethod.GetByMaKhoiLuongQuyDoi )
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
				KhoiLuongQuyDoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoiLuongQuyDoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoiLuongQuyDoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoiLuongQuyDoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoiLuongQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoiLuongQuyDoiDataSource class.
	/// </summary>
	public class KhoiLuongQuyDoiDataSourceDesigner : ProviderDataSourceDesigner<KhoiLuongQuyDoi, KhoiLuongQuyDoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiDataSourceDesigner class.
		/// </summary>
		public KhoiLuongQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongQuyDoiSelectMethod SelectMethod
		{
			get { return ((KhoiLuongQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoiLuongQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoiLuongQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the KhoiLuongQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class KhoiLuongQuyDoiDataSourceActionList : DesignerActionList
	{
		private KhoiLuongQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoiLuongQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoiLuongQuyDoiDataSourceActionList(KhoiLuongQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoiLuongQuyDoiSelectMethod SelectMethod
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

	#endregion KhoiLuongQuyDoiDataSourceActionList
	
	#endregion KhoiLuongQuyDoiDataSourceDesigner
	
	#region KhoiLuongQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoiLuongQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum KhoiLuongQuyDoiSelectMethod
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
		/// Represents the GetByMaKhoiLuongQuyDoi method.
		/// </summary>
		GetByMaKhoiLuongQuyDoi,
		/// <summary>
		/// Represents the GetByMaKhoiLuongGiangDay method.
		/// </summary>
		GetByMaKhoiLuongGiangDay
	}
	
	#endregion KhoiLuongQuyDoiSelectMethod

	#region KhoiLuongQuyDoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiFilter : SqlFilter<KhoiLuongQuyDoiColumn>
	{
	}
	
	#endregion KhoiLuongQuyDoiFilter

	#region KhoiLuongQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiExpressionBuilder : SqlExpressionBuilder<KhoiLuongQuyDoiColumn>
	{
	}
	
	#endregion KhoiLuongQuyDoiExpressionBuilder	

	#region KhoiLuongQuyDoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoiLuongQuyDoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoiLuongQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoiLuongQuyDoiProperty : ChildEntityProperty<KhoiLuongQuyDoiChildEntityTypes>
	{
	}
	
	#endregion KhoiLuongQuyDoiProperty
}

