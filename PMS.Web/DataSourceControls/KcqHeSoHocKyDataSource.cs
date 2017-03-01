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
	/// Represents the DataRepository.KcqHeSoHocKyProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqHeSoHocKyDataSourceDesigner))]
	public class KcqHeSoHocKyDataSource : ProviderDataSource<KcqHeSoHocKy, KcqHeSoHocKyKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoHocKyDataSource class.
		/// </summary>
		public KcqHeSoHocKyDataSource() : base(new KcqHeSoHocKyService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqHeSoHocKyDataSourceView used by the KcqHeSoHocKyDataSource.
		/// </summary>
		protected KcqHeSoHocKyDataSourceView KcqHeSoHocKyView
		{
			get { return ( View as KcqHeSoHocKyDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqHeSoHocKyDataSource control invokes to retrieve data.
		/// </summary>
		public KcqHeSoHocKySelectMethod SelectMethod
		{
			get
			{
				KcqHeSoHocKySelectMethod selectMethod = KcqHeSoHocKySelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqHeSoHocKySelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqHeSoHocKyDataSourceView class that is to be
		/// used by the KcqHeSoHocKyDataSource.
		/// </summary>
		/// <returns>An instance of the KcqHeSoHocKyDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqHeSoHocKy, KcqHeSoHocKyKey> GetNewDataSourceView()
		{
			return new KcqHeSoHocKyDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqHeSoHocKyDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqHeSoHocKyDataSourceView : ProviderDataSourceView<KcqHeSoHocKy, KcqHeSoHocKyKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoHocKyDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqHeSoHocKyDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqHeSoHocKyDataSourceView(KcqHeSoHocKyDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqHeSoHocKyDataSource KcqHeSoHocKyOwner
		{
			get { return Owner as KcqHeSoHocKyDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqHeSoHocKySelectMethod SelectMethod
		{
			get { return KcqHeSoHocKyOwner.SelectMethod; }
			set { KcqHeSoHocKyOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqHeSoHocKyService KcqHeSoHocKyProvider
		{
			get { return Provider as KcqHeSoHocKyService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqHeSoHocKy> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqHeSoHocKy> results = null;
			KcqHeSoHocKy item;
			count = 0;
			
			System.String _maQuanLy_nullable;
			System.Int32 _maHocKy;

			switch ( SelectMethod )
			{
				case KcqHeSoHocKySelectMethod.Get:
					KcqHeSoHocKyKey entityKey  = new KcqHeSoHocKyKey();
					entityKey.Load(values);
					item = KcqHeSoHocKyProvider.Get(entityKey);
					results = new TList<KcqHeSoHocKy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqHeSoHocKySelectMethod.GetAll:
                    results = KcqHeSoHocKyProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqHeSoHocKySelectMethod.GetPaged:
					results = KcqHeSoHocKyProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqHeSoHocKySelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqHeSoHocKyProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqHeSoHocKyProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqHeSoHocKySelectMethod.GetByMaHocKy:
					_maHocKy = ( values["MaHocKy"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHocKy"], typeof(System.Int32)) : (int)0;
					item = KcqHeSoHocKyProvider.GetByMaHocKy(_maHocKy);
					results = new TList<KcqHeSoHocKy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				// IX
				case KcqHeSoHocKySelectMethod.GetByMaQuanLy:
					_maQuanLy_nullable = (System.String) EntityUtil.ChangeType(values["MaQuanLy"], typeof(System.String));
					item = KcqHeSoHocKyProvider.GetByMaQuanLy(_maQuanLy_nullable);
					results = new TList<KcqHeSoHocKy>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
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
			if ( SelectMethod == KcqHeSoHocKySelectMethod.Get || SelectMethod == KcqHeSoHocKySelectMethod.GetByMaHocKy )
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
				KcqHeSoHocKy entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqHeSoHocKyProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqHeSoHocKy> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqHeSoHocKyProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqHeSoHocKyDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqHeSoHocKyDataSource class.
	/// </summary>
	public class KcqHeSoHocKyDataSourceDesigner : ProviderDataSourceDesigner<KcqHeSoHocKy, KcqHeSoHocKyKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqHeSoHocKyDataSourceDesigner class.
		/// </summary>
		public KcqHeSoHocKyDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHeSoHocKySelectMethod SelectMethod
		{
			get { return ((KcqHeSoHocKyDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqHeSoHocKyDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqHeSoHocKyDataSourceActionList

	/// <summary>
	/// Supports the KcqHeSoHocKyDataSourceDesigner class.
	/// </summary>
	internal class KcqHeSoHocKyDataSourceActionList : DesignerActionList
	{
		private KcqHeSoHocKyDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqHeSoHocKyDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqHeSoHocKyDataSourceActionList(KcqHeSoHocKyDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHeSoHocKySelectMethod SelectMethod
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

	#endregion KcqHeSoHocKyDataSourceActionList
	
	#endregion KcqHeSoHocKyDataSourceDesigner
	
	#region KcqHeSoHocKySelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqHeSoHocKyDataSource.SelectMethod property.
	/// </summary>
	public enum KcqHeSoHocKySelectMethod
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
		/// Represents the GetByMaQuanLy method.
		/// </summary>
		GetByMaQuanLy,
		/// <summary>
		/// Represents the GetByMaHocKy method.
		/// </summary>
		GetByMaHocKy
	}
	
	#endregion KcqHeSoHocKySelectMethod

	#region KcqHeSoHocKyFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoHocKyFilter : SqlFilter<KcqHeSoHocKyColumn>
	{
	}
	
	#endregion KcqHeSoHocKyFilter

	#region KcqHeSoHocKyExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoHocKyExpressionBuilder : SqlExpressionBuilder<KcqHeSoHocKyColumn>
	{
	}
	
	#endregion KcqHeSoHocKyExpressionBuilder	

	#region KcqHeSoHocKyProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqHeSoHocKyChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoHocKy"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoHocKyProperty : ChildEntityProperty<KcqHeSoHocKyChildEntityTypes>
	{
	}
	
	#endregion KcqHeSoHocKyProperty
}

