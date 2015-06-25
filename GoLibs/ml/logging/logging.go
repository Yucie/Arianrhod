package logging

import (
    "fmt"
    "io"
    "os"
    "sync"
    "time"
    "runtime"
    . "ml/strings"
    "path/filepath"
)

type Logger struct {
    formatter   String
    level       int
    callDepth   int
    tag         String
    out         []io.Writer
}

const (
    CRITICAL = 50
    FATAL    = CRITICAL
    ERROR    = 40
    WARNING  = 30
    WARN     = WARNING
    INFO     = 20
    DEBUG    = 10
    NOTSET   = 0
)

var levelToName = map[int]string {
    CRITICAL    : "CRITICAL",
    ERROR       : "ERROR",
    WARNING     : "WARNING",
    INFO        : "INFO",
    DEBUG       : "DEBUG",
    NOTSET      : "NOTSET",
}

var nameToLevel = map[string]int {
    "CRITICAL"  : CRITICAL,
    "ERROR"     : ERROR,
    "WARN"      : WARNING,
    "WARNING"   : WARNING,
    "INFO"      : INFO,
    "DEBUG"     : DEBUG,
    "NOTSET"    : NOTSET,
}

var lock = sync.Mutex{}

var defaultFormatter = String("[%date %time][%tag][%file][%func:%line]")

func (self *Logger) output(level int, format String, args ...interface{}) {
    if level < self.level {
        return
    }

    lock.Lock()
    defer lock.Unlock()

    t := time.Now()

    pc, file, line, ok := runtime.Caller(2)
    if !ok {
        file = "???"
        line = -1
        pc = 0
    }

    text := fmt.Sprintf(string(format), args...)

    format = self.formatter

    if format.Find("%tag") != -1 {
        format = format.Replace("%tag", self.tag)
    }

    if format.Find("%file") != -1 {
        format = format.Replace("%file", String(filepath.Base(file)))
    }

    if format.Find("%func") != -1 {
        format = format.Replace("%func", String(runtime.FuncForPC(pc).Name()))
    }

    if format.Find("%line") != -1 {
        format = format.Replace("%line", String(fmt.Sprintf("%d", line)))
    }

    if format.Find("%date") != -1 {
        year, month, day := t.Date()
        date := fmt.Sprintf("%04d-%02d-%02d", year, month, day)

        format = format.Replace("%date", String(date))
    }

    if format.Find("%time") != -1 {
        hour, min, sec := t.Clock()
        time := fmt.Sprintf("%02d:%02d:%02d", hour, min, sec)

        format = format.Replace("%time", String(time))
    }

    format += "[" + String(levelToName[level]) + "] "

    buf := []byte(format + String(text) + "\n")

    for _, out := range self.out {
        out.Write(buf)
    }
}

func (self *Logger) Debug(format String, args ...interface{}) {
    self.output(DEBUG, format, args...)
}

func (self *Logger) Fatal(format String, args ...interface{}) {
    self.output(FATAL, format, args...)
}

func (self *Logger) Error(format String, args ...interface{}) {
    self.output(ERROR, format, args...)
}

func (self *Logger) Warning(format String, args ...interface{}) {
    self.output(WARNING, format, args...)
}

func (self *Logger) Info(format String, args ...interface{}) {
    self.output(INFO, format, args...)
}

func (self *Logger) SetLevel(level int) {
    self.level = level
}

func (self *Logger) Level() int {
    return self.level
}

func (self *Logger) SetFormater(formatter ...String) {
    switch len(formatter) {
        case 0:
            self.formatter = defaultFormatter
        default:
            self.formatter = formatter[0]
    }
}

func New(tag String) *Logger {
    return &Logger{
               formatter    : defaultFormatter,
               level        : DEBUG,
               tag          : tag,
               callDepth    : 10,
               out          : []io.Writer{os.Stdout},
            }
}

func init() {

}
