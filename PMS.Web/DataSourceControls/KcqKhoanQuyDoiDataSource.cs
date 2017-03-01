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
	/// Represents the DataRepository.KcqKhoanQuyDoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqKhoanQuyDoiDataSourceDesigner))]
	public class KcqKhoanQuyDoiDataSource : ProviderDataSource<KcqKhoanQuyDoi, KcqKhoanQuyDoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoanQuyDoiDataSource class.
		/// </summary>
		public KcqKhoanQuyDoiDataSource() : base(new KcqKhoanQuyDoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqKhoanQuyDoiDataSourceView used by the KcqKhoanQuyDoiDataSource.
		/// </summary>
		protected KcqKhoanQuyDoiDataSourceView KcqKhoanQuyDoiView
		{
			get { return ( View as KcqKhoanQuyDoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqKhoanQuyDoiDataSource control invokes to retrieve data.
		/// </summary>
		public KcqKhoanQuyDoiSelectMethod SelectMethod
		{
			get
			{
				KcqKhoanQuyDoiSelectMethod selectMethod = KcqKhoanQuyDoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqKhoanQuyDoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqKhoanQuyDoiDataSourceView class that is to be
		/// used by the KcqKhoanQuyDoiDataSource.
		/// </summary>
		/// <returns>An instance of the KcqKhoanQuyDoiDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqKhoanQuyDoi, KcqKhoanQuyDoiKey> GetNewDataSourceView()
		{
			return new KcqKhoanQuyDoiDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqKhoanQuyDoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqKhoanQuyDoiDataSourceView : ProviderDataSourceView<KcqKhoanQuyDoi, KcqKhoanQuyDoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqKhoanQuyDoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqKhoanQuyDoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqKhoanQuyDoiDataSourceView(KcqKhoanQuyDoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqKhoanQuyDoiDataSource KcqKhoanQuyDoiOwner
		{
			get { return Owner as KcqKhoanQuyDoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqKhoanQuyDoiSelectMethod SelectMethod
		{
			get { return KcqKhoanQuyDoiOwner.SelectMethod; }
			set { KcqKhoanQuyDoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqKhoanQuyDoiService KcqKhoanQuyDoiProvider
		{
			get { return Provider as KcqKhoanQuyDoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqKhoanQuyDoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqKhoanQuyDoi> results = null;
			KcqKhoanQuyDoi item;
			count = 0;
			
			System.Int32 _maKhoan;
			System.Int32? _maQuyDoi_nullable;

			switch ( SelectMethod )
			{
				case KcqKhoanQuyDoiSelectMethod.Get:
					KcqKhoanQuyDoiKey entityKey  = new KcqKhoanQuyDoiKey();
					entityKey.Load(values);
					item = KcqKhoanQuyDoiProvider.Get(entityKey);
					results = new TList<KcqKhoanQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqKhoanQuyDoiSelectMethod.GetAll:
                    results = KcqKhoanQuyDoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqKhoanQuyDoiSelectMethod.GetPaged:
					results = KcqKhoanQuyDoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqKhoanQuyDoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqKhoanQuyDoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqKhoanQuyDoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqKhoanQuyDoiSelectMethod.GetByMaKhoan:
					_maKhoan = ( values["MaKhoan"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaKhoan"], typeof(System.Int32)) : (int)0;
					item = KcqKhoanQuyDoiProvider.GetByMaKhoan(_maKhoan);
					results = new TList<KcqKhoanQuyDoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				// FK
				case KcqKhoanQuyDoiSelectMethod.GetByMaQuyDoi:
					_maQuyDoi_nullable = (System.Int32?) EntityUtil.ChangeType(values["MaQuyDoi"], typeof(System.Int32?));
					results = KcqKhoanQuyDoiProvider.GetByMaQuyDoi(_maQuyDoi_nullable, this.StartIndex, this.PageSize, out count);
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
			if ( SelectMethod == KcqKhoanQuyDoiSelectMethod.Get || SelectMethod == KcqKhoanQuyDoiSelectMethod.GetByMaKhoan )
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
				KcqKhoanQuyDoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqKhoanQuyDoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqKhoanQuyDoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqKhoanQuyDoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqKhoanQuyDoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqKhoanQuyDoiDataSource class.
	/// </summary>
	public class KcqKhoanQuyDoiDataSourceDesigner : ProviderDataSourceDesigner<KcqKhoanQuyDoi, KcqKhoanQuyDoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqKhoanQuyDoiDataSourceDesigner class.
		/// </summary>
		public KcqKhoanQuyDoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoanQuyDoiSelectMethod SelectMethod
		{
			get { return ((KcqKhoanQuyDoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqKhoanQuyDoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqKhoanQuyDoiDataSourceActionList

	/// <summary>
	/// Supports the KcqKhoanQuyDoiDataSourceDesigner class.
	/// </summary>
	internal class KcqKhoanQuyDoiDataSourceActionList : DesignerActionList
	{
		private KcqKhoanQuyDoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqKhoanQuyDoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqKhoanQuyDoiDataSourceActionList(KcqKhoanQuyDoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqKhoanQuyDoiSelectMethod SelectMethod
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

	#endregion KcqKhoanQuyDoiDataSourceActionList
	
	#endregion KcqKhoanQuyDoiDataSourceDesigner
	
	#region KcqKhoanQuyDoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqKhoanQuyDoiDataSource.SelectMethod property.
	/// </summary>
	public enum KcqKhoanQuyDoiSelectMethod
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
	
	#endregion KcqKhoanQuyDoiSelectMethod

	#region KcqKhoanQuyDoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoanQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoanQuyDoiFilter : SqlFilter<KcqKhoanQuyDoiColumn>
	{
	}
	
	#endregion KcqKhoanQuyDoiFilter

	#region KcqKhoanQuyDoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoanQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoanQuyDoiExpressionBuilder : SqlExpressionBuilder<KcqKhoanQuyDoiColumn>
	{
	}
	
	#endregion KcqKhoanQuyDoiExpressionBuilder	

	#region KcqKhoanQuyDoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqKhoanQuyDoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqKhoanQuyDoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqKhoanQuyDoiProperty : ChildEntityProperty<KcqKhoanQuyDoiChildEntityTypes>
	{
	}
	
	#endregion KcqKhoanQuyDoiProperty
}

