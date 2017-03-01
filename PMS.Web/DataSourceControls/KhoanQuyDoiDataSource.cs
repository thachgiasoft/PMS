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
	/// Represents the DataRepository.KhoanQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KhoanQuyDoiDataSourceDesigner))]
	public class KhoanQuyDoiDataSource : ProviderDataSource<KhoanQuyDoi, KhoanQuyDoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiDataSource class.
		/// </summary>
		public KhoanQuyDoiDataSource() : base(new KhoanQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KhoanQuyDoiDataSourceView used by the KhoanQuyDoiDataSource.
		/// </summary>
		protected KhoanQuyDoiDataSourceView KhoanQuyDoiView
		{
			get { return ( View as KhoanQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KhoanQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public KhoanQuyDoiSelectMethod SelectMethod
		{
			get
			{
				KhoanQuyDoiSelectMethod selectMethod = KhoanQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KhoanQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KhoanQuyDoiDataSourceView class that is to be
		/// used by the KhoanQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the KhoanQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<KhoanQuyDoi, KhoanQuyDoiKey> GetNewDataSourceView()
		{
			return new KhoanQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the KhoanQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KhoanQuyDoiDataSourceView : ProviderDataSourceView<KhoanQuyDoi, KhoanQuyDoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KhoanQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KhoanQuyDoiDataSourceView(KhoanQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KhoanQuyDoiDataSource KhoanQuyDoiOwner
		{
			get { return Owner as KhoanQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KhoanQuyDoiSelectMethod SelectMethod
		{
			get { return KhoanQuyDoiOwner.SelectMethod; }
			set { KhoanQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KhoanQuyDoiService KhoanQuyDoiProvider
		{
			get { return Provider as KhoanQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KhoanQuyDoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KhoanQuyDoi> results = null;
			KhoanQuyDoi item;
			count = 0;
			
			System.Int32 _maKhoan;
			System.Int32? _maQuyDoi_nullable;

			switch ( SelectMethod )
			{
				case KhoanQuyDoiSelectMethod.Get:
					KhoanQuyDoiKey entityKey  = new KhoanQuyDoiKey();
					entityKey.Load(values);
					item = KhoanQuyDoiProvider.Get(entityKey);
					results = new TList<KhoanQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KhoanQuyDoiSelectMethod.GetAll:
                    results = KhoanQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KhoanQuyDoiSelectMethod.GetPaged:
					results = KhoanQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KhoanQuyDoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = KhoanQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KhoanQuyDoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KhoanQuyDoiSelectMethod.GetByMaKhoan:
					_maKhoan = ( values["MaKhoan"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoan"], typeof(System.Int32)) : (int)0;
					item = KhoanQuyDoiProvider.GetByMaKhoan(_maKhoan);
					results = new TList<KhoanQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KhoanQuyDoiSelectMethod.GetByMaQuyDoi:
					_maQuyDoi_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaQuyDoi"], typeof(System.Int32?));
					results = KhoanQuyDoiProvider.GetByMaQuyDoi(_maQuyDoi_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == KhoanQuyDoiSelectMethod.Get || SelectMethod == KhoanQuyDoiSelectMethod.GetByMaKhoan )
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
				KhoanQuyDoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KhoanQuyDoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KhoanQuyDoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KhoanQuyDoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KhoanQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KhoanQuyDoiDataSource class.
	/// </summary>
	public class KhoanQuyDoiDataSourceDesigner : ProviderDataSourceDesigner<KhoanQuyDoi, KhoanQuyDoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiDataSourceDesigner class.
		/// </summary>
		public KhoanQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoanQuyDoiSelectMethod SelectMethod
		{
			get { return ((KhoanQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KhoanQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KhoanQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the KhoanQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class KhoanQuyDoiDataSourceActionList : DesignerActionList
	{
		private KhoanQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KhoanQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KhoanQuyDoiDataSourceActionList(KhoanQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KhoanQuyDoiSelectMethod SelectMethod
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

	#endregion KhoanQuyDoiDataSourceActionList
	
	#endregion KhoanQuyDoiDataSourceDesigner
	
	#region KhoanQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KhoanQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum KhoanQuyDoiSelectMethod
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
		/// Represents the GetByMaKhoan method.
		/// </summary>
		GetByMaKhoan,
		/// <summary>
		/// Represents the GetByMaQuyDoi method.
		/// </summary>
		GetByMaQuyDoi
	}
	
	#endregion KhoanQuyDoiSelectMethod

	#region KhoanQuyDoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoanQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoanQuyDoiFilter : SqlFilter<KhoanQuyDoiColumn>
	{
	}
	
	#endregion KhoanQuyDoiFilter

	#region KhoanQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KhoanQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoanQuyDoiExpressionBuilder : SqlExpressionBuilder<KhoanQuyDoiColumn>
	{
	}
	
	#endregion KhoanQuyDoiExpressionBuilder	

	#region KhoanQuyDoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KhoanQuyDoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KhoanQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KhoanQuyDoiProperty : ChildEntityProperty<KhoanQuyDoiChildEntityTypes>
	{
	}
	
	#endregion KhoanQuyDoiProperty
}

