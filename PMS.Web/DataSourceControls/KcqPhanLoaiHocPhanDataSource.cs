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
	/// Represents the DataRepository.KcqPhanLoaiHocPhanProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqPhanLoaiHocPhanDataSourceDesigner))]
	public class KcqPhanLoaiHocPhanDataSource : ProviderDataSource<KcqPhanLoaiHocPhan, KcqPhanLoaiHocPhanKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanDataSource class.
		/// </summary>
		public KcqPhanLoaiHocPhanDataSource() : base(new KcqPhanLoaiHocPhanService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqPhanLoaiHocPhanDataSourceView used by the KcqPhanLoaiHocPhanDataSource.
		/// </summary>
		protected KcqPhanLoaiHocPhanDataSourceView KcqPhanLoaiHocPhanView
		{
			get { return ( View as KcqPhanLoaiHocPhanDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqPhanLoaiHocPhanDataSource control invokes to retrieve data.
		/// </summary>
		public KcqPhanLoaiHocPhanSelectMethod SelectMethod
		{
			get
			{
				KcqPhanLoaiHocPhanSelectMethod selectMethod = KcqPhanLoaiHocPhanSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqPhanLoaiHocPhanSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqPhanLoaiHocPhanDataSourceView class that is to be
		/// used by the KcqPhanLoaiHocPhanDataSource.
		/// </summary>
		/// <returns>An instance of the KcqPhanLoaiHocPhanDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqPhanLoaiHocPhan, KcqPhanLoaiHocPhanKey> GetNewDataSourceView()
		{
			return new KcqPhanLoaiHocPhanDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqPhanLoaiHocPhanDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqPhanLoaiHocPhanDataSourceView : ProviderDataSourceView<KcqPhanLoaiHocPhan, KcqPhanLoaiHocPhanKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqPhanLoaiHocPhanDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqPhanLoaiHocPhanDataSourceView(KcqPhanLoaiHocPhanDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqPhanLoaiHocPhanDataSource KcqPhanLoaiHocPhanOwner
		{
			get { return Owner as KcqPhanLoaiHocPhanDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqPhanLoaiHocPhanSelectMethod SelectMethod
		{
			get { return KcqPhanLoaiHocPhanOwner.SelectMethod; }
			set { KcqPhanLoaiHocPhanOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqPhanLoaiHocPhanService KcqPhanLoaiHocPhanProvider
		{
			get { return Provider as KcqPhanLoaiHocPhanService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqPhanLoaiHocPhan> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqPhanLoaiHocPhan> results = null;
			KcqPhanLoaiHocPhan item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqPhanLoaiHocPhanSelectMethod.Get:
					KcqPhanLoaiHocPhanKey entityKey  = new KcqPhanLoaiHocPhanKey();
					entityKey.Load(values);
					item = KcqPhanLoaiHocPhanProvider.Get(entityKey);
					results = new TList<KcqPhanLoaiHocPhan>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqPhanLoaiHocPhanSelectMethod.GetAll:
                    results = KcqPhanLoaiHocPhanProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqPhanLoaiHocPhanSelectMethod.GetPaged:
					results = KcqPhanLoaiHocPhanProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqPhanLoaiHocPhanSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqPhanLoaiHocPhanProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqPhanLoaiHocPhanProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqPhanLoaiHocPhanSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqPhanLoaiHocPhanProvider.GetById(_id);
					results = new TList<KcqPhanLoaiHocPhan>();
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
			if ( SelectMethod == KcqPhanLoaiHocPhanSelectMethod.Get || SelectMethod == KcqPhanLoaiHocPhanSelectMethod.GetById )
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
				KcqPhanLoaiHocPhan entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqPhanLoaiHocPhanProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqPhanLoaiHocPhan> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqPhanLoaiHocPhanProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqPhanLoaiHocPhanDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqPhanLoaiHocPhanDataSource class.
	/// </summary>
	public class KcqPhanLoaiHocPhanDataSourceDesigner : ProviderDataSourceDesigner<KcqPhanLoaiHocPhan, KcqPhanLoaiHocPhanKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanDataSourceDesigner class.
		/// </summary>
		public KcqPhanLoaiHocPhanDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhanLoaiHocPhanSelectMethod SelectMethod
		{
			get { return ((KcqPhanLoaiHocPhanDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqPhanLoaiHocPhanDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqPhanLoaiHocPhanDataSourceActionList

	/// <summary>
	/// Supports the KcqPhanLoaiHocPhanDataSourceDesigner class.
	/// </summary>
	internal class KcqPhanLoaiHocPhanDataSourceActionList : DesignerActionList
	{
		private KcqPhanLoaiHocPhanDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqPhanLoaiHocPhanDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqPhanLoaiHocPhanDataSourceActionList(KcqPhanLoaiHocPhanDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqPhanLoaiHocPhanSelectMethod SelectMethod
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

	#endregion KcqPhanLoaiHocPhanDataSourceActionList
	
	#endregion KcqPhanLoaiHocPhanDataSourceDesigner
	
	#region KcqPhanLoaiHocPhanSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqPhanLoaiHocPhanDataSource.SelectMethod property.
	/// </summary>
	public enum KcqPhanLoaiHocPhanSelectMethod
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
	
	#endregion KcqPhanLoaiHocPhanSelectMethod

	#region KcqPhanLoaiHocPhanFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanLoaiHocPhanFilter : SqlFilter<KcqPhanLoaiHocPhanColumn>
	{
	}
	
	#endregion KcqPhanLoaiHocPhanFilter

	#region KcqPhanLoaiHocPhanExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanLoaiHocPhanExpressionBuilder : SqlExpressionBuilder<KcqPhanLoaiHocPhanColumn>
	{
	}
	
	#endregion KcqPhanLoaiHocPhanExpressionBuilder	

	#region KcqPhanLoaiHocPhanProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqPhanLoaiHocPhanChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqPhanLoaiHocPhan"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqPhanLoaiHocPhanProperty : ChildEntityProperty<KcqPhanLoaiHocPhanChildEntityTypes>
	{
	}
	
	#endregion KcqPhanLoaiHocPhanProperty
}

