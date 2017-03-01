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
	/// Represents the DataRepository.KcqHeSoDiaDiemProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqHeSoDiaDiemDataSourceDesigner))]
	public class KcqHeSoDiaDiemDataSource : ProviderDataSource<KcqHeSoDiaDiem, KcqHeSoDiaDiemKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemDataSource class.
		/// </summary>
		public KcqHeSoDiaDiemDataSource() : base(new KcqHeSoDiaDiemService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqHeSoDiaDiemDataSourceView used by the KcqHeSoDiaDiemDataSource.
		/// </summary>
		protected KcqHeSoDiaDiemDataSourceView KcqHeSoDiaDiemView
		{
			get { return ( View as KcqHeSoDiaDiemDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqHeSoDiaDiemDataSource control invokes to retrieve data.
		/// </summary>
		public KcqHeSoDiaDiemSelectMethod SelectMethod
		{
			get
			{
				KcqHeSoDiaDiemSelectMethod selectMethod = KcqHeSoDiaDiemSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqHeSoDiaDiemSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqHeSoDiaDiemDataSourceView class that is to be
		/// used by the KcqHeSoDiaDiemDataSource.
		/// </summary>
		/// <returns>An instance of the KcqHeSoDiaDiemDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqHeSoDiaDiem, KcqHeSoDiaDiemKey> GetNewDataSourceView()
		{
			return new KcqHeSoDiaDiemDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqHeSoDiaDiemDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqHeSoDiaDiemDataSourceView : ProviderDataSourceView<KcqHeSoDiaDiem, KcqHeSoDiaDiemKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqHeSoDiaDiemDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqHeSoDiaDiemDataSourceView(KcqHeSoDiaDiemDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqHeSoDiaDiemDataSource KcqHeSoDiaDiemOwner
		{
			get { return Owner as KcqHeSoDiaDiemDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqHeSoDiaDiemSelectMethod SelectMethod
		{
			get { return KcqHeSoDiaDiemOwner.SelectMethod; }
			set { KcqHeSoDiaDiemOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqHeSoDiaDiemService KcqHeSoDiaDiemProvider
		{
			get { return Provider as KcqHeSoDiaDiemService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqHeSoDiaDiem> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqHeSoDiaDiem> results = null;
			KcqHeSoDiaDiem item;
			count = 0;
			
			System.Int32 _maHeSo;

			switch ( SelectMethod )
			{
				case KcqHeSoDiaDiemSelectMethod.Get:
					KcqHeSoDiaDiemKey entityKey  = new KcqHeSoDiaDiemKey();
					entityKey.Load(values);
					item = KcqHeSoDiaDiemProvider.Get(entityKey);
					results = new TList<KcqHeSoDiaDiem>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqHeSoDiaDiemSelectMethod.GetAll:
                    results = KcqHeSoDiaDiemProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqHeSoDiaDiemSelectMethod.GetPaged:
					results = KcqHeSoDiaDiemProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqHeSoDiaDiemSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqHeSoDiaDiemProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqHeSoDiaDiemProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqHeSoDiaDiemSelectMethod.GetByMaHeSo:
					_maHeSo = ( values["MaHeSo"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["MaHeSo"], typeof(System.Int32)) : (int)0;
					item = KcqHeSoDiaDiemProvider.GetByMaHeSo(_maHeSo);
					results = new TList<KcqHeSoDiaDiem>();
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
			if ( SelectMethod == KcqHeSoDiaDiemSelectMethod.Get || SelectMethod == KcqHeSoDiaDiemSelectMethod.GetByMaHeSo )
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
				KcqHeSoDiaDiem entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqHeSoDiaDiemProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqHeSoDiaDiem> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqHeSoDiaDiemProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqHeSoDiaDiemDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqHeSoDiaDiemDataSource class.
	/// </summary>
	public class KcqHeSoDiaDiemDataSourceDesigner : ProviderDataSourceDesigner<KcqHeSoDiaDiem, KcqHeSoDiaDiemKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemDataSourceDesigner class.
		/// </summary>
		public KcqHeSoDiaDiemDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHeSoDiaDiemSelectMethod SelectMethod
		{
			get { return ((KcqHeSoDiaDiemDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqHeSoDiaDiemDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqHeSoDiaDiemDataSourceActionList

	/// <summary>
	/// Supports the KcqHeSoDiaDiemDataSourceDesigner class.
	/// </summary>
	internal class KcqHeSoDiaDiemDataSourceActionList : DesignerActionList
	{
		private KcqHeSoDiaDiemDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqHeSoDiaDiemDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqHeSoDiaDiemDataSourceActionList(KcqHeSoDiaDiemDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqHeSoDiaDiemSelectMethod SelectMethod
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

	#endregion KcqHeSoDiaDiemDataSourceActionList
	
	#endregion KcqHeSoDiaDiemDataSourceDesigner
	
	#region KcqHeSoDiaDiemSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqHeSoDiaDiemDataSource.SelectMethod property.
	/// </summary>
	public enum KcqHeSoDiaDiemSelectMethod
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
		/// Represents the GetByMaHeSo method.
		/// </summary>
		GetByMaHeSo
	}
	
	#endregion KcqHeSoDiaDiemSelectMethod

	#region KcqHeSoDiaDiemFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoDiaDiem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoDiaDiemFilter : SqlFilter<KcqHeSoDiaDiemColumn>
	{
	}
	
	#endregion KcqHeSoDiaDiemFilter

	#region KcqHeSoDiaDiemExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoDiaDiem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoDiaDiemExpressionBuilder : SqlExpressionBuilder<KcqHeSoDiaDiemColumn>
	{
	}
	
	#endregion KcqHeSoDiaDiemExpressionBuilder	

	#region KcqHeSoDiaDiemProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqHeSoDiaDiemChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqHeSoDiaDiem"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqHeSoDiaDiemProperty : ChildEntityProperty<KcqHeSoDiaDiemChildEntityTypes>
	{
	}
	
	#endregion KcqHeSoDiaDiemProperty
}

