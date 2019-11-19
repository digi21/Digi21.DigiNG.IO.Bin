using Digi21.Digi3D;
using Digi21.DigiNG.Entities;
using Digi21.Math;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Digi21.DigiNG.IO.Bin
{
    public class Bin : IDrawingFile, IDisposable
    {
        public event ProgressEventHandler ProgressChanged;
        public event ResultsAddedEventHandler ResultsAdded;
        public event TaskAddedEventHandler TaskAdded;

        public Bin(string path, int decimals, Point3D globalOrigin) { throw null; }
        public Bin(string path, int decimals, Point3D globalOrigin, DigiTab.DigiTab digiTab) { throw null; }
        public Bin(string path, int decimals, Point3D globalOrigin, DelegateGetWkt GetWkt) { throw null; }
        public Bin(string path, int decimals, Point3D globalOrigin, bool readOnly) { throw null; }
        public Bin(string path, int decimals, Point3D globalOrigin, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt) { throw null; }
        public Bin(string path, int decimals, Point3D globalOrigin, DigiTab.DigiTab digiTab, bool readOnly) { throw null; }
        public Bin(string path, int decimals, Point3D globalOrigin, DelegateGetWkt GetWkt, bool readOnly) { throw null; }
        public Bin(string path, int decimals, Point3D globalOrigin, DigiTab.DigiTab digiTab, DelegateGetWkt GetWkt, bool readOnly) { throw null; }
        public ReadOnlyComplex Add(Complex complex) { throw null; }
        public void Add(Entity entity) { throw null; }
        public ReadOnlyLine Add(Line line) { throw null; }
        public ReadOnlyPoint Add(Point point) { throw null; }
        public ReadOnlyPolygon Add(Polygon polygon) { throw null; }
        public ReadOnlyText Add(Text text) { throw null; }
        public void Add(IEnumerable<Entity> entities) { throw null; }
        public void Add(Entity entity, IDictionary<string, IDictionary<string, object>> databaseAttributes) { throw null; }
        public void Delete(Entity entity) { throw null; }
        public void Delete(IEnumerable<Entity> entities) { throw null; }
        public void Dispose() { throw null; }
        public IDictionary<string, IDictionary<string, object>> GetDatabaseAttributes(Entity entity) { throw null; }
        public IEnumerator<Entity> GetEnumerator() { throw null; }
        IEnumerator IEnumerable.GetEnumerator() { throw null; }
        public Point3D GlobalOrigin { get; }
        public int Decimals { get; }
        public string Wkt { get; }
        public IDictionary<string, int> DatabaseTables { get; }
        public bool CanWrite { get; }
        public bool CanRead { get; }
        public string Path { get; }
    }
}
