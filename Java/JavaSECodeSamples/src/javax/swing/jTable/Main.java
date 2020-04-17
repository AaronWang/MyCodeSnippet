package javax.swing.jTable;

import java.awt.BorderLayout;
import java.awt.Container;

import javax.swing.JFrame;
import javax.swing.JScrollPane;
import javax.swing.JTable;
import javax.swing.table.AbstractTableModel;

class SimpleTableModel extends AbstractTableModel {
	private Object[][] data = {};
	// private String[] columnNames = { "ID", "Name", "Gender" };
//	private Class[] columnClass = { Integer.class, String.class, String.class };
	private Object[][] rowData = new Object[][] { { new Integer(1), "Tom", "Male" }, { new Integer(2), "Jack", "Female" } };

	public SimpleTableModel() {
	}

	@Override
	public int getRowCount() {
		return rowData.length;
	}

	@Override
	public int getColumnCount() {
		// return columnNames.length;
		return 3;
	}

	@Override
	public String getColumnName(int columnIndex) {
		// return columnNames[columnIndex];
		switch (columnIndex) {
		case 0:
			return "ID";
		case 1:
			return "Name";
		case 2:
			return "Gender";
		default:
			return "";
		}
	}

//	@Override
//	public Class getColumnClass(int columnIndex) {
////		return columnClass[columnIndex];
//		return String.class;
//	}

//	@Override
//	public boolean isCellEditable(int rowIndex, int columnIndex) {
//		boolean isEditable = true;
//		if (columnIndex == 0) {
//			isEditable = false; // Make the ID column non-editable
//		}
//		return isEditable;
//	}

	@Override
	public Object getValueAt(int rowIndex, int columnIndex) {
		return rowData[rowIndex][columnIndex];
	}

	@Override
	public void setValueAt(Object aValue, int rowIndex, int columnIndex) {
		rowData[rowIndex][columnIndex] = aValue;
	}
}

public class Main extends JFrame {
	/**
	 * 
	 */
	private static final long serialVersionUID = 1L;

	public Main() {
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);

		JTable table = new JTable(new SimpleTableModel());

		Container contentPane = this.getContentPane();
		contentPane.add(new JScrollPane(table), BorderLayout.CENTER);
	}

	public static void main(String[] args) {
		Main bf = new Main();
		bf.pack();
		bf.setVisible(true);
	}
}