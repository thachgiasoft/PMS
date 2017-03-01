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
	/// Represents the DataRepository.KcqMonTinhTheoQuyCheMoiProvider object that provides
	/// data to data-bound controls in multi-tier Web application architectures.
	/// </summary>
	[Designer(typeof(KcqMonTinhTheoQuyCheMoiDataSourceDesigner))]
	public class KcqMonTinhTheoQuyCheMoiDataSource : ProviderDataSource<KcqMonTinhTheoQuyCheMoi, KcqMonTinhTheoQuyCheMoiKey>
	{
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonTinhTheoQuyCheMoiDataSource class.
		/// </summary>
		public KcqMonTinhTheoQuyCheMoiDataSource() : base(new KcqMonTinhTheoQuyCheMoiService())
		{
		}

		#endregion Constructors
		
		#region Properties
		
		/// <summary>
		/// Gets a reference to the KcqMonTinhTheoQuyCheMoiDataSourceView used by the KcqMonTinhTheoQuyCheMoiDataSource.
		/// </summary>
		protected KcqMonTinhTheoQuyCheMoiDataSourceView KcqMonTinhTheoQuyCheMoiView
		{
			get { return ( View as KcqMonTinhTheoQuyCheMoiDataSourceView ); }
		}
		
		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the KcqMonTinhTheoQuyCheMoiDataSource control invokes to retrieve data.
		/// </summary>
		public KcqMonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get
			{
				KcqMonTinhTheoQuyCheMoiSelectMethod selectMethod = KcqMonTinhTheoQuyCheMoiSelectMethod.GetAll;
				Object method = ViewState["SelectMethod"];
				if ( method != null )
				{
					selectMethod = (KcqMonTinhTheoQuyCheMoiSelectMethod) method;
				}
				return selectMethod;
			}
			set { ViewState["SelectMethod"] = value; }
		}

		#endregion Properties
		
		#region Methods

		/// <summary>
		/// Creates a new instance of the KcqMonTinhTheoQuyCheMoiDataSourceView class that is to be
		/// used by the KcqMonTinhTheoQuyCheMoiDataSource.
		/// </summary>
		/// <returns>An instance of the KcqMonTinhTheoQuyCheMoiDataSourceView class.</returns>
		protected override BaseDataSourceView<KcqMonTinhTheoQuyCheMoi, KcqMonTinhTheoQuyCheMoiKey> GetNewDataSourceView()
		{
			return new KcqMonTinhTheoQuyCheMoiDataSourceView(this, DefaultViewName);
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
	/// Supports the KcqMonTinhTheoQuyCheMoiDataSource control and provides an interface for
	/// data-bound controls to perform data operations with business and data objects.
	/// </summary>
	public class KcqMonTinhTheoQuyCheMoiDataSourceView : ProviderDataSourceView<KcqMonTinhTheoQuyCheMoi, KcqMonTinhTheoQuyCheMoiKey>
	{
		#region Declarations

		#endregion Declarations
		
		#region Constructors

		/// <summary>
		/// Initializes a new instance of the KcqMonTinhTheoQuyCheMoiDataSourceView class.
		/// </summary>
		/// <param name="owner">A reference to the KcqMonTinhTheoQuyCheMoiDataSource which created this instance.</param>
		/// <param name="viewName">The name of the view.</param>
		public KcqMonTinhTheoQuyCheMoiDataSourceView(KcqMonTinhTheoQuyCheMoiDataSource owner, String viewName)
			: base(owner, viewName)
		{
		}
		
		#endregion Constructors
		
		#region Properties

		/// <summary>
		/// Gets a strongly-typed reference to the Owner property.
		/// </summary>
		internal KcqMonTinhTheoQuyCheMoiDataSource KcqMonTinhTheoQuyCheMoiOwner
		{
			get { return Owner as KcqMonTinhTheoQuyCheMoiDataSource; }
		}

		/// <summary>
		/// Gets or sets the name of the method or function that
		/// the DataSource control invokes to retrieve data.
		/// </summary>
		internal KcqMonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get { return KcqMonTinhTheoQuyCheMoiOwner.SelectMethod; }
			set { KcqMonTinhTheoQuyCheMoiOwner.SelectMethod = value; }
		}

		/// <summary>
		/// Gets a strongly typed reference to the Provider property.
		/// </summary>
		internal KcqMonTinhTheoQuyCheMoiService KcqMonTinhTheoQuyCheMoiProvider
		{
			get { return Provider as KcqMonTinhTheoQuyCheMoiService; }
		}

		#endregion Properties
		
		#region Methods
		 
		/// <summary>
		/// Gets a collection of Entity objects based on the value of the SelectMethod property.
		/// </summary>
		/// <param name="count">The total number of rows in the DataSource.</param>
	    /// <param name="values"></param>
		/// <returns>A collection of Entity objects.</returns>
		protected override IList<KcqMonTinhTheoQuyCheMoi> GetSelectData(IDictionary values, out int count)
		{
            if (values == null || values.Count == 0) values = CollectionsUtil.CreateCaseInsensitiveHashtable(GetParameterValues());
            
			Hashtable customOutput = CollectionsUtil.CreateCaseInsensitiveHashtable();
			IList<KcqMonTinhTheoQuyCheMoi> results = null;
			KcqMonTinhTheoQuyCheMoi item;
			count = 0;
			
			System.Int32 _id;

			switch ( SelectMethod )
			{
				case KcqMonTinhTheoQuyCheMoiSelectMethod.Get:
					KcqMonTinhTheoQuyCheMoiKey entityKey  = new KcqMonTinhTheoQuyCheMoiKey();
					entityKey.Load(values);
					item = KcqMonTinhTheoQuyCheMoiProvider.Get(entityKey);
					results = new TList<KcqMonTinhTheoQuyCheMoi>();
					if ( item != null ) results.Add(item);
					count = results.Count;
					break;
				case KcqMonTinhTheoQuyCheMoiSelectMethod.GetAll:
                    results = KcqMonTinhTheoQuyCheMoiProvider.GetAll(StartIndex, PageSize, out count);
                    break;
				case KcqMonTinhTheoQuyCheMoiSelectMethod.GetPaged:
					results = KcqMonTinhTheoQuyCheMoiProvider.GetPaged(WhereClause, OrderBy, PageIndex, PageSize, out count);
					break;
				case KcqMonTinhTheoQuyCheMoiSelectMethod.Find:
					if ( FilterParameters != null )
						results = KcqMonTinhTheoQuyCheMoiProvider.Find(FilterParameters, OrderBy, StartIndex, PageSize, out count);
					else
						results = KcqMonTinhTheoQuyCheMoiProvider.Find(WhereClause, StartIndex, PageSize, out count);
                    break;
				// PK
				case KcqMonTinhTheoQuyCheMoiSelectMethod.GetById:
					_id = ( values["Id"] != null ) ? (System.Int32) EntityUtil.ChangeType(values["Id"], typeof(System.Int32)) : (int)0;
					item = KcqMonTinhTheoQuyCheMoiProvider.GetById(_id);
					results = new TList<KcqMonTinhTheoQuyCheMoi>();
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
			if ( SelectMethod == KcqMonTinhTheoQuyCheMoiSelectMethod.Get || SelectMethod == KcqMonTinhTheoQuyCheMoiSelectMethod.GetById )
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
				KcqMonTinhTheoQuyCheMoi entity = GetCurrentEntity();
				
				if ( entity != null )
				{
					// init transaction manager
					GetTransactionManager();
					// execute deep load method
					KcqMonTinhTheoQuyCheMoiProvider.DeepLoad(GetCurrentEntity(), EnableRecursiveDeepLoad);
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
		internal override void DeepLoad(TList<KcqMonTinhTheoQuyCheMoi> entityList, ProviderDataSourceDeepLoadList properties)
		{
			// init transaction manager
			GetTransactionManager();
			// execute deep load method
			KcqMonTinhTheoQuyCheMoiProvider.DeepLoad(entityList, properties.Recursive, properties.Method, properties.GetTypes());
		}

		#endregion Select Methods
	}
	
	#region KcqMonTinhTheoQuyCheMoiDataSourceDesigner

	/// <summary>
	/// Provides design-time support in a design host for the KcqMonTinhTheoQuyCheMoiDataSource class.
	/// </summary>
	public class KcqMonTinhTheoQuyCheMoiDataSourceDesigner : ProviderDataSourceDesigner<KcqMonTinhTheoQuyCheMoi, KcqMonTinhTheoQuyCheMoiKey>
	{
		/// <summary>
		/// Initializes a new instance of the KcqMonTinhTheoQuyCheMoiDataSourceDesigner class.
		/// </summary>
		public KcqMonTinhTheoQuyCheMoiDataSourceDesigner()
		{
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonTinhTheoQuyCheMoiSelectMethod SelectMethod
		{
			get { return ((KcqMonTinhTheoQuyCheMoiDataSource) DataSource).SelectMethod; }
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
				actions.Add(new KcqMonTinhTheoQuyCheMoiDataSourceActionList(this));
				actions.AddRange(base.ActionLists);
				return actions;
			}
		}
	}

	#region KcqMonTinhTheoQuyCheMoiDataSourceActionList

	/// <summary>
	/// Supports the KcqMonTinhTheoQuyCheMoiDataSourceDesigner class.
	/// </summary>
	internal class KcqMonTinhTheoQuyCheMoiDataSourceActionList : DesignerActionList
	{
		private KcqMonTinhTheoQuyCheMoiDataSourceDesigner _designer;

		/// <summary>
		/// Initializes a new instance of the KcqMonTinhTheoQuyCheMoiDataSourceActionList class.
		/// </summary>
		/// <param name="designer"></param>
		public KcqMonTinhTheoQuyCheMoiDataSourceActionList(KcqMonTinhTheoQuyCheMoiDataSourceDesigner designer) : base(designer.Component)
		{
			_designer = designer;
		}

		/// <summary>
		/// Gets or sets the SelectMethod property.
		/// </summary>
		public KcqMonTinhTheoQuyCheMoiSelectMethod SelectMethod
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

	#endregion KcqMonTinhTheoQuyCheMoiDataSourceActionList
	
	#endregion KcqMonTinhTheoQuyCheMoiDataSourceDesigner
	
	#region KcqMonTinhTheoQuyCheMoiSelectMethod
	
	/// <summary>
	/// Enumeration of method names available for the KcqMonTinhTheoQuyCheMoiDataSource.SelectMethod property.
	/// </summary>
	public enum KcqMonTinhTheoQuyCheMoiSelectMethod
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
	
	#endregion KcqMonTinhTheoQuyCheMoiSelectMethod

	#region KcqMonTinhTheoQuyCheMoiFilter
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlFilter&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonTinhTheoQuyCheMoiFilter : SqlFilter<KcqMonTinhTheoQuyCheMoiColumn>
	{
	}
	
	#endregion KcqMonTinhTheoQuyCheMoiFilter

	#region KcqMonTinhTheoQuyCheMoiExpressionBuilder
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="SqlExpressionBuilder&lt;EntityColumn&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonTinhTheoQuyCheMoiExpressionBuilder : SqlExpressionBuilder<KcqMonTinhTheoQuyCheMoiColumn>
	{
	}
	
	#endregion KcqMonTinhTheoQuyCheMoiExpressionBuilder	

	#region KcqMonTinhTheoQuyCheMoiProperty
	
	/// <summary>
	/// A strongly-typed instance of the <see cref="ChildEntityProperty&lt;KcqMonTinhTheoQuyCheMoiChildEntityTypes&gt;"/> class
	/// that is used exclusively with a <see cref="KcqMonTinhTheoQuyCheMoi"/> object.
	/// </summary>
	[CLSCompliant(true)]
	public class KcqMonTinhTheoQuyCheMoiProperty : ChildEntityProperty<KcqMonTinhTheoQuyCheMoiChildEntityTypes>
	{
	}
	
	#endregion KcqMonTinhTheoQuyCheMoiProperty
}

